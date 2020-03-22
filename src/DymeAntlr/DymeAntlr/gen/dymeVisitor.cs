//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from dyme.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="dymeParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IdymeVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>scopedBlock</c>
	/// labeled alternative in <see cref="dymeParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScopedBlock([NotNull] dymeParser.ScopedBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="dymeParser.loopblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopBlock([NotNull] dymeParser.LoopBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>declarationStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclarationStmt([NotNull] dymeParser.DeclarationStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>forEachStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForEachStmt([NotNull] dymeParser.ForEachStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whileStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStmt([NotNull] dymeParser.WhileStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStmt([NotNull] dymeParser.IfStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>importStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportStmt([NotNull] dymeParser.ImportStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>matchStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMatchStmt([NotNull] dymeParser.MatchStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>moduleStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleStmt([NotNull] dymeParser.ModuleStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>typeStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeStmt([NotNull] dymeParser.TypeStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>enumStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumStmt([NotNull] dymeParser.EnumStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>classStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassStmt([NotNull] dymeParser.ClassStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentStmt([NotNull] dymeParser.AssignmentStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>accessAssignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessAssignmentStmt([NotNull] dymeParser.AccessAssignmentStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprStmt([NotNull] dymeParser.ExprStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.matchparams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMatchparams([NotNull] dymeParser.MatchparamsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.matchparam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMatchparam([NotNull] dymeParser.MatchparamContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.enums"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnums([NotNull] dymeParser.EnumsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AccessObjectFnExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessObjectFnExpr([NotNull] dymeParser.AccessObjectFnExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Func</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] dymeParser.FuncContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewClassObjExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewClassObjExpr([NotNull] dymeParser.NewClassObjExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeCheckExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeCheckExpr([NotNull] dymeParser.TypeCheckExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConditionalExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalExpr([NotNull] dymeParser.ConditionalExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RangeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRangeExpr([NotNull] dymeParser.RangeExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpr([NotNull] dymeParser.UnaryExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IndexExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexExpr([NotNull] dymeParser.IndexExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncCall</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncCall([NotNull] dymeParser.FuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpr([NotNull] dymeParser.MultiplicativeExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AtomicExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomicExpr([NotNull] dymeParser.AtomicExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExponentialExpr([NotNull] dymeParser.ExponentialExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpr([NotNull] dymeParser.AdditiveExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpr([NotNull] dymeParser.NewExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CastExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCastExpr([NotNull] dymeParser.CastExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>InListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInListExpr([NotNull] dymeParser.InListExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpr([NotNull] dymeParser.ParenthesizedExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListExpr([NotNull] dymeParser.ListExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AccessObjectExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessObjectExpr([NotNull] dymeParser.AccessObjectExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TestExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTestExpr([NotNull] dymeParser.TestExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption([NotNull] dymeParser.OptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] dymeParser.ParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgs([NotNull] dymeParser.ArgsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="dymeParser.assignArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignArgs([NotNull] dymeParser.AssignArgsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IntegerAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegerAtom([NotNull] dymeParser.IntegerAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FloatAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatAtom([NotNull] dymeParser.FloatAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierAtom([NotNull] dymeParser.IdentifierAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BooleanAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanAtom([NotNull] dymeParser.BooleanAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringAtom([NotNull] dymeParser.StringAtomContext context);
}