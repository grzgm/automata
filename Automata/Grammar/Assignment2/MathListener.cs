//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Grammar/Assignment2/Math.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar.Assignment2 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] MathParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] MathParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesized</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesized([NotNull] MathParser.ParenthesizedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesized</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesized([NotNull] MathParser.ParenthesizedContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplication([NotNull] MathParser.MultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplication([NotNull] MathParser.MultiplicationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddition([NotNull] MathParser.AdditionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddition([NotNull] MathParser.AdditionContext context);
}
} // namespace Grammar.Assignment2
