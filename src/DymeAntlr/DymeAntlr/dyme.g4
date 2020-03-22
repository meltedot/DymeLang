grammar dyme;

block:
    '{' (stmt)* ('return' expr ';')? '}'  #scopedBlock
    ;

loopblock:
    '{' (stmt)* ('break' ';')? ('continue' ';')? '}' #loopBlock
    ;


stmt:
    'let' IDENTIFIER '=' expr ';'           #declarationStmt
    | 'for' IDENTIFIER (',' IDENTIFIER)? '::' expr block  #forEachStmt
    | 'while' expr block            #whileStmt
    | 'if' expr block ('else' 'if' expr block)* ('else' block)? #ifStmt
    | 'import' IDENTIFIER ';'              #importStmt
    | 'match' expr '{' matchparams '}'  #matchStmt
    | 'mod' IDENTIFIER                  #moduleStmt
    | 'type' IDENTIFIER '=' args ';' #typeStmt
    | 'type' IDENTIFIER '=' enums ';' #enumStmt
    | 'class' IDENTIFIER ('(' args ')')? '=' block #classStmt
    | IDENTIFIER '=' expr ';'               #assignmentStmt
    | IDENTIFIER '.' IDENTIFIER '=' expr ';' #accessAssignmentStmt
    | expr                ';'              #exprStmt
    ;

matchparams:
    matchparam (',' matchparam)
    ;

matchparam:
    expr '=>' block
    ;

enums:
    IDENTIFIER ('|' IDENTIFIER)+
    ;

expr:
    '(' expr ')'                          #ParenthesizedExpr
	| expr '^' expr                       #ExponentialExpr
    | expr '->' '(' IDENTIFIER ')'          #CastExpr
    | expr '-?>' '(' IDENTIFIER ')'          #TypeCheckExpr
    | expr operatorToken=('*' | '/' | '%') expr #MultiplicativeExpr
	| expr operatorToken=('+' | '-' | '&') expr #AdditiveExpr
    | expr operatorToken=('==' | '!=' | '>' | '>=' | '<' | '<=') expr #ConditionalExpr
    | expr operatorToken=('and' | 'or') expr #TestExpr
    | operatorToken=('+'|'-') expr          #UnaryExpr
    | 'new' IDENTIFIER ('{' assignArgs '}')?         #NewExpr
    | 'new' IDENTIFIER '(' params? ')'                #NewClassObjExpr
    | IDENTIFIER '.' IDENTIFIER             #AccessObjectExpr
    | IDENTIFIER '.' (IDENTIFIER '('? params ')'? | IDENTIFIER '(' ')') #AccessObjectFnExpr
    | IDENTIFIER '[' expr ']'               #IndexExpr
    | IDENTIFIER '(' ')'                    #FuncCall
    | expr '::' expr        #InListExpr
    | 'fn' args? block            #Func
    | '[' params? ']'                      #ListExpr
    | expr '-->' expr option?                     #RangeExpr
	| atom                                #AtomicExpr
    | IDENTIFIER '('? params ')'?           #FuncCall
	;


option:
    '|>' expr ('|' expr)
    ;

params:
    expr (',' expr)*
    ;

args:
    IDENTIFIER (',' IDENTIFIER)*
    ;

assignArgs:
    IDENTIFIER ':' expr (',' IDENTIFIER ':' expr)*
    ;

atom:
    INTEGER                          #IntegerAtom
    | FLOAT                          #FloatAtom
    | IDENTIFIER                     #IdentifierAtom
    | BOOLEAN                        #BooleanAtom
    | STRING                         #StringAtom
    ;


STRING: '"' (~["])* '"';
BOOLEAN: ('true'|'false');
INTEGER: [0-9]+;
FLOAT: [0-9]+[.][0-9]+;
IDENTIFIER: [a-zA-Z0-9_]+;
WHITESPACE: [ \t\r\n] -> skip;

COMMENT
    : '/*' .*? '*/' -> skip
;

LINE_COMMENT
    : '//' ~[\r\n]* -> skip
;