using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.IO;
using System.Linq;

namespace DymeAntlr
{

    public class ReturnValue : Exception
    {
        public dynamic value; 
    }

    public class DymeEnum
    {
        public List<string> children;
        public string name;
    }


    public class Scope
    {
        public Dictionary<string, dynamic> memory = new Dictionary<string, dynamic>();
        public Scope childScope;
    }

    public class DymeEnumerable
    {
        public string name;
        public static bool operator ==(DymeEnumerable x, DymeEnumerable y)
        {
            return x.name == y.name;
        }
        public static bool operator !=(DymeEnumerable x, DymeEnumerable y)
        {
            return x.name != y.name;
        }
    }


    public class DymeObject
    {
        public Dictionary<string, dynamic> children = new Dictionary<string, dynamic>();
        public string name { get; set; }
    }

    public class DymeType
    {
        public readonly Dictionary<string, dynamic> children = new Dictionary<string, dynamic>();
        public string name { get; set; }
    }

    public class DymeFunction
    {
        public List<string> arguments = new List<string>();
        public string name;
        public dymeParser.BlockContext block;
    }

    public class DymeClass
    {
        public Dictionary<string, dynamic> children = new Dictionary<string, dynamic>();
        public DymeFunction constructor;
        public List<string> arguments;
        public bool @static;
        public string name;
    }



    public class dymeVisitor : dymeBaseVisitor<dynamic>
    {
        public Scope globalScope = new Scope();
        public Scope currentScope;

        public dymeVisitor()
        {
            currentScope = globalScope;
        }



        public override dynamic VisitImportStmt(dymeParser.ImportStmtContext context)
        {
            string dir = Environment.CurrentDirectory;

            return base.VisitImportStmt(context);
        }

        public override dynamic VisitFunc(dymeParser.FuncContext context)
        {
            DymeFunction func = new DymeFunction();
            if (context.args() != null)
                func.arguments = Visit(context.args());
            else
                func.arguments = null;
            func.block = context.block();
            return func;
        }

        public override dynamic VisitArgs(dymeParser.ArgsContext context)
        {
            var ret = new List<string>();
            foreach (var param in context.IDENTIFIER())
            {
                ret.Add(param.GetText());
            }
            return ret;
        }


        public override dynamic VisitAdditiveExpr(dymeParser.AdditiveExprContext context)
        {
            var left  = Visit(context.GetChild(0));
            var op    = context.operatorToken.Text;
            var right = Visit(context.GetChild(2));

            if (op == "+")
                return left + right;
            else if (op == "-")
                return left - right;

            return base.VisitAdditiveExpr(context);
        }

        public override dynamic VisitIndexExpr(dymeParser.IndexExprContext context)
        {
            var list = currentScope.memory[context.IDENTIFIER().GetText()];
            var i = Visit(context.expr());
            return list[Convert.ToInt32(i)];
        }

        public override dynamic VisitOption(dymeParser.OptionContext context)
        {
            Console.WriteLine(context.expr()[0]);
            return base.VisitOption(context);
        }

        public void prettyPrintObj(DymeObject value, string indentation = "  ")
        {
            Console.WriteLine(value.name + " {");
            foreach (var key in value.children.Keys)
            {
                if (value.children[key] is DymeObject)
                {
                    Console.Write(indentation + key + ": ");
                    prettyPrintObj(value.children[key], indentation + " ");
                } else { 
                    Console.WriteLine(indentation + key + ": " + value.children[key]);
                }
            }
            Console.WriteLine(indentation.Substring(0, indentation.Length - 2) + "}");
        }

        public void prettyPrintList(List<object> value)
        {
            int i = 0;
            Console.Write("[");
            foreach (var item in value)
            {
                if (item is List<object>)
                {
                    prettyPrintList((List<object>)item);
                } else
                {
                    Console.Write(item);
                }
                if (i < value.Count)
                    Console.Write(", ");
            }
            Console.Write("]");
        }

        List<string> globalFunctions = new List<string>
        {
            "writeln",
            "map"
        };

       

