//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Grammar/Assignment4/Calculator.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar.Assignment4 {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICalculatorListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CalculatorBaseListener : ICalculatorListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile([NotNull] CalculatorParser.FileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile([NotNull] CalculatorParser.FileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementBlock([NotNull] CalculatorParser.StatementBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementBlock([NotNull] CalculatorParser.StatementBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] CalculatorParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] CalculatorParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] CalculatorParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] CalculatorParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseBlock([NotNull] CalculatorParser.ElseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseBlock([NotNull] CalculatorParser.ElseBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] CalculatorParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] CalculatorParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] CalculatorParser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] CalculatorParser.StatementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] CalculatorParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] CalculatorParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableAssignment([NotNull] CalculatorParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableAssignment([NotNull] CalculatorParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegation([NotNull] CalculatorParser.NegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegation([NotNull] CalculatorParser.NegationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Comparison</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison([NotNull] CalculatorParser.ComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Comparison</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison([NotNull] CalculatorParser.ComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalAnd</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAnd([NotNull] CalculatorParser.LogicalAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalAnd</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAnd([NotNull] CalculatorParser.LogicalAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedBooleanExpression</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedBooleanExpression([NotNull] CalculatorParser.ParenthesizedBooleanExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedBooleanExpression</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedBooleanExpression([NotNull] CalculatorParser.ParenthesizedBooleanExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalOr</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOr([NotNull] CalculatorParser.LogicalOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalOr</c>
	/// labeled alternative in <see cref="CalculatorParser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOr([NotNull] CalculatorParser.LogicalOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpression([NotNull] CalculatorParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpression([NotNull] CalculatorParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Factorial</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorial([NotNull] CalculatorParser.FactorialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Factorial</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorial([NotNull] CalculatorParser.FactorialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryOperation([NotNull] CalculatorParser.BinaryOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryOperation([NotNull] CalculatorParser.BinaryOperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] CalculatorParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] CalculatorParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NestedVar</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNestedVar([NotNull] CalculatorParser.NestedVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NestedVar</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNestedVar([NotNull] CalculatorParser.NestedVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] CalculatorParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] CalculatorParser.KeywordContext context) { }

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
} // namespace Grammar.Assignment4