//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Grammar/Assignment5/Assignment5.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar.Assignment5 {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAssignment5Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class Assignment5BaseListener : IAssignment5Listener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] Assignment5Parser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] Assignment5Parser.StatementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] Assignment5Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] Assignment5Parser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] Assignment5Parser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] Assignment5Parser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.functionParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionParameters([NotNull] Assignment5Parser.FunctionParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.functionParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionParameters([NotNull] Assignment5Parser.FunctionParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.requiredParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRequiredParameterList([NotNull] Assignment5Parser.RequiredParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.requiredParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRequiredParameterList([NotNull] Assignment5Parser.RequiredParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.optionalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionalParameterList([NotNull] Assignment5Parser.OptionalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.optionalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionalParameterList([NotNull] Assignment5Parser.OptionalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.parameterWithDefaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterWithDefaultValue([NotNull] Assignment5Parser.ParameterWithDefaultValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.parameterWithDefaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterWithDefaultValue([NotNull] Assignment5Parser.ParameterWithDefaultValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] Assignment5Parser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] Assignment5Parser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.functionArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionArguments([NotNull] Assignment5Parser.FunctionArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.functionArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionArguments([NotNull] Assignment5Parser.FunctionArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] Assignment5Parser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] Assignment5Parser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseBlock([NotNull] Assignment5Parser.ElseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseBlock([NotNull] Assignment5Parser.ElseBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] Assignment5Parser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] Assignment5Parser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementBlock([NotNull] Assignment5Parser.StatementBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementBlock([NotNull] Assignment5Parser.StatementBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] Assignment5Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] Assignment5Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Assignment5Parser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaration([NotNull] Assignment5Parser.VariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Assignment5Parser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaration([NotNull] Assignment5Parser.VariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegation([NotNull] Assignment5Parser.NegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegation([NotNull] Assignment5Parser.NegationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Comparison</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison([NotNull] Assignment5Parser.ComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Comparison</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison([NotNull] Assignment5Parser.ComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalAnd</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAnd([NotNull] Assignment5Parser.LogicalAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalAnd</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAnd([NotNull] Assignment5Parser.LogicalAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedBooleanExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedBooleanExpression([NotNull] Assignment5Parser.ParenthesizedBooleanExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedBooleanExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedBooleanExpression([NotNull] Assignment5Parser.ParenthesizedBooleanExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalOr</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOr([NotNull] Assignment5Parser.LogicalOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalOr</c>
	/// labeled alternative in <see cref="Assignment5Parser.booleanExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOr([NotNull] Assignment5Parser.LogicalOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpression([NotNull] Assignment5Parser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpression([NotNull] Assignment5Parser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Factorial</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorial([NotNull] Assignment5Parser.FactorialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Factorial</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorial([NotNull] Assignment5Parser.FactorialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryOperation([NotNull] Assignment5Parser.BinaryOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryOperation([NotNull] Assignment5Parser.BinaryOperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] Assignment5Parser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] Assignment5Parser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NestedVar</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNestedVar([NotNull] Assignment5Parser.NestedVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NestedVar</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNestedVar([NotNull] Assignment5Parser.NestedVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionCallExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallExpression([NotNull] Assignment5Parser.FunctionCallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionCallExpression</c>
	/// labeled alternative in <see cref="Assignment5Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallExpression([NotNull] Assignment5Parser.FunctionCallExpressionContext context) { }

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
} // namespace Grammar.Assignment5