        public void writeln(object value)
        {
            if (value is List<object>)
            {
                prettyPrintList((List<object>)value);
                Console.WriteLine();
            }
            else if (value is DymeObject)
                prettyPrintObj((DymeObject)value);
            else if (value is DymeEnumerable)
                Console.WriteLine(((DymeEnumerable)value).name);
            else
                Console.WriteLine(value);
        }

        public dynamic map(DymeFunction fn, dynamic list)
        {
            var ret = new List<object>();
            try
            {
                foreach (var item in list)
                {
                    ret.Add(callLocalFunction(fn.name, new List<object> { item }));
                }
            } catch (Exception)
            {
                throw new Exception("Mapped item (argument 2) is not a list!");
            }
            return ret;
        }


        dynamic callLocalFunction(string name, dynamic @params)
        {
            return callFunction(currentScope.memory[name], @params);
        }

        dynamic callFunction(DymeFunction fn, dynamic @params)
        {
            DymeFunction func = fn;
            var cs = copyDict(currentScope.memory);

            genScope();
            int i = 0;
            if (@params != null)
            {
                foreach (var param in @params)
                {
                    currentScope.memory[func.arguments[i]] = param;
                    i++;
                }
            }

            dynamic ret = null;
            try
            {
                Visit(func.block);
            }
            catch (ReturnValue)
            {
                ret = returnValue.value;
            }

            currentScope.memory = cs;
            currentScope.childScope = null;
            return ret;
        }

        dynamic callClassFunction(dynamic clss, string name, dynamic @params)
        {
            DymeFunction func;
            if (clss is DymeClass)
                func = clss.children["this"].children[name];
            else
                func = clss.children[name];


            var cs = copyDict(currentScope.memory);
            currentScope.memory["this"] = clss;
            dynamic ret = callFunction(func, @params);
            currentScope.memory = cs;
            return ret;
        }

        public override dynamic VisitFuncCall(dymeParser.FuncCallContext context)
        {
            var name = context.IDENTIFIER().GetText();
            dynamic @params;
            if (context.@params() != null)
                @params = Visit(context.@params());
            else
                @params = new List<object>();
            if (globalFunctions.Contains(name))
            {
                MethodInfo methodInfo = this.GetType().GetMethod(name);
                var parAr = ((List<object>)@params).ToArray();
                return methodInfo.Invoke(this, parAr);
            } else
            {
                return callLocalFunction(name, @params);
            }
        }


        public override dynamic VisitParams(dymeParser.ParamsContext context)
        {
            var ret = new List<object>();
            foreach (var param in context.expr())
            {
                ret.Add(Visit(param));
            }
            return ret;
        }

        public override dynamic VisitAssignmentStmt(dymeParser.AssignmentStmtContext context)
        {
            var name = context.IDENTIFIER().GetText();
            var expr = Visit(context.expr());
            if (!currentScope.memory.ContainsKey(name))
                throw new Exception(name + " not present in memory or current scope!");
            currentScope.memory[name] = expr;
            return expr;
        }


        public override dynamic VisitMultiplicativeExpr(dymeParser.MultiplicativeExprContext context)
        {
            var left  = Visit(context.GetChild(0));
            var op    = context.operatorToken.Text;
            var right = Visit(context.GetChild(2));

            if (op == "*")
                return left * right;
            else if (op == "/")
                return left / right;
            else if (op == "%")
                return left % right;

            return base.VisitMultiplicativeExpr(context);
        }

        public override dynamic VisitExponentialExpr(dymeParser.ExponentialExprContext context)
        {
            var left  = Visit(context.GetChild(0));
            var right = Visit(context.GetChild(2));
            return System.Math.Pow(left, right);
        }

        public override dynamic VisitDeclarationStmt(dymeParser.DeclarationStmtContext context)
        {
            var name = context.IDENTIFIER().GetText();
            var expr = Visit(context.expr());
            if (expr is DymeFunction || expr is DymeType || expr is DymeObject)
                expr.name = context.IDENTIFIER().GetText();
            currentScope.memory[name] = expr;
            return expr;
        }

