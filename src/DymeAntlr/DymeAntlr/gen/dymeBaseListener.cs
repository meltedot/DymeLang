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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IdymeListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class dymeBaseListener : IdymeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>scopedBlock</c>
	/// labeled alternative in <see cref="dymeParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScopedBlock([NotNull] dymeParser.ScopedBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>scopedBlock</c>
	/// labeled alternative in <see cref="dymeParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScopedBlock([NotNull] dymeParser.ScopedBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="dymeParser.loopblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoopBlock([NotNull] dymeParser.LoopBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>loopBlock</c>
	/// labeled alternative in <see cref="dymeParser.loopblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoopBlock([NotNull] dymeParser.LoopBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>declarationStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationStmt([NotNull] dymeParser.DeclarationStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>declarationStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationStmt([NotNull] dymeParser.DeclarationStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>forEachStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForEachStmt([NotNull] dymeParser.ForEachStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>forEachStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForEachStmt([NotNull] dymeParser.ForEachStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>whileStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStmt([NotNull] dymeParser.WhileStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>whileStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStmt([NotNull] dymeParser.WhileStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStmt([NotNull] dymeParser.IfStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStmt([NotNull] dymeParser.IfStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>importStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportStmt([NotNull] dymeParser.ImportStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>importStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportStmt([NotNull] dymeParser.ImportStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matchStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchStmt([NotNull] dymeParser.MatchStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matchStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchStmt([NotNull] dymeParser.MatchStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>moduleStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModuleStmt([NotNull] dymeParser.ModuleStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>moduleStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModuleStmt([NotNull] dymeParser.ModuleStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>typeStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeStmt([NotNull] dymeParser.TypeStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>typeStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeStmt([NotNull] dymeParser.TypeStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>enumStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumStmt([NotNull] dymeParser.EnumStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>enumStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumStmt([NotNull] dymeParser.EnumStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>classStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassStmt([NotNull] dymeParser.ClassStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>classStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassStmt([NotNull] dymeParser.ClassStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentStmt([NotNull] dymeParser.AssignmentStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentStmt([NotNull] dymeParser.AssignmentStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>accessAssignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessAssignmentStmt([NotNull] dymeParser.AccessAssignmentStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>accessAssignmentStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessAssignmentStmt([NotNull] dymeParser.AccessAssignmentStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprStmt([NotNull] dymeParser.ExprStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprStmt</c>
	/// labeled alternative in <see cref="dymeParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprStmt([NotNull] dymeParser.ExprStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.matchparams"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchparams([NotNull] dymeParser.MatchparamsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.matchparams"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchparams([NotNull] dymeParser.MatchparamsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.matchparam"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchparam([NotNull] dymeParser.MatchparamContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.matchparam"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchparam([NotNull] dymeParser.MatchparamContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.enums"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnums([NotNull] dymeParser.EnumsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.enums"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnums([NotNull] dymeParser.EnumsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AccessObjectFnExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessObjectFnExpr([NotNull] dymeParser.AccessObjectFnExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AccessObjectFnExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessObjectFnExpr([NotNull] dymeParser.AccessObjectFnExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Func</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc([NotNull] dymeParser.FuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Func</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc([NotNull] dymeParser.FuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NewClassObjExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewClassObjExpr([NotNull] dymeParser.NewClassObjExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NewClassObjExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewClassObjExpr([NotNull] dymeParser.NewClassObjExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeCheckExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeCheckExpr([NotNull] dymeParser.TypeCheckExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeCheckExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeCheckExpr([NotNull] dymeParser.TypeCheckExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ConditionalExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalExpr([NotNull] dymeParser.ConditionalExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ConditionalExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalExpr([NotNull] dymeParser.ConditionalExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RangeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeExpr([NotNull] dymeParser.RangeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RangeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeExpr([NotNull] dymeParser.RangeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpr([NotNull] dymeParser.UnaryExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpr([NotNull] dymeParser.UnaryExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IndexExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexExpr([NotNull] dymeParser.IndexExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IndexExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexExpr([NotNull] dymeParser.IndexExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FuncCall</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncCall([NotNull] dymeParser.FuncCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FuncCall</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncCall([NotNull] dymeParser.FuncCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpr([NotNull] dymeParser.MultiplicativeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpr([NotNull] dymeParser.MultiplicativeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AtomicExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtomicExpr([NotNull] dymeParser.AtomicExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AtomicExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtomicExpr([NotNull] dymeParser.AtomicExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExponentialExpr([NotNull] dymeParser.ExponentialExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExponentialExpr([NotNull] dymeParser.ExponentialExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpr([NotNull] dymeParser.AdditiveExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpr([NotNull] dymeParser.AdditiveExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NewExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewExpr([NotNull] dymeParser.NewExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NewExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewExpr([NotNull] dymeParser.NewExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CastExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpr([NotNull] dymeParser.CastExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CastExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpr([NotNull] dymeParser.CastExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>InListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInListExpr([NotNull] dymeParser.InListExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>InListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInListExpr([NotNull] dymeParser.InListExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpr([NotNull] dymeParser.ParenthesizedExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpr([NotNull] dymeParser.ParenthesizedExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterListExpr([NotNull] dymeParser.ListExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ListExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitListExpr([NotNull] dymeParser.ListExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AccessObjectExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessObjectExpr([NotNull] dymeParser.AccessObjectExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AccessObjectExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessObjectExpr([NotNull] dymeParser.AccessObjectExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TestExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTestExpr([NotNull] dymeParser.TestExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TestExpr</c>
	/// labeled alternative in <see cref="dymeParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTestExpr([NotNull] dymeParser.TestExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOption([NotNull] dymeParser.OptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOption([NotNull] dymeParser.OptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParams([NotNull] dymeParser.ParamsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParams([NotNull] dymeParser.ParamsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgs([NotNull] dymeParser.ArgsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgs([NotNull] dymeParser.ArgsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="dymeParser.assignArgs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignArgs([NotNull] dymeParser.AssignArgsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="dymeParser.assignArgs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignArgs([NotNull] dymeParser.AssignArgsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IntegerAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntegerAtom([NotNull] dymeParser.IntegerAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IntegerAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntegerAtom([NotNull] dymeParser.IntegerAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FloatAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloatAtom([NotNull] dymeParser.FloatAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FloatAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloatAtom([NotNull] dymeParser.FloatAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierAtom([NotNull] dymeParser.IdentifierAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierAtom([NotNull] dymeParser.IdentifierAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BooleanAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanAtom([NotNull] dymeParser.BooleanAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BooleanAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanAtom([NotNull] dymeParser.BooleanAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>StringAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringAtom([NotNull] dymeParser.StringAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StringAtom</c>
	/// labeled alternative in <see cref="dymeParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringAtom([NotNull] dymeParser.StringAtomContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}