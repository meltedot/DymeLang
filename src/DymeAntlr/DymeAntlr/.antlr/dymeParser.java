// Generated from c:\Users\Poliveira\source\repos\DymeAntlr\DymeAntlr\dyme.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class dymeParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, STRING=49, BOOLEAN=50, INTEGER=51, FLOAT=52, 
		IDENTIFIER=53, WHITESPACE=54, COMMENT=55, LINE_COMMENT=56;
	public static final int
		RULE_block = 0, RULE_loopblock = 1, RULE_stmt = 2, RULE_matchparams = 3, 
		RULE_matchparam = 4, RULE_enums = 5, RULE_expr = 6, RULE_option = 7, RULE_params = 8, 
		RULE_args = 9, RULE_assignArgs = 10, RULE_atom = 11;
	public static final String[] ruleNames = {
		"block", "loopblock", "stmt", "matchparams", "matchparam", "enums", "expr", 
		"option", "params", "args", "assignArgs", "atom"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'{'", "'return'", "';'", "'}'", "'break'", "'continue'", "'let'", 
		"'='", "'for'", "','", "'::'", "'while'", "'if'", "'else'", "'import'", 
		"'match'", "'mod'", "'type'", "'class'", "'('", "')'", "'.'", "'=>'", 
		"'|'", "'^'", "'->'", "'-?>'", "'*'", "'/'", "'%'", "'+'", "'-'", "'&'", 
		"'=='", "'!='", "'>'", "'>='", "'<'", "'<='", "'and'", "'or'", "'new'", 
		"'['", "']'", "'fn'", "'-->'", "'|>'", "':'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "STRING", "BOOLEAN", "INTEGER", "FLOAT", "IDENTIFIER", "WHITESPACE", 
		"COMMENT", "LINE_COMMENT"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "dyme.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public dymeParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class BlockContext extends ParserRuleContext {
		public BlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_block; }
	 
		public BlockContext() { }
		public void copyFrom(BlockContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class ScopedBlockContext extends BlockContext {
		public List<StmtContext> stmt() {
			return getRuleContexts(StmtContext.class);
		}
		public StmtContext stmt(int i) {
			return getRuleContext(StmtContext.class,i);
		}
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public ScopedBlockContext(BlockContext ctx) { copyFrom(ctx); }
	}

	public final BlockContext block() throws RecognitionException {
		BlockContext _localctx = new BlockContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_block);
		int _la;
		try {
			_localctx = new ScopedBlockContext(_localctx);
			enterOuterAlt(_localctx, 1);
			{
			setState(24);
			match(T__0);
			setState(28);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__6) | (1L << T__8) | (1L << T__11) | (1L << T__12) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << T__19) | (1L << T__30) | (1L << T__31) | (1L << T__41) | (1L << T__42) | (1L << T__44) | (1L << STRING) | (1L << BOOLEAN) | (1L << INTEGER) | (1L << FLOAT) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(25);
				stmt();
				}
				}
				setState(30);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(35);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__1) {
				{
				setState(31);
				match(T__1);
				setState(32);
				expr(0);
				setState(33);
				match(T__2);
				}
			}

			setState(37);
			match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LoopblockContext extends ParserRuleContext {
		public LoopblockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_loopblock; }
	 
		public LoopblockContext() { }
		public void copyFrom(LoopblockContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class LoopBlockContext extends LoopblockContext {
		public List<StmtContext> stmt() {
			return getRuleContexts(StmtContext.class);
		}
		public StmtContext stmt(int i) {
			return getRuleContext(StmtContext.class,i);
		}
		public LoopBlockContext(LoopblockContext ctx) { copyFrom(ctx); }
	}

	public final LoopblockContext loopblock() throws RecognitionException {
		LoopblockContext _localctx = new LoopblockContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_loopblock);
		int _la;
		try {
			_localctx = new LoopBlockContext(_localctx);
			enterOuterAlt(_localctx, 1);
			{
			setState(39);
			match(T__0);
			setState(43);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__6) | (1L << T__8) | (1L << T__11) | (1L << T__12) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << T__19) | (1L << T__30) | (1L << T__31) | (1L << T__41) | (1L << T__42) | (1L << T__44) | (1L << STRING) | (1L << BOOLEAN) | (1L << INTEGER) | (1L << FLOAT) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(40);
				stmt();
				}
				}
				setState(45);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(48);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__4) {
				{
				setState(46);
				match(T__4);
				setState(47);
				match(T__2);
				}
			}

			setState(52);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__5) {
				{
				setState(50);
				match(T__5);
				setState(51);
				match(T__2);
				}
			}

			setState(54);
			match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StmtContext extends ParserRuleContext {
		public StmtContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stmt; }
	 
		public StmtContext() { }
		public void copyFrom(StmtContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class ImportStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ImportStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class WhileStmtContext extends StmtContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public WhileStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class ClassStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public ArgsContext args() {
			return getRuleContext(ArgsContext.class,0);
		}
		public ClassStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class TypeStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ArgsContext args() {
			return getRuleContext(ArgsContext.class,0);
		}
		public TypeStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class DeclarationStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public DeclarationStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class ExprStmtContext extends StmtContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public ExprStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class IfStmtContext extends StmtContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public List<BlockContext> block() {
			return getRuleContexts(BlockContext.class);
		}
		public BlockContext block(int i) {
			return getRuleContext(BlockContext.class,i);
		}
		public IfStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class MatchStmtContext extends StmtContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public MatchparamsContext matchparams() {
			return getRuleContext(MatchparamsContext.class,0);
		}
		public MatchStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class AccessAssignmentStmtContext extends StmtContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public AccessAssignmentStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class ModuleStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ModuleStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class EnumStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public EnumsContext enums() {
			return getRuleContext(EnumsContext.class,0);
		}
		public EnumStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class ForEachStmtContext extends StmtContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public ForEachStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}
	public static class AssignmentStmtContext extends StmtContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public AssignmentStmtContext(StmtContext ctx) { copyFrom(ctx); }
	}

	public final StmtContext stmt() throws RecognitionException {
		StmtContext _localctx = new StmtContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_stmt);
		int _la;
		try {
			int _alt;
			setState(141);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				_localctx = new DeclarationStmtContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(56);
				match(T__6);
				setState(57);
				match(IDENTIFIER);
				setState(58);
				match(T__7);
				setState(59);
				expr(0);
				setState(60);
				match(T__2);
				}
				break;
			case 2:
				_localctx = new ForEachStmtContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(62);
				match(T__8);
				setState(63);
				match(IDENTIFIER);
				setState(66);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__9) {
					{
					setState(64);
					match(T__9);
					setState(65);
					match(IDENTIFIER);
					}
				}

				setState(68);
				match(T__10);
				setState(69);
				expr(0);
				setState(70);
				block();
				}
				break;
			case 3:
				_localctx = new WhileStmtContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(72);
				match(T__11);
				setState(73);
				expr(0);
				setState(74);
				block();
				}
				break;
			case 4:
				_localctx = new IfStmtContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(76);
				match(T__12);
				setState(77);
				expr(0);
				setState(78);
				block();
				setState(86);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,6,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(79);
						match(T__13);
						setState(80);
						match(T__12);
						setState(81);
						expr(0);
						setState(82);
						block();
						}
						} 
					}
					setState(88);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,6,_ctx);
				}
				setState(91);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__13) {
					{
					setState(89);
					match(T__13);
					setState(90);
					block();
					}
				}

				}
				break;
			case 5:
				_localctx = new ImportStmtContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(93);
				match(T__14);
				setState(94);
				match(IDENTIFIER);
				setState(95);
				match(T__2);
				}
				break;
			case 6:
				_localctx = new MatchStmtContext(_localctx);
				enterOuterAlt(_localctx, 6);
				{
				setState(96);
				match(T__15);
				setState(97);
				expr(0);
				setState(98);
				match(T__0);
				setState(99);
				matchparams();
				setState(100);
				match(T__3);
				}
				break;
			case 7:
				_localctx = new ModuleStmtContext(_localctx);
				enterOuterAlt(_localctx, 7);
				{
				setState(102);
				match(T__16);
				setState(103);
				match(IDENTIFIER);
				}
				break;
			case 8:
				_localctx = new TypeStmtContext(_localctx);
				enterOuterAlt(_localctx, 8);
				{
				setState(104);
				match(T__17);
				setState(105);
				match(IDENTIFIER);
				setState(106);
				match(T__7);
				setState(107);
				args();
				setState(108);
				match(T__2);
				}
				break;
			case 9:
				_localctx = new EnumStmtContext(_localctx);
				enterOuterAlt(_localctx, 9);
				{
				setState(110);
				match(T__17);
				setState(111);
				match(IDENTIFIER);
				setState(112);
				match(T__7);
				setState(113);
				enums();
				setState(114);
				match(T__2);
				}
				break;
			case 10:
				_localctx = new ClassStmtContext(_localctx);
				enterOuterAlt(_localctx, 10);
				{
				setState(116);
				match(T__18);
				setState(117);
				match(IDENTIFIER);
				setState(122);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__19) {
					{
					setState(118);
					match(T__19);
					setState(119);
					args();
					setState(120);
					match(T__20);
					}
				}

				setState(124);
				match(T__7);
				setState(125);
				block();
				}
				break;
			case 11:
				_localctx = new AssignmentStmtContext(_localctx);
				enterOuterAlt(_localctx, 11);
				{
				setState(126);
				match(IDENTIFIER);
				setState(127);
				match(T__7);
				setState(128);
				expr(0);
				setState(129);
				match(T__2);
				}
				break;
			case 12:
				_localctx = new AccessAssignmentStmtContext(_localctx);
				enterOuterAlt(_localctx, 12);
				{
				setState(131);
				match(IDENTIFIER);
				setState(132);
				match(T__21);
				setState(133);
				match(IDENTIFIER);
				setState(134);
				match(T__7);
				setState(135);
				expr(0);
				setState(136);
				match(T__2);
				}
				break;
			case 13:
				_localctx = new ExprStmtContext(_localctx);
				enterOuterAlt(_localctx, 13);
				{
				setState(138);
				expr(0);
				setState(139);
				match(T__2);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MatchparamsContext extends ParserRuleContext {
		public List<MatchparamContext> matchparam() {
			return getRuleContexts(MatchparamContext.class);
		}
		public MatchparamContext matchparam(int i) {
			return getRuleContext(MatchparamContext.class,i);
		}
		public MatchparamsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_matchparams; }
	}

	public final MatchparamsContext matchparams() throws RecognitionException {
		MatchparamsContext _localctx = new MatchparamsContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_matchparams);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(143);
			matchparam();
			{
			setState(144);
			match(T__9);
			setState(145);
			matchparam();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MatchparamContext extends ParserRuleContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public MatchparamContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_matchparam; }
	}

	public final MatchparamContext matchparam() throws RecognitionException {
		MatchparamContext _localctx = new MatchparamContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_matchparam);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(147);
			expr(0);
			setState(148);
			match(T__22);
			setState(149);
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumsContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public EnumsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enums; }
	}

	public final EnumsContext enums() throws RecognitionException {
		EnumsContext _localctx = new EnumsContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_enums);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(151);
			match(IDENTIFIER);
			setState(154); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(152);
				match(T__23);
				setState(153);
				match(IDENTIFIER);
				}
				}
				setState(156); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__23 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExprContext extends ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expr; }
	 
		public ExprContext() { }
		public void copyFrom(ExprContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class AccessObjectFnExprContext extends ExprContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public ParamsContext params() {
			return getRuleContext(ParamsContext.class,0);
		}
		public AccessObjectFnExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class FuncContext extends ExprContext {
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public ArgsContext args() {
			return getRuleContext(ArgsContext.class,0);
		}
		public FuncContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class NewClassObjExprContext extends ExprContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ParamsContext params() {
			return getRuleContext(ParamsContext.class,0);
		}
		public NewClassObjExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class TypeCheckExprContext extends ExprContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public TypeCheckExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class ConditionalExprContext extends ExprContext {
		public Token operatorToken;
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public ConditionalExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class RangeExprContext extends ExprContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public OptionContext option() {
			return getRuleContext(OptionContext.class,0);
		}
		public RangeExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class UnaryExprContext extends ExprContext {
		public Token operatorToken;
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public UnaryExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class IndexExprContext extends ExprContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public IndexExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class FuncCallContext extends ExprContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public ParamsContext params() {
			return getRuleContext(ParamsContext.class,0);
		}
		public FuncCallContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class MultiplicativeExprContext extends ExprContext {
		public Token operatorToken;
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public MultiplicativeExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class AtomicExprContext extends ExprContext {
		public AtomContext atom() {
			return getRuleContext(AtomContext.class,0);
		}
		public AtomicExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class ExponentialExprContext extends ExprContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public ExponentialExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class AdditiveExprContext extends ExprContext {
		public Token operatorToken;
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public AdditiveExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class NewExprContext extends ExprContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public AssignArgsContext assignArgs() {
			return getRuleContext(AssignArgsContext.class,0);
		}
		public NewExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class CastExprContext extends ExprContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public CastExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class InListExprContext extends ExprContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public InListExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class ParenthesizedExprContext extends ExprContext {
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public ParenthesizedExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class ListExprContext extends ExprContext {
		public ParamsContext params() {
			return getRuleContext(ParamsContext.class,0);
		}
		public ListExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class AccessObjectExprContext extends ExprContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public AccessObjectExprContext(ExprContext ctx) { copyFrom(ctx); }
	}
	public static class TestExprContext extends ExprContext {
		public Token operatorToken;
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public TestExprContext(ExprContext ctx) { copyFrom(ctx); }
	}

	public final ExprContext expr() throws RecognitionException {
		return expr(0);
	}

	private ExprContext expr(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExprContext _localctx = new ExprContext(_ctx, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 12;
		enterRecursionRule(_localctx, 12, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(225);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,20,_ctx) ) {
			case 1:
				{
				_localctx = new ParenthesizedExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(159);
				match(T__19);
				setState(160);
				expr(0);
				setState(161);
				match(T__20);
				}
				break;
			case 2:
				{
				_localctx = new UnaryExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(163);
				((UnaryExprContext)_localctx).operatorToken = _input.LT(1);
				_la = _input.LA(1);
				if ( !(_la==T__30 || _la==T__31) ) {
					((UnaryExprContext)_localctx).operatorToken = (Token)_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(164);
				expr(13);
				}
				break;
			case 3:
				{
				_localctx = new NewExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(165);
				match(T__41);
				setState(166);
				match(IDENTIFIER);
				setState(171);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
				case 1:
					{
					setState(167);
					match(T__0);
					setState(168);
					assignArgs();
					setState(169);
					match(T__3);
					}
					break;
				}
				}
				break;
			case 4:
				{
				_localctx = new NewClassObjExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(173);
				match(T__41);
				setState(174);
				match(IDENTIFIER);
				setState(175);
				match(T__19);
				setState(177);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__19) | (1L << T__30) | (1L << T__31) | (1L << T__41) | (1L << T__42) | (1L << T__44) | (1L << STRING) | (1L << BOOLEAN) | (1L << INTEGER) | (1L << FLOAT) | (1L << IDENTIFIER))) != 0)) {
					{
					setState(176);
					params();
					}
				}

				setState(179);
				match(T__20);
				}
				break;
			case 5:
				{
				_localctx = new AccessObjectExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(180);
				match(IDENTIFIER);
				setState(181);
				match(T__21);
				setState(182);
				match(IDENTIFIER);
				}
				break;
			case 6:
				{
				_localctx = new AccessObjectFnExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(183);
				match(IDENTIFIER);
				setState(184);
				match(T__21);
				setState(196);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
				case 1:
					{
					setState(185);
					match(IDENTIFIER);
					setState(187);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
					case 1:
						{
						setState(186);
						match(T__19);
						}
						break;
					}
					setState(189);
					params();
					setState(191);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
					case 1:
						{
						setState(190);
						match(T__20);
						}
						break;
					}
					}
					break;
				case 2:
					{
					setState(193);
					match(IDENTIFIER);
					setState(194);
					match(T__19);
					setState(195);
					match(T__20);
					}
					break;
				}
				}
				break;
			case 7:
				{
				_localctx = new IndexExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(198);
				match(IDENTIFIER);
				setState(199);
				match(T__42);
				setState(200);
				expr(0);
				setState(201);
				match(T__43);
				}
				break;
			case 8:
				{
				_localctx = new FuncCallContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(203);
				match(IDENTIFIER);
				setState(204);
				match(T__19);
				setState(205);
				match(T__20);
				}
				break;
			case 9:
				{
				_localctx = new FuncContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(206);
				match(T__44);
				setState(208);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==IDENTIFIER) {
					{
					setState(207);
					args();
					}
				}

				setState(210);
				block();
				}
				break;
			case 10:
				{
				_localctx = new ListExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(211);
				match(T__42);
				setState(213);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__19) | (1L << T__30) | (1L << T__31) | (1L << T__41) | (1L << T__42) | (1L << T__44) | (1L << STRING) | (1L << BOOLEAN) | (1L << INTEGER) | (1L << FLOAT) | (1L << IDENTIFIER))) != 0)) {
					{
					setState(212);
					params();
					}
				}

				setState(215);
				match(T__43);
				}
				break;
			case 11:
				{
				_localctx = new AtomicExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(216);
				atom();
				}
				break;
			case 12:
				{
				_localctx = new FuncCallContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(217);
				match(IDENTIFIER);
				setState(219);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,18,_ctx) ) {
				case 1:
					{
					setState(218);
					match(T__19);
					}
					break;
				}
				setState(221);
				params();
				setState(223);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
				case 1:
					{
					setState(222);
					match(T__20);
					}
					break;
				}
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(263);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,23,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(261);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
					case 1:
						{
						_localctx = new ExponentialExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(227);
						if (!(precpred(_ctx, 20))) throw new FailedPredicateException(this, "precpred(_ctx, 20)");
						setState(228);
						match(T__24);
						setState(229);
						expr(21);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(230);
						if (!(precpred(_ctx, 17))) throw new FailedPredicateException(this, "precpred(_ctx, 17)");
						setState(231);
						((MultiplicativeExprContext)_localctx).operatorToken = _input.LT(1);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__27) | (1L << T__28) | (1L << T__29))) != 0)) ) {
							((MultiplicativeExprContext)_localctx).operatorToken = (Token)_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(232);
						expr(18);
						}
						break;
					case 3:
						{
						_localctx = new AdditiveExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(233);
						if (!(precpred(_ctx, 16))) throw new FailedPredicateException(this, "precpred(_ctx, 16)");
						setState(234);
						((AdditiveExprContext)_localctx).operatorToken = _input.LT(1);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__30) | (1L << T__31) | (1L << T__32))) != 0)) ) {
							((AdditiveExprContext)_localctx).operatorToken = (Token)_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(235);
						expr(17);
						}
						break;
					case 4:
						{
						_localctx = new ConditionalExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(236);
						if (!(precpred(_ctx, 15))) throw new FailedPredicateException(this, "precpred(_ctx, 15)");
						setState(237);
						((ConditionalExprContext)_localctx).operatorToken = _input.LT(1);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__33) | (1L << T__34) | (1L << T__35) | (1L << T__36) | (1L << T__37) | (1L << T__38))) != 0)) ) {
							((ConditionalExprContext)_localctx).operatorToken = (Token)_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(238);
						expr(16);
						}
						break;
					case 5:
						{
						_localctx = new TestExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(239);
						if (!(precpred(_ctx, 14))) throw new FailedPredicateException(this, "precpred(_ctx, 14)");
						setState(240);
						((TestExprContext)_localctx).operatorToken = _input.LT(1);
						_la = _input.LA(1);
						if ( !(_la==T__39 || _la==T__40) ) {
							((TestExprContext)_localctx).operatorToken = (Token)_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(241);
						expr(15);
						}
						break;
					case 6:
						{
						_localctx = new InListExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(242);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						setState(243);
						match(T__10);
						setState(244);
						expr(7);
						}
						break;
					case 7:
						{
						_localctx = new CastExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(245);
						if (!(precpred(_ctx, 19))) throw new FailedPredicateException(this, "precpred(_ctx, 19)");
						setState(246);
						match(T__25);
						setState(247);
						match(T__19);
						setState(248);
						match(IDENTIFIER);
						setState(249);
						match(T__20);
						}
						break;
					case 8:
						{
						_localctx = new TypeCheckExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(250);
						if (!(precpred(_ctx, 18))) throw new FailedPredicateException(this, "precpred(_ctx, 18)");
						setState(251);
						match(T__26);
						setState(252);
						match(T__19);
						setState(253);
						match(IDENTIFIER);
						setState(254);
						match(T__20);
						}
						break;
					case 9:
						{
						_localctx = new RangeExprContext(new ExprContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expr);
						setState(255);
						if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
						setState(256);
						match(T__45);
						setState(257);
						expr(0);
						setState(259);
						_errHandler.sync(this);
						switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
						case 1:
							{
							setState(258);
							option();
							}
							break;
						}
						}
						break;
					}
					} 
				}
				setState(265);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,23,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class OptionContext extends ParserRuleContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public OptionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_option; }
	}

	public final OptionContext option() throws RecognitionException {
		OptionContext _localctx = new OptionContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_option);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(266);
			match(T__46);
			setState(267);
			expr(0);
			{
			setState(268);
			match(T__23);
			setState(269);
			expr(0);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ParamsContext extends ParserRuleContext {
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public ParamsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_params; }
	}

	public final ParamsContext params() throws RecognitionException {
		ParamsContext _localctx = new ParamsContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_params);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(271);
			expr(0);
			setState(276);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(272);
					match(T__9);
					setState(273);
					expr(0);
					}
					} 
				}
				setState(278);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArgsContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public ArgsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_args; }
	}

	public final ArgsContext args() throws RecognitionException {
		ArgsContext _localctx = new ArgsContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_args);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(279);
			match(IDENTIFIER);
			setState(284);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__9) {
				{
				{
				setState(280);
				match(T__9);
				setState(281);
				match(IDENTIFIER);
				}
				}
				setState(286);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AssignArgsContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(dymeParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(dymeParser.IDENTIFIER, i);
		}
		public List<ExprContext> expr() {
			return getRuleContexts(ExprContext.class);
		}
		public ExprContext expr(int i) {
			return getRuleContext(ExprContext.class,i);
		}
		public AssignArgsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignArgs; }
	}

	public final AssignArgsContext assignArgs() throws RecognitionException {
		AssignArgsContext _localctx = new AssignArgsContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_assignArgs);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(287);
			match(IDENTIFIER);
			setState(288);
			match(T__47);
			setState(289);
			expr(0);
			setState(296);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__9) {
				{
				{
				setState(290);
				match(T__9);
				setState(291);
				match(IDENTIFIER);
				setState(292);
				match(T__47);
				setState(293);
				expr(0);
				}
				}
				setState(298);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AtomContext extends ParserRuleContext {
		public AtomContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_atom; }
	 
		public AtomContext() { }
		public void copyFrom(AtomContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class IntegerAtomContext extends AtomContext {
		public TerminalNode INTEGER() { return getToken(dymeParser.INTEGER, 0); }
		public IntegerAtomContext(AtomContext ctx) { copyFrom(ctx); }
	}
	public static class StringAtomContext extends AtomContext {
		public TerminalNode STRING() { return getToken(dymeParser.STRING, 0); }
		public StringAtomContext(AtomContext ctx) { copyFrom(ctx); }
	}
	public static class BooleanAtomContext extends AtomContext {
		public TerminalNode BOOLEAN() { return getToken(dymeParser.BOOLEAN, 0); }
		public BooleanAtomContext(AtomContext ctx) { copyFrom(ctx); }
	}
	public static class FloatAtomContext extends AtomContext {
		public TerminalNode FLOAT() { return getToken(dymeParser.FLOAT, 0); }
		public FloatAtomContext(AtomContext ctx) { copyFrom(ctx); }
	}
	public static class IdentifierAtomContext extends AtomContext {
		public TerminalNode IDENTIFIER() { return getToken(dymeParser.IDENTIFIER, 0); }
		public IdentifierAtomContext(AtomContext ctx) { copyFrom(ctx); }
	}

	public final AtomContext atom() throws RecognitionException {
		AtomContext _localctx = new AtomContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_atom);
		try {
			setState(304);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INTEGER:
				_localctx = new IntegerAtomContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(299);
				match(INTEGER);
				}
				break;
			case FLOAT:
				_localctx = new FloatAtomContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(300);
				match(FLOAT);
				}
				break;
			case IDENTIFIER:
				_localctx = new IdentifierAtomContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(301);
				match(IDENTIFIER);
				}
				break;
			case BOOLEAN:
				_localctx = new BooleanAtomContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(302);
				match(BOOLEAN);
				}
				break;
			case STRING:
				_localctx = new StringAtomContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(303);
				match(STRING);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6:
			return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 20);
		case 1:
			return precpred(_ctx, 17);
		case 2:
			return precpred(_ctx, 16);
		case 3:
			return precpred(_ctx, 15);
		case 4:
			return precpred(_ctx, 14);
		case 5:
			return precpred(_ctx, 6);
		case 6:
			return precpred(_ctx, 19);
		case 7:
			return precpred(_ctx, 18);
		case 8:
			return precpred(_ctx, 3);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3:\u0135\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\3\2\3\2\7\2\35\n\2\f\2\16\2 \13\2\3\2\3\2\3\2\3\2"+
		"\5\2&\n\2\3\2\3\2\3\3\3\3\7\3,\n\3\f\3\16\3/\13\3\3\3\3\3\5\3\63\n\3\3"+
		"\3\3\3\5\3\67\n\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\5\4"+
		"E\n\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4"+
		"\7\4W\n\4\f\4\16\4Z\13\4\3\4\3\4\5\4^\n\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4"+
		"\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3"+
		"\4\3\4\3\4\3\4\3\4\5\4}\n\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3"+
		"\4\3\4\3\4\3\4\3\4\3\4\3\4\5\4\u0090\n\4\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3"+
		"\6\3\7\3\7\3\7\6\7\u009d\n\7\r\7\16\7\u009e\3\b\3\b\3\b\3\b\3\b\3\b\3"+
		"\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b\u00ae\n\b\3\b\3\b\3\b\3\b\5\b\u00b4\n\b"+
		"\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b\u00be\n\b\3\b\3\b\5\b\u00c2\n\b\3"+
		"\b\3\b\3\b\5\b\u00c7\n\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b\u00d3"+
		"\n\b\3\b\3\b\3\b\5\b\u00d8\n\b\3\b\3\b\3\b\3\b\5\b\u00de\n\b\3\b\3\b\5"+
		"\b\u00e2\n\b\5\b\u00e4\n\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b"+
		"\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3"+
		"\b\3\b\3\b\3\b\5\b\u0106\n\b\7\b\u0108\n\b\f\b\16\b\u010b\13\b\3\t\3\t"+
		"\3\t\3\t\3\t\3\n\3\n\3\n\7\n\u0115\n\n\f\n\16\n\u0118\13\n\3\13\3\13\3"+
		"\13\7\13\u011d\n\13\f\13\16\13\u0120\13\13\3\f\3\f\3\f\3\f\3\f\3\f\3\f"+
		"\7\f\u0129\n\f\f\f\16\f\u012c\13\f\3\r\3\r\3\r\3\r\3\r\5\r\u0133\n\r\3"+
		"\r\2\3\16\16\2\4\6\b\n\f\16\20\22\24\26\30\2\7\3\2!\"\3\2\36 \3\2!#\3"+
		"\2$)\3\2*+\2\u0163\2\32\3\2\2\2\4)\3\2\2\2\6\u008f\3\2\2\2\b\u0091\3\2"+
		"\2\2\n\u0095\3\2\2\2\f\u0099\3\2\2\2\16\u00e3\3\2\2\2\20\u010c\3\2\2\2"+
		"\22\u0111\3\2\2\2\24\u0119\3\2\2\2\26\u0121\3\2\2\2\30\u0132\3\2\2\2\32"+
		"\36\7\3\2\2\33\35\5\6\4\2\34\33\3\2\2\2\35 \3\2\2\2\36\34\3\2\2\2\36\37"+
		"\3\2\2\2\37%\3\2\2\2 \36\3\2\2\2!\"\7\4\2\2\"#\5\16\b\2#$\7\5\2\2$&\3"+
		"\2\2\2%!\3\2\2\2%&\3\2\2\2&\'\3\2\2\2\'(\7\6\2\2(\3\3\2\2\2)-\7\3\2\2"+
		"*,\5\6\4\2+*\3\2\2\2,/\3\2\2\2-+\3\2\2\2-.\3\2\2\2.\62\3\2\2\2/-\3\2\2"+
		"\2\60\61\7\7\2\2\61\63\7\5\2\2\62\60\3\2\2\2\62\63\3\2\2\2\63\66\3\2\2"+
		"\2\64\65\7\b\2\2\65\67\7\5\2\2\66\64\3\2\2\2\66\67\3\2\2\2\678\3\2\2\2"+
		"89\7\6\2\29\5\3\2\2\2:;\7\t\2\2;<\7\67\2\2<=\7\n\2\2=>\5\16\b\2>?\7\5"+
		"\2\2?\u0090\3\2\2\2@A\7\13\2\2AD\7\67\2\2BC\7\f\2\2CE\7\67\2\2DB\3\2\2"+
		"\2DE\3\2\2\2EF\3\2\2\2FG\7\r\2\2GH\5\16\b\2HI\5\2\2\2I\u0090\3\2\2\2J"+
		"K\7\16\2\2KL\5\16\b\2LM\5\2\2\2M\u0090\3\2\2\2NO\7\17\2\2OP\5\16\b\2P"+
		"X\5\2\2\2QR\7\20\2\2RS\7\17\2\2ST\5\16\b\2TU\5\2\2\2UW\3\2\2\2VQ\3\2\2"+
		"\2WZ\3\2\2\2XV\3\2\2\2XY\3\2\2\2Y]\3\2\2\2ZX\3\2\2\2[\\\7\20\2\2\\^\5"+
		"\2\2\2][\3\2\2\2]^\3\2\2\2^\u0090\3\2\2\2_`\7\21\2\2`a\7\67\2\2a\u0090"+
		"\7\5\2\2bc\7\22\2\2cd\5\16\b\2de\7\3\2\2ef\5\b\5\2fg\7\6\2\2g\u0090\3"+
		"\2\2\2hi\7\23\2\2i\u0090\7\67\2\2jk\7\24\2\2kl\7\67\2\2lm\7\n\2\2mn\5"+
		"\24\13\2no\7\5\2\2o\u0090\3\2\2\2pq\7\24\2\2qr\7\67\2\2rs\7\n\2\2st\5"+
		"\f\7\2tu\7\5\2\2u\u0090\3\2\2\2vw\7\25\2\2w|\7\67\2\2xy\7\26\2\2yz\5\24"+
		"\13\2z{\7\27\2\2{}\3\2\2\2|x\3\2\2\2|}\3\2\2\2}~\3\2\2\2~\177\7\n\2\2"+
		"\177\u0090\5\2\2\2\u0080\u0081\7\67\2\2\u0081\u0082\7\n\2\2\u0082\u0083"+
		"\5\16\b\2\u0083\u0084\7\5\2\2\u0084\u0090\3\2\2\2\u0085\u0086\7\67\2\2"+
		"\u0086\u0087\7\30\2\2\u0087\u0088\7\67\2\2\u0088\u0089\7\n\2\2\u0089\u008a"+
		"\5\16\b\2\u008a\u008b\7\5\2\2\u008b\u0090\3\2\2\2\u008c\u008d\5\16\b\2"+
		"\u008d\u008e\7\5\2\2\u008e\u0090\3\2\2\2\u008f:\3\2\2\2\u008f@\3\2\2\2"+
		"\u008fJ\3\2\2\2\u008fN\3\2\2\2\u008f_\3\2\2\2\u008fb\3\2\2\2\u008fh\3"+
		"\2\2\2\u008fj\3\2\2\2\u008fp\3\2\2\2\u008fv\3\2\2\2\u008f\u0080\3\2\2"+
		"\2\u008f\u0085\3\2\2\2\u008f\u008c\3\2\2\2\u0090\7\3\2\2\2\u0091\u0092"+
		"\5\n\6\2\u0092\u0093\7\f\2\2\u0093\u0094\5\n\6\2\u0094\t\3\2\2\2\u0095"+
		"\u0096\5\16\b\2\u0096\u0097\7\31\2\2\u0097\u0098\5\2\2\2\u0098\13\3\2"+
		"\2\2\u0099\u009c\7\67\2\2\u009a\u009b\7\32\2\2\u009b\u009d\7\67\2\2\u009c"+
		"\u009a\3\2\2\2\u009d\u009e\3\2\2\2\u009e\u009c\3\2\2\2\u009e\u009f\3\2"+
		"\2\2\u009f\r\3\2\2\2\u00a0\u00a1\b\b\1\2\u00a1\u00a2\7\26\2\2\u00a2\u00a3"+
		"\5\16\b\2\u00a3\u00a4\7\27\2\2\u00a4\u00e4\3\2\2\2\u00a5\u00a6\t\2\2\2"+
		"\u00a6\u00e4\5\16\b\17\u00a7\u00a8\7,\2\2\u00a8\u00ad\7\67\2\2\u00a9\u00aa"+
		"\7\3\2\2\u00aa\u00ab\5\26\f\2\u00ab\u00ac\7\6\2\2\u00ac\u00ae\3\2\2\2"+
		"\u00ad\u00a9\3\2\2\2\u00ad\u00ae\3\2\2\2\u00ae\u00e4\3\2\2\2\u00af\u00b0"+
		"\7,\2\2\u00b0\u00b1\7\67\2\2\u00b1\u00b3\7\26\2\2\u00b2\u00b4\5\22\n\2"+
		"\u00b3\u00b2\3\2\2\2\u00b3\u00b4\3\2\2\2\u00b4\u00b5\3\2\2\2\u00b5\u00e4"+
		"\7\27\2\2\u00b6\u00b7\7\67\2\2\u00b7\u00b8\7\30\2\2\u00b8\u00e4\7\67\2"+
		"\2\u00b9\u00ba\7\67\2\2\u00ba\u00c6\7\30\2\2\u00bb\u00bd\7\67\2\2\u00bc"+
		"\u00be\7\26\2\2\u00bd\u00bc\3\2\2\2\u00bd\u00be\3\2\2\2\u00be\u00bf\3"+
		"\2\2\2\u00bf\u00c1\5\22\n\2\u00c0\u00c2\7\27\2\2\u00c1\u00c0\3\2\2\2\u00c1"+
		"\u00c2\3\2\2\2\u00c2\u00c7\3\2\2\2\u00c3\u00c4\7\67\2\2\u00c4\u00c5\7"+
		"\26\2\2\u00c5\u00c7\7\27\2\2\u00c6\u00bb\3\2\2\2\u00c6\u00c3\3\2\2\2\u00c7"+
		"\u00e4\3\2\2\2\u00c8\u00c9\7\67\2\2\u00c9\u00ca\7-\2\2\u00ca\u00cb\5\16"+
		"\b\2\u00cb\u00cc\7.\2\2\u00cc\u00e4\3\2\2\2\u00cd\u00ce\7\67\2\2\u00ce"+
		"\u00cf\7\26\2\2\u00cf\u00e4\7\27\2\2\u00d0\u00d2\7/\2\2\u00d1\u00d3\5"+
		"\24\13\2\u00d2\u00d1\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3\u00d4\3\2\2\2\u00d4"+
		"\u00e4\5\2\2\2\u00d5\u00d7\7-\2\2\u00d6\u00d8\5\22\n\2\u00d7\u00d6\3\2"+
		"\2\2\u00d7\u00d8\3\2\2\2\u00d8\u00d9\3\2\2\2\u00d9\u00e4\7.\2\2\u00da"+
		"\u00e4\5\30\r\2\u00db\u00dd\7\67\2\2\u00dc\u00de\7\26\2\2\u00dd\u00dc"+
		"\3\2\2\2\u00dd\u00de\3\2\2\2\u00de\u00df\3\2\2\2\u00df\u00e1\5\22\n\2"+
		"\u00e0\u00e2\7\27\2\2\u00e1\u00e0\3\2\2\2\u00e1\u00e2\3\2\2\2\u00e2\u00e4"+
		"\3\2\2\2\u00e3\u00a0\3\2\2\2\u00e3\u00a5\3\2\2\2\u00e3\u00a7\3\2\2\2\u00e3"+
		"\u00af\3\2\2\2\u00e3\u00b6\3\2\2\2\u00e3\u00b9\3\2\2\2\u00e3\u00c8\3\2"+
		"\2\2\u00e3\u00cd\3\2\2\2\u00e3\u00d0\3\2\2\2\u00e3\u00d5\3\2\2\2\u00e3"+
		"\u00da\3\2\2\2\u00e3\u00db\3\2\2\2\u00e4\u0109\3\2\2\2\u00e5\u00e6\f\26"+
		"\2\2\u00e6\u00e7\7\33\2\2\u00e7\u0108\5\16\b\27\u00e8\u00e9\f\23\2\2\u00e9"+
		"\u00ea\t\3\2\2\u00ea\u0108\5\16\b\24\u00eb\u00ec\f\22\2\2\u00ec\u00ed"+
		"\t\4\2\2\u00ed\u0108\5\16\b\23\u00ee\u00ef\f\21\2\2\u00ef\u00f0\t\5\2"+
		"\2\u00f0\u0108\5\16\b\22\u00f1\u00f2\f\20\2\2\u00f2\u00f3\t\6\2\2\u00f3"+
		"\u0108\5\16\b\21\u00f4\u00f5\f\b\2\2\u00f5\u00f6\7\r\2\2\u00f6\u0108\5"+
		"\16\b\t\u00f7\u00f8\f\25\2\2\u00f8\u00f9\7\34\2\2\u00f9\u00fa\7\26\2\2"+
		"\u00fa\u00fb\7\67\2\2\u00fb\u0108\7\27\2\2\u00fc\u00fd\f\24\2\2\u00fd"+
		"\u00fe\7\35\2\2\u00fe\u00ff\7\26\2\2\u00ff\u0100\7\67\2\2\u0100\u0108"+
		"\7\27\2\2\u0101\u0102\f\5\2\2\u0102\u0103\7\60\2\2\u0103\u0105\5\16\b"+
		"\2\u0104\u0106\5\20\t\2\u0105\u0104\3\2\2\2\u0105\u0106\3\2\2\2\u0106"+
		"\u0108\3\2\2\2\u0107\u00e5\3\2\2\2\u0107\u00e8\3\2\2\2\u0107\u00eb\3\2"+
		"\2\2\u0107\u00ee\3\2\2\2\u0107\u00f1\3\2\2\2\u0107\u00f4\3\2\2\2\u0107"+
		"\u00f7\3\2\2\2\u0107\u00fc\3\2\2\2\u0107\u0101\3\2\2\2\u0108\u010b\3\2"+
		"\2\2\u0109\u0107\3\2\2\2\u0109\u010a\3\2\2\2\u010a\17\3\2\2\2\u010b\u0109"+
		"\3\2\2\2\u010c\u010d\7\61\2\2\u010d\u010e\5\16\b\2\u010e\u010f\7\32\2"+
		"\2\u010f\u0110\5\16\b\2\u0110\21\3\2\2\2\u0111\u0116\5\16\b\2\u0112\u0113"+
		"\7\f\2\2\u0113\u0115\5\16\b\2\u0114\u0112\3\2\2\2\u0115\u0118\3\2\2\2"+
		"\u0116\u0114\3\2\2\2\u0116\u0117\3\2\2\2\u0117\23\3\2\2\2\u0118\u0116"+
		"\3\2\2\2\u0119\u011e\7\67\2\2\u011a\u011b\7\f\2\2\u011b\u011d\7\67\2\2"+
		"\u011c\u011a\3\2\2\2\u011d\u0120\3\2\2\2\u011e\u011c\3\2\2\2\u011e\u011f"+
		"\3\2\2\2\u011f\25\3\2\2\2\u0120\u011e\3\2\2\2\u0121\u0122\7\67\2\2\u0122"+
		"\u0123\7\62\2\2\u0123\u012a\5\16\b\2\u0124\u0125\7\f\2\2\u0125\u0126\7"+
		"\67\2\2\u0126\u0127\7\62\2\2\u0127\u0129\5\16\b\2\u0128\u0124\3\2\2\2"+
		"\u0129\u012c\3\2\2\2\u012a\u0128\3\2\2\2\u012a\u012b\3\2\2\2\u012b\27"+
		"\3\2\2\2\u012c\u012a\3\2\2\2\u012d\u0133\7\65\2\2\u012e\u0133\7\66\2\2"+
		"\u012f\u0133\7\67\2\2\u0130\u0133\7\64\2\2\u0131\u0133\7\63\2\2\u0132"+
		"\u012d\3\2\2\2\u0132\u012e\3\2\2\2\u0132\u012f\3\2\2\2\u0132\u0130\3\2"+
		"\2\2\u0132\u0131\3\2\2\2\u0133\31\3\2\2\2\36\36%-\62\66DX]|\u008f\u009e"+
		"\u00ad\u00b3\u00bd\u00c1\u00c6\u00d2\u00d7\u00dd\u00e1\u00e3\u0105\u0107"+
		"\u0109\u0116\u011e\u012a\u0132";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}