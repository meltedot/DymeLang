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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class dymeLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, STRING=49, BOOLEAN=50, INTEGER=51, FLOAT=52, 
		IDENTIFIER=53, WHITESPACE=54, COMMENT=55, LINE_COMMENT=56;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "STRING", 
		"BOOLEAN", "INTEGER", "FLOAT", "IDENTIFIER", "WHITESPACE", "COMMENT", 
		"LINE_COMMENT"
	};


	public dymeLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public dymeLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'return'", "';'", "'}'", "'break'", "'continue'", "'let'", 
		"'='", "'for'", "','", "'::'", "'while'", "'if'", "'else'", "'import'", 
		"'match'", "'mod'", "'type'", "'class'", "'('", "')'", "'.'", "'=>'", 
		"'|'", "'^'", "'->'", "'-?>'", "'*'", "'/'", "'%'", "'+'", "'-'", "'&'", 
		"'=='", "'!='", "'>'", "'>='", "'<'", "'<='", "'and'", "'or'", "'new'", 
		"'['", "']'", "'fn'", "'-->'", "'|>'", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "STRING", "BOOLEAN", "INTEGER", "FLOAT", "IDENTIFIER", "WHITESPACE", 
		"COMMENT", "LINE_COMMENT"
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

	public override string GrammarFileName { get { return "dyme.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static dymeLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ':', '\x159', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x4', '\x35', '\t', '\x35', '\x4', '\x36', '\t', '\x36', '\x4', '\x37', 
		'\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x4', '\x39', '\t', '\x39', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', 
		'\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '#', 
		'\x3', '$', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', 
		'\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', 
		'\x3', '(', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', '*', 
		'\x3', '*', '\x3', '*', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', 
		'\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', '.', '\x3', '.', 
		'\x3', '.', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', '\x30', 
		'\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', '\x32', 
		'\x3', '\x32', '\a', '\x32', '\x116', '\n', '\x32', '\f', '\x32', '\xE', 
		'\x32', '\x119', '\v', '\x32', '\x3', '\x32', '\x3', '\x32', '\x3', '\x33', 
		'\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', 
		'\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x5', '\x33', '\x126', '\n', 
		'\x33', '\x3', '\x34', '\x6', '\x34', '\x129', '\n', '\x34', '\r', '\x34', 
		'\xE', '\x34', '\x12A', '\x3', '\x35', '\x6', '\x35', '\x12E', '\n', '\x35', 
		'\r', '\x35', '\xE', '\x35', '\x12F', '\x3', '\x35', '\x3', '\x35', '\x6', 
		'\x35', '\x134', '\n', '\x35', '\r', '\x35', '\xE', '\x35', '\x135', '\x3', 
		'\x36', '\x6', '\x36', '\x139', '\n', '\x36', '\r', '\x36', '\xE', '\x36', 
		'\x13A', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', 
		'\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\a', '\x38', '\x145', 
		'\n', '\x38', '\f', '\x38', '\xE', '\x38', '\x148', '\v', '\x38', '\x3', 
		'\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\x3', 
		'\x39', '\x3', '\x39', '\x3', '\x39', '\x3', '\x39', '\a', '\x39', '\x153', 
		'\n', '\x39', '\f', '\x39', '\xE', '\x39', '\x156', '\v', '\x39', '\x3', 
		'\x39', '\x3', '\x39', '\x3', '\x146', '\x2', ':', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', 'S', '+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', ']', '\x30', '_', 
		'\x31', '\x61', '\x32', '\x63', '\x33', '\x65', '\x34', 'g', '\x35', 'i', 
		'\x36', 'k', '\x37', 'm', '\x38', 'o', '\x39', 'q', ':', '\x3', '\x2', 
		'\b', '\x3', '\x2', '$', '$', '\x3', '\x2', '\x32', ';', '\x3', '\x2', 
		'\x30', '\x30', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x2', '\x160', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x2', '\x65', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'g', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'k', '\x3', '\x2', '\x2', '\x2', '\x2', 'm', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'o', '\x3', '\x2', '\x2', '\x2', '\x2', 'q', 
		'\x3', '\x2', '\x2', '\x2', '\x3', 's', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'u', '\x3', '\x2', '\x2', '\x2', '\a', '|', '\x3', '\x2', '\x2', '\x2', 
		'\t', '~', '\x3', '\x2', '\x2', '\x2', '\v', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x86', '\x3', '\x2', '\x2', '\x2', '\xF', '\x8F', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x93', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x95', '\x3', '\x2', '\x2', '\x2', '\x15', '\x99', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x19', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\xA4', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\xA7', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xAC', '\x3', '\x2', '\x2', 
		'\x2', '!', '\xB3', '\x3', '\x2', '\x2', '\x2', '#', '\xB9', '\x3', '\x2', 
		'\x2', '\x2', '%', '\xBD', '\x3', '\x2', '\x2', '\x2', '\'', '\xC2', '\x3', 
		'\x2', '\x2', '\x2', ')', '\xC8', '\x3', '\x2', '\x2', '\x2', '+', '\xCA', 
		'\x3', '\x2', '\x2', '\x2', '-', '\xCC', '\x3', '\x2', '\x2', '\x2', '/', 
		'\xCE', '\x3', '\x2', '\x2', '\x2', '\x31', '\xD1', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\xD3', '\x3', '\x2', '\x2', '\x2', '\x35', '\xD5', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xD8', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xDC', '\x3', '\x2', '\x2', '\x2', ';', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xE0', '\x3', '\x2', '\x2', '\x2', '?', '\xE2', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xE4', '\x3', '\x2', '\x2', '\x2', '\x43', '\xE6', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xE8', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xEB', '\x3', '\x2', '\x2', '\x2', 'I', '\xEE', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xF0', '\x3', '\x2', '\x2', '\x2', 'M', '\xF3', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xF5', '\x3', '\x2', '\x2', '\x2', 'Q', '\xF8', '\x3', 
		'\x2', '\x2', '\x2', 'S', '\xFC', '\x3', '\x2', '\x2', '\x2', 'U', '\xFF', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\x103', '\x3', '\x2', '\x2', '\x2', 
		'Y', '\x105', '\x3', '\x2', '\x2', '\x2', '[', '\x107', '\x3', '\x2', 
		'\x2', '\x2', ']', '\x10A', '\x3', '\x2', '\x2', '\x2', '_', '\x10E', 
		'\x3', '\x2', '\x2', '\x2', '\x61', '\x111', '\x3', '\x2', '\x2', '\x2', 
		'\x63', '\x113', '\x3', '\x2', '\x2', '\x2', '\x65', '\x125', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x128', '\x3', '\x2', '\x2', '\x2', 'i', '\x12D', 
		'\x3', '\x2', '\x2', '\x2', 'k', '\x138', '\x3', '\x2', '\x2', '\x2', 
		'm', '\x13C', '\x3', '\x2', '\x2', '\x2', 'o', '\x140', '\x3', '\x2', 
		'\x2', '\x2', 'q', '\x14E', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', 
		'}', '\x2', '\x2', 't', '\x4', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', 
		't', '\x2', '\x2', 'v', 'w', '\a', 'g', '\x2', '\x2', 'w', 'x', '\a', 
		'v', '\x2', '\x2', 'x', 'y', '\a', 'w', '\x2', '\x2', 'y', 'z', '\a', 
		't', '\x2', '\x2', 'z', '{', '\a', 'p', '\x2', '\x2', '{', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '|', '}', '\a', '=', '\x2', '\x2', '}', '\b', '\x3', 
		'\x2', '\x2', '\x2', '~', '\x7F', '\a', '\x7F', '\x2', '\x2', '\x7F', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', '\x64', '\x2', 
		'\x2', '\x81', '\x82', '\a', 't', '\x2', '\x2', '\x82', '\x83', '\a', 
		'g', '\x2', '\x2', '\x83', '\x84', '\a', '\x63', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'm', '\x2', '\x2', '\x85', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x86', '\x87', '\a', '\x65', '\x2', '\x2', '\x87', '\x88', '\a', 'q', 
		'\x2', '\x2', '\x88', '\x89', '\a', 'p', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 'v', '\x2', '\x2', '\x8A', '\x8B', '\a', 'k', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', 'p', '\x2', '\x2', '\x8C', '\x8D', '\a', 'w', '\x2', '\x2', 
		'\x8D', '\x8E', '\a', 'g', '\x2', '\x2', '\x8E', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x90', '\a', 'n', '\x2', '\x2', '\x90', '\x91', 
		'\a', 'g', '\x2', '\x2', '\x91', '\x92', '\a', 'v', '\x2', '\x2', '\x92', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\a', '?', '\x2', 
		'\x2', '\x94', '\x12', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\a', 
		'h', '\x2', '\x2', '\x96', '\x97', '\a', 'q', '\x2', '\x2', '\x97', '\x98', 
		'\a', 't', '\x2', '\x2', '\x98', '\x14', '\x3', '\x2', '\x2', '\x2', '\x99', 
		'\x9A', '\a', '.', '\x2', '\x2', '\x9A', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', '<', '\x2', '\x2', '\x9C', '\x9D', '\a', 
		'<', '\x2', '\x2', '\x9D', '\x18', '\x3', '\x2', '\x2', '\x2', '\x9E', 
		'\x9F', '\a', 'y', '\x2', '\x2', '\x9F', '\xA0', '\a', 'j', '\x2', '\x2', 
		'\xA0', '\xA1', '\a', 'k', '\x2', '\x2', '\xA1', '\xA2', '\a', 'n', '\x2', 
		'\x2', '\xA2', '\xA3', '\a', 'g', '\x2', '\x2', '\xA3', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA5', '\a', 'k', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', 'h', '\x2', '\x2', '\xA6', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\xA7', '\xA8', '\a', 'g', '\x2', '\x2', '\xA8', '\xA9', '\a', 
		'n', '\x2', '\x2', '\xA9', '\xAA', '\a', 'u', '\x2', '\x2', '\xAA', '\xAB', 
		'\a', 'g', '\x2', '\x2', '\xAB', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'k', '\x2', '\x2', '\xAD', '\xAE', '\a', 'o', '\x2', '\x2', 
		'\xAE', '\xAF', '\a', 'r', '\x2', '\x2', '\xAF', '\xB0', '\a', 'q', '\x2', 
		'\x2', '\xB0', '\xB1', '\a', 't', '\x2', '\x2', '\xB1', '\xB2', '\a', 
		'v', '\x2', '\x2', '\xB2', ' ', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', 
		'\a', 'o', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x63', '\x2', '\x2', '\xB5', 
		'\xB6', '\a', 'v', '\x2', '\x2', '\xB6', '\xB7', '\a', '\x65', '\x2', 
		'\x2', '\xB7', '\xB8', '\a', 'j', '\x2', '\x2', '\xB8', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\xB9', '\xBA', '\a', 'o', '\x2', '\x2', '\xBA', '\xBB', 
		'\a', 'q', '\x2', '\x2', '\xBB', '\xBC', '\a', '\x66', '\x2', '\x2', '\xBC', 
		'$', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBE', '\a', 'v', '\x2', '\x2', 
		'\xBE', '\xBF', '\a', '{', '\x2', '\x2', '\xBF', '\xC0', '\a', 'r', '\x2', 
		'\x2', '\xC0', '\xC1', '\a', 'g', '\x2', '\x2', '\xC1', '&', '\x3', '\x2', 
		'\x2', '\x2', '\xC2', '\xC3', '\a', '\x65', '\x2', '\x2', '\xC3', '\xC4', 
		'\a', 'n', '\x2', '\x2', '\xC4', '\xC5', '\a', '\x63', '\x2', '\x2', '\xC5', 
		'\xC6', '\a', 'u', '\x2', '\x2', '\xC6', '\xC7', '\a', 'u', '\x2', '\x2', 
		'\xC7', '(', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', '\a', '*', '\x2', 
		'\x2', '\xC9', '*', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCB', '\a', 
		'+', '\x2', '\x2', '\xCB', ',', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', 
		'\a', '\x30', '\x2', '\x2', '\xCD', '.', '\x3', '\x2', '\x2', '\x2', '\xCE', 
		'\xCF', '\a', '?', '\x2', '\x2', '\xCF', '\xD0', '\a', '@', '\x2', '\x2', 
		'\xD0', '\x30', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', '~', 
		'\x2', '\x2', '\xD2', '\x32', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', 
		'\a', '`', '\x2', '\x2', '\xD4', '\x34', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\a', '/', '\x2', '\x2', '\xD6', '\xD7', '\a', '@', '\x2', '\x2', 
		'\xD7', '\x36', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\a', '/', 
		'\x2', '\x2', '\xD9', '\xDA', '\a', '\x41', '\x2', '\x2', '\xDA', '\xDB', 
		'\a', '@', '\x2', '\x2', '\xDB', '\x38', '\x3', '\x2', '\x2', '\x2', '\xDC', 
		'\xDD', '\a', ',', '\x2', '\x2', '\xDD', ':', '\x3', '\x2', '\x2', '\x2', 
		'\xDE', '\xDF', '\a', '\x31', '\x2', '\x2', '\xDF', '<', '\x3', '\x2', 
		'\x2', '\x2', '\xE0', '\xE1', '\a', '\'', '\x2', '\x2', '\xE1', '>', '\x3', 
		'\x2', '\x2', '\x2', '\xE2', '\xE3', '\a', '-', '\x2', '\x2', '\xE3', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE5', '\a', '/', '\x2', '\x2', 
		'\xE5', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE6', '\xE7', '\a', '(', 
		'\x2', '\x2', '\xE7', '\x44', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', 
		'\a', '?', '\x2', '\x2', '\xE9', '\xEA', '\a', '?', '\x2', '\x2', '\xEA', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\a', '#', '\x2', 
		'\x2', '\xEC', '\xED', '\a', '?', '\x2', '\x2', '\xED', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xEE', '\xEF', '\a', '@', '\x2', '\x2', '\xEF', 'J', '\x3', 
		'\x2', '\x2', '\x2', '\xF0', '\xF1', '\a', '@', '\x2', '\x2', '\xF1', 
		'\xF2', '\a', '?', '\x2', '\x2', '\xF2', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\xF3', '\xF4', '\a', '>', '\x2', '\x2', '\xF4', 'N', '\x3', '\x2', '\x2', 
		'\x2', '\xF5', '\xF6', '\a', '>', '\x2', '\x2', '\xF6', '\xF7', '\a', 
		'?', '\x2', '\x2', '\xF7', 'P', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF9', 
		'\a', '\x63', '\x2', '\x2', '\xF9', '\xFA', '\a', 'p', '\x2', '\x2', '\xFA', 
		'\xFB', '\a', '\x66', '\x2', '\x2', '\xFB', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\xFC', '\xFD', '\a', 'q', '\x2', '\x2', '\xFD', '\xFE', '\a', 
		't', '\x2', '\x2', '\xFE', 'T', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', 
		'\a', 'p', '\x2', '\x2', '\x100', '\x101', '\a', 'g', '\x2', '\x2', '\x101', 
		'\x102', '\a', 'y', '\x2', '\x2', '\x102', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x103', '\x104', '\a', ']', '\x2', '\x2', '\x104', 'X', '\x3', '\x2', 
		'\x2', '\x2', '\x105', '\x106', '\a', '_', '\x2', '\x2', '\x106', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '\x107', '\x108', '\a', 'h', '\x2', '\x2', 
		'\x108', '\x109', '\a', 'p', '\x2', '\x2', '\x109', '\\', '\x3', '\x2', 
		'\x2', '\x2', '\x10A', '\x10B', '\a', '/', '\x2', '\x2', '\x10B', '\x10C', 
		'\a', '/', '\x2', '\x2', '\x10C', '\x10D', '\a', '@', '\x2', '\x2', '\x10D', 
		'^', '\x3', '\x2', '\x2', '\x2', '\x10E', '\x10F', '\a', '~', '\x2', '\x2', 
		'\x10F', '\x110', '\a', '@', '\x2', '\x2', '\x110', '`', '\x3', '\x2', 
		'\x2', '\x2', '\x111', '\x112', '\a', '<', '\x2', '\x2', '\x112', '\x62', 
		'\x3', '\x2', '\x2', '\x2', '\x113', '\x117', '\a', '$', '\x2', '\x2', 
		'\x114', '\x116', '\n', '\x2', '\x2', '\x2', '\x115', '\x114', '\x3', 
		'\x2', '\x2', '\x2', '\x116', '\x119', '\x3', '\x2', '\x2', '\x2', '\x117', 
		'\x115', '\x3', '\x2', '\x2', '\x2', '\x117', '\x118', '\x3', '\x2', '\x2', 
		'\x2', '\x118', '\x11A', '\x3', '\x2', '\x2', '\x2', '\x119', '\x117', 
		'\x3', '\x2', '\x2', '\x2', '\x11A', '\x11B', '\a', '$', '\x2', '\x2', 
		'\x11B', '\x64', '\x3', '\x2', '\x2', '\x2', '\x11C', '\x11D', '\a', 'v', 
		'\x2', '\x2', '\x11D', '\x11E', '\a', 't', '\x2', '\x2', '\x11E', '\x11F', 
		'\a', 'w', '\x2', '\x2', '\x11F', '\x126', '\a', 'g', '\x2', '\x2', '\x120', 
		'\x121', '\a', 'h', '\x2', '\x2', '\x121', '\x122', '\a', '\x63', '\x2', 
		'\x2', '\x122', '\x123', '\a', 'n', '\x2', '\x2', '\x123', '\x124', '\a', 
		'u', '\x2', '\x2', '\x124', '\x126', '\a', 'g', '\x2', '\x2', '\x125', 
		'\x11C', '\x3', '\x2', '\x2', '\x2', '\x125', '\x120', '\x3', '\x2', '\x2', 
		'\x2', '\x126', '\x66', '\x3', '\x2', '\x2', '\x2', '\x127', '\x129', 
		'\t', '\x3', '\x2', '\x2', '\x128', '\x127', '\x3', '\x2', '\x2', '\x2', 
		'\x129', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12A', '\x128', '\x3', 
		'\x2', '\x2', '\x2', '\x12A', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x12B', 
		'h', '\x3', '\x2', '\x2', '\x2', '\x12C', '\x12E', '\t', '\x3', '\x2', 
		'\x2', '\x12D', '\x12C', '\x3', '\x2', '\x2', '\x2', '\x12E', '\x12F', 
		'\x3', '\x2', '\x2', '\x2', '\x12F', '\x12D', '\x3', '\x2', '\x2', '\x2', 
		'\x12F', '\x130', '\x3', '\x2', '\x2', '\x2', '\x130', '\x131', '\x3', 
		'\x2', '\x2', '\x2', '\x131', '\x133', '\t', '\x4', '\x2', '\x2', '\x132', 
		'\x134', '\t', '\x3', '\x2', '\x2', '\x133', '\x132', '\x3', '\x2', '\x2', 
		'\x2', '\x134', '\x135', '\x3', '\x2', '\x2', '\x2', '\x135', '\x133', 
		'\x3', '\x2', '\x2', '\x2', '\x135', '\x136', '\x3', '\x2', '\x2', '\x2', 
		'\x136', 'j', '\x3', '\x2', '\x2', '\x2', '\x137', '\x139', '\t', '\x5', 
		'\x2', '\x2', '\x138', '\x137', '\x3', '\x2', '\x2', '\x2', '\x139', '\x13A', 
		'\x3', '\x2', '\x2', '\x2', '\x13A', '\x138', '\x3', '\x2', '\x2', '\x2', 
		'\x13A', '\x13B', '\x3', '\x2', '\x2', '\x2', '\x13B', 'l', '\x3', '\x2', 
		'\x2', '\x2', '\x13C', '\x13D', '\t', '\x6', '\x2', '\x2', '\x13D', '\x13E', 
		'\x3', '\x2', '\x2', '\x2', '\x13E', '\x13F', '\b', '\x37', '\x2', '\x2', 
		'\x13F', 'n', '\x3', '\x2', '\x2', '\x2', '\x140', '\x141', '\a', '\x31', 
		'\x2', '\x2', '\x141', '\x142', '\a', ',', '\x2', '\x2', '\x142', '\x146', 
		'\x3', '\x2', '\x2', '\x2', '\x143', '\x145', '\v', '\x2', '\x2', '\x2', 
		'\x144', '\x143', '\x3', '\x2', '\x2', '\x2', '\x145', '\x148', '\x3', 
		'\x2', '\x2', '\x2', '\x146', '\x147', '\x3', '\x2', '\x2', '\x2', '\x146', 
		'\x144', '\x3', '\x2', '\x2', '\x2', '\x147', '\x149', '\x3', '\x2', '\x2', 
		'\x2', '\x148', '\x146', '\x3', '\x2', '\x2', '\x2', '\x149', '\x14A', 
		'\a', ',', '\x2', '\x2', '\x14A', '\x14B', '\a', '\x31', '\x2', '\x2', 
		'\x14B', '\x14C', '\x3', '\x2', '\x2', '\x2', '\x14C', '\x14D', '\b', 
		'\x38', '\x2', '\x2', '\x14D', 'p', '\x3', '\x2', '\x2', '\x2', '\x14E', 
		'\x14F', '\a', '\x31', '\x2', '\x2', '\x14F', '\x150', '\a', '\x31', '\x2', 
		'\x2', '\x150', '\x154', '\x3', '\x2', '\x2', '\x2', '\x151', '\x153', 
		'\n', '\a', '\x2', '\x2', '\x152', '\x151', '\x3', '\x2', '\x2', '\x2', 
		'\x153', '\x156', '\x3', '\x2', '\x2', '\x2', '\x154', '\x152', '\x3', 
		'\x2', '\x2', '\x2', '\x154', '\x155', '\x3', '\x2', '\x2', '\x2', '\x155', 
		'\x157', '\x3', '\x2', '\x2', '\x2', '\x156', '\x154', '\x3', '\x2', '\x2', 
		'\x2', '\x157', '\x158', '\b', '\x39', '\x2', '\x2', '\x158', 'r', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\x2', '\x117', '\x125', '\x12A', '\x12F', 
		'\x135', '\x13A', '\x146', '\x154', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