        public void genScope()
        {
            currentScope.childScope = new Scope();
            var oldmem = currentScope.memory;

            currentScope.childScope.memory = oldmem;
        }

        public Dictionary<string, dynamic> copyDict(Dictionary<string, dynamic> dict)
        {
            var cs = new Dictionary<string, dynamic>();
            foreach (var key in dict.Keys)
            {
                cs[key] = dict[key];
            }
            return cs;
        }

        public void dynUpdateScope(Dictionary<string, dynamic> cs)
        {
            var dynScope = copyDict(currentScope.memory);
            foreach (var key in cs.Keys)
            {
                if (currentScope.memory.ContainsKey(key) && currentScope.memory[key] != cs[key])
                {
                    dynScope[key] = currentScope.memory[key];
                }
            }
            currentScope.memory = dynScope;
            currentScope.childScope = null;
        } 

        private static ReturnValue returnValue = new ReturnValue();
        public override dynamic VisitScopedBlock(dymeParser.ScopedBlockContext context)
        {
            var cs = copyDict(currentScope.memory);

            genScope();
            currentScope = currentScope.childScope;
            foreach (var statement in context.stmt())
            {
                Visit(statement);
            }
            if (context.expr() != null)
            {
                returnValue.value = Visit(context.expr());
                dynUpdateScope(cs);
                throw returnValue;
            }

            dynUpdateScope(cs);
            return null;
        }

        public override dynamic VisitForEachStmt(dymeParser.ForEachStmtContext context)
        {
            var name = context.IDENTIFIER()[0].GetText();
            var expr = Visit(context.expr());
            dynamic index = null;
            if (context.IDENTIFIER().Length > 1)
            {
                name = context.IDENTIFIER()[1].GetText();
                index = context.IDENTIFIER()[0].GetText();
            }
            int i = 0;
            foreach (var item in expr)
            {
                if (index != null)
                    currentScope.memory[index] = i;
                currentScope.memory[name] = item;
                Visit(context.block());
                i++;
            }
            currentScope.memory.Remove(name);
            if (index != null)
                currentScope.memory.Remove(index);
            return null;
        }

        public void whileStmt(dymeParser.WhileStmtContext context)
        {
            var expr = Visit(context.expr());
            if (expr == true)
            {
                Visit(context.block());
                whileStmt(context);
            } else
            {
                return;
            }
        }

        public override dynamic VisitWhileStmt(dymeParser.WhileStmtContext context)
        {
            whileStmt(context);
            return null;
        }

        public override dynamic VisitIfStmt(dymeParser.IfStmtContext context)
        {
            var conditions = context.expr();
            bool evaluatedBlock = false;
            int state = 0;
            dynamic ret;
            foreach (var condition in conditions)
            {
                var evaluated = Visit(condition);
                if (evaluated)
                {
                    evaluatedBlock = true;
                    
                    return Visit(context.block()[state]);
                }
                state++;
            }

            if (!evaluatedBlock && context.block()[context.block().Length - 1] != null && context.block().Length > 1)
            {
                return Visit(context.block()[context.block().Length - 1]);
            }
            return null;
        }

        public override dynamic VisitConditionalExpr(dymeParser.ConditionalExprContext context)
        {
            var left  = Visit(context.expr()[0]);
            var op    = context.operatorToken.Text;
            var right = Visit(context.expr()[1]);

            if (op == "==")
                return left == right;
            if (op == "!=")
                return left != right;
            if (op == ">")
                return left > right;
            if (op == ">=")
                return left >= right;
            if (op == "<")
                return left < right;
            if (op == "<=")
                return left <= right;

            return null;
        }

        public override dynamic VisitCastExpr(dymeParser.CastExprContext context)
        {
            var left = Visit(context.expr());
            var id = context.IDENTIFIER().GetText();
            if (id == "int")
            {
                return Convert.ToInt32(left);
            }
            else if (id == "double")
            {
                return Double.Parse(left);
            }
            else if (id == "string")
            {
                return Convert.ToString(id);
            }
            return base.VisitCastExpr(context);
        }

