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
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class MathLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NUMBER=1, OPENPAREN=2, CLOSEPAREN=3, OPERATOR=4, WHITESPACE=5;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"NUMBER", "OPENPAREN", "CLOSEPAREN", "OPERATOR", "WHITESPACE"
	};


	public MathLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MathLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "OPENPAREN", "CLOSEPAREN", "OPERATOR", "WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Math.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MathLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,5,29,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,1,0,1,0,5,0,14,8,
		0,10,0,12,0,17,9,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,3,4,26,8,4,1,4,1,4,0,0,
		5,1,1,3,2,5,3,7,4,9,5,1,0,4,1,0,49,57,1,0,48,57,3,0,42,43,45,45,47,47,
		3,0,9,10,13,13,32,32,29,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,
		0,0,9,1,0,0,0,1,11,1,0,0,0,3,18,1,0,0,0,5,20,1,0,0,0,7,22,1,0,0,0,9,25,
		1,0,0,0,11,15,7,0,0,0,12,14,7,1,0,0,13,12,1,0,0,0,14,17,1,0,0,0,15,13,
		1,0,0,0,15,16,1,0,0,0,16,2,1,0,0,0,17,15,1,0,0,0,18,19,5,40,0,0,19,4,1,
		0,0,0,20,21,5,41,0,0,21,6,1,0,0,0,22,23,7,2,0,0,23,8,1,0,0,0,24,26,7,3,
		0,0,25,24,1,0,0,0,26,27,1,0,0,0,27,28,6,4,0,0,28,10,1,0,0,0,3,0,15,25,
		1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar.Assignment2