        public override dynamic VisitTypeCheckExpr(dymeParser.TypeCheckExprContext context)
        {
            var left = Visit(context.expr());
            var id = context.IDENTIFIER().GetText();
            if (id == "int")
            {
                return left is int;
            }
            else if (id == "double")
            {
                return left is double;
            }
            else if (id == "string")
            {
                return left is string;
            }
            else if (id == "bool")
            {
                return left is bool;
            }
            else if (id == "enum")
            {
                return left is DymeEnum;
            }
            else if (id == "enumerable")
            {
                return left is DymeEnumerable;
            }
            else if (id == "function")
            {
                return left is DymeFunction;
            }
            else if (id == "object")
            {
                return left is DymeObject;
            }
            return false;
        }

        public override dynamic VisitUnaryExpr(dymeParser.UnaryExprContext context)
        {
            var op = context.operatorToken.Text;
            var right = Visit(context.expr());
            if (op == "+")
                return +right;
            if (op == "-")
                return -right;
            return null;
        }

        public override dynamic VisitTestExpr(dymeParser.TestExprContext context)
        {
            var left = Visit(context.expr()[0]);
            var op = context.operatorToken.Text;
            var right = Visit(context.expr()[1]);
            if (op == "and")
                return left && right;
            if (op == "or")
                return left || right;
            return base.VisitTestExpr(context);
        }

        public override dynamic VisitListExpr(dymeParser.ListExprContext context) {
            if (context.@params() == null)
                return new List<object>();
            return Visit(context.@params());
        }

        public override dynamic VisitIdentifierAtom(dymeParser.IdentifierAtomContext context)
        {
            var name = context.IDENTIFIER().GetText();
            if (!currentScope.memory.ContainsKey(name))
                throw new Exception(name + " not present in memory or in the current scope!");
            return currentScope.memory[name];
        }

        public override dynamic VisitExprStmt(dymeParser.ExprStmtContext context)
        {
            return Visit(context.expr());
        }

        public override dynamic VisitBooleanAtom(dymeParser.BooleanAtomContext context)
        {
            var bl = context.BOOLEAN().GetText();
            return Boolean.Parse(bl);
        }

        public static Random rand;

        public override dynamic VisitNewClassObjExpr(dymeParser.NewClassObjExprContext context)
        {
            var ret = new DymeObject();
            DymeClass clss = currentScope.memory[context.IDENTIFIER().GetText()];
            ret.name = context.IDENTIFIER().GetText();
            if (context.IDENTIFIER().GetText() == "Random")
                rand = new Random();
            if (clss.@static)
                throw new Exception("Class cannot be instantiated! - Class is static!");
           
            var globals = clss.children["this"].children;
            dynamic args = null;
            if (context.@params() != null)
                args = Visit(context.@params());
            ret.children["this"] = new DymeObject();
            ret.children["this"].children = globals;
            ret.children["this"].name = ret.name;
            int i = 0;
            if (args != null) 
            {
                foreach (var arg in args)
                {
                    ret.children["this"].children[clss.arguments[i]] = arg;
                    i++;
                }
            }
            var cs = copyDict(currentScope.memory);
            currentScope.memory["this"] = ret.children["this"];
            if (clss.children["this"].children.ContainsKey("ctor"))
            {
                dynamic ctorRet = null;
                try { Visit(clss.children["this"].children["ctor"].block); }
                catch (ReturnValue) { ctorRet = returnValue.value; }
                if (ctorRet != null)
                {
                    clss.children["this"].children.Remove("ctor");
                    currentScope.memory = cs;
                    return ctorRet;
                }
                clss.children["this"].children.Remove("ctor");
            }

            currentScope.memory = cs;
            return ret;
        }

        public override dynamic VisitNewExpr(dymeParser.NewExprContext context)
        {
            var ret = new DymeObject();
            ret.children = copyDict(currentScope.memory[context.IDENTIFIER().GetText()].children);
            if (context.assignArgs() != null)
            {
                var args = (Dictionary<string, dynamic>)Visit(context.assignArgs());
                foreach (var arg in args.Keys)
                {
                    ret.children[arg] = args[arg];
                }
            }
            return ret;
        }

        public override dynamic VisitAssignArgs(dymeParser.AssignArgsContext context)
        {
            var ret = new Dictionary<string, dynamic>();
            int i = 0;
            foreach (var id in context.IDENTIFIER())
            {
                ret[id.GetText()] = Visit(context.expr()[i]);
                i++;
            }
            return ret;
        }

        public override dynamic VisitTypeStmt(dymeParser.TypeStmtContext context)
        {
            var ret = new DymeType();
            ret.name = context.IDENTIFIER().GetText();
            foreach (var arg in Visit(context.args()))
            {
                ret.children[arg] = null;
            }
            currentScope.memory[ret.name] = ret;
            return ret;
        }



        public override dynamic VisitClassStmt(dymeParser.ClassStmtContext context)
        {
            var ret = new DymeClass();
            dynamic args = null;
            if (context.args() != null)
                args = Visit(context.args());
            if (args != null && args[0] == "static")
                ret.@static = true;
            var cs = copyDict(currentScope.memory);
            currentScope.memory["this"] = new DymeObject() { name = "this" };
            genScope();
            Visit(context.block());
            ret.children["this"] = currentScope.memory["this"];
            ret.arguments = args;
            ret.name = context.IDENTIFIER().GetText();
            currentScope.memory = cs;
            currentScope.childScope = null;
            currentScope.memory[context.IDENTIFIER().GetText()] = ret;
            return ret;
        }

        public override dynamic VisitEnums(dymeParser.EnumsContext context)
        {
            var ret = new List<string>();
            foreach (var param in context.IDENTIFIER())
            {
                ret.Add(param.GetText());
            }
            return ret;
        }

        public override dynamic VisitEnumStmt(dymeParser.EnumStmtContext context)
        {
            var ret = new DymeEnum();
            var enums = Visit(context.enums());
            ret.children = enums;
            ret.name = context.IDENTIFIER().GetText();
            currentScope.memory[ret.name] = ret;
            return ret;
        }

        public override dynamic VisitAccessAssignmentStmt(dymeParser.AccessAssignmentStmtContext context)
        {
            
            var obj = currentScope.memory[context.IDENTIFIER()[0].GetText()];
            if (obj.children.ContainsKey("this"))
                obj = obj.children["this"];
            var accessing = context.IDENTIFIER()[1].GetText();
            obj.children[accessing] = Visit(context.expr());
                
            return obj.children[accessing];
        }



        public override dynamic VisitAccessObjectExpr(dymeParser.AccessObjectExprContext context)
        {
            var obj = currentScope.memory[context.IDENTIFIER()[0].GetText()];
            var accessing = context.IDENTIFIER()[1].GetText();
            if (obj is DymeEnum)
            {
                if (obj.children.Contains(accessing))
                    return new DymeEnumerable() { name = accessing };
                else
                    throw new Exception(accessing + " is not a valid enumeration in enum " + obj.name + "!");
            }
            else if (obj.children.ContainsKey("this"))
                obj = obj.children["this"];
            return obj.children[accessing];
        }

        public dynamic listPush(List<object> list, List<object> prams)
        {
            list.Add(prams[0]);
            return list;
        }

        public dynamic listPop(List<object> list, List<object> prams)
        {
            list.RemoveAt(0);
            return list;
        }

        public dynamic listInsert(List<object> list, List<object> prams)
        {
            object index = prams[0];
            if (index is double)
                index = Convert.ToInt32(index);
            if (!(index is int))
                return null;
            list.Insert((int)index, prams[1]);
            return list;
        }
        
        public dynamic listRemove(List<object> list, List<object> prams)
        {
            object index = prams[0];
            if (index is double)
                index = Convert.ToInt32(index);
            if (!(index is int))
                return null;
            list.RemoveAt((int)index);
            return list;
        }

        public dynamic randomFill(DymeObject obj, List<object> prams)
        {
            var list = (List<object>)prams[0];
            var amount = Convert.ToInt32(prams[1]);
            var min = Convert.ToInt32(prams[2]);
            var max = Convert.ToInt32(prams[3]);
            for (int i = 0; i < amount; i++)
            {
                list.Add(rand.Next(min, max));
            }
            return list;
        }

        

        public override dynamic VisitAccessObjectFnExpr(dymeParser.AccessObjectFnExprContext context)
        {
            var obj = currentScope.memory[context.IDENTIFIER()[0].GetText()];
            if (obj is DymeObject && obj.children.ContainsKey("this"))
                obj = obj.children["this"];
            var accessing = context.IDENTIFIER()[1].GetText();
            dynamic prams = context.@params();
            if (prams == null)
                prams = null;
            else
                prams = Visit(prams);
            if (obj is List<object>)
            {
                if (accessing == "push")
                    return listPush(obj, prams);
                else if (accessing == "pop")
                    return listPop(obj, prams);
                else if (accessing == "insert")
                    return listInsert(obj, prams);
                else if (accessing == "remove")
                    return listRemove(obj, prams);
            }
            else if (obj is DymeObject && obj.name == "Random")
            {
                if (accessing == "Generate")
                    return rand.Next();
                else if (accessing == "RandomRange")
                    return rand.Next(Convert.ToInt32(prams[0]), Convert.ToInt32(prams[1]));
                else
                    return callClassFunction(obj, accessing, prams);

            }
            else if (obj is DymeClass && obj.name == "Console")
            {
                if (accessing == "InputLn")
                    return Console.ReadLine();
                else if (accessing == "InputKey")
                    return Console.ReadKey();
            }
            else
            {
                return callClassFunction(obj, accessing, prams);
            }
            return null;
        }

        public override dynamic VisitInListExpr(dymeParser.InListExprContext context)
        {
            var item = Visit(context.expr()[0]);
            var list = Visit(context.expr()[1]);
            foreach (var i in list)
            {
                try
                {
                    if (i == item)
                        return true;
                } catch (Exception)
                {
                    continue;
                }
            }
            return false;
        }
        public override dynamic VisitRangeExpr(dymeParser.RangeExprContext context)
        {
            var min = Convert.ToInt32(Visit(context.expr()[0]));
            var max = Convert.ToInt32(Visit(context.expr()[1]));
            if (min > max)
                throw new Exception("Range exception - minimum is greater than maximum!");
            var ret = new List<object>();
            for (int i = min; i < max; i++)
            {
                ret.Add(i);
            }
            return ret;
        }

        public override dynamic VisitMatchStmt(dymeParser.MatchStmtContext context)
        {
            var expr = Visit(context.expr());
            
            return base.VisitMatchStmt(context);
        }

        public override dynamic VisitMatchparams(dymeParser.MatchparamsContext context)
        {
            foreach (var param in context.matchparam())
            {
                if (Visit(param))
                {
                    break;
                }
            }
            return null;
        }

        public override dynamic VisitMatchparam(dymeParser.MatchparamContext context)
        {
            if (Visit(context.expr()) == true)
            {
                Visit(context.block());
                return true;
            } else
            {
                return false;
            }
        }


        public override dynamic VisitParenthesizedExpr(dymeParser.ParenthesizedExprContext context)
        {
            return Visit(context.expr());
        }

        public override dynamic VisitIntegerAtom(dymeParser.IntegerAtomContext context)
        {
            return Double.Parse(context.GetText());
        }

        public override dynamic VisitFloatAtom(dymeParser.FloatAtomContext context)
        {
            return Double.Parse(context.GetText());
        }

        public override dynamic VisitStringAtom(dymeParser.StringAtomContext context)
        {
            return context.GetText().Trim('"');
        }


    }
}
