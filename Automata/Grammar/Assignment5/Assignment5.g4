grammar Assignment5;

statements    
    : statement*
    ;
    
statement
    : functionDeclaration
    | functionCall
//    | returnStatement
    | ifStatement
    | whileStatement                             
    | variableDeclaration
    ;
    
functionDeclaration
    : 'function' functionName (functionParams ','?)* statementBlock
    ;  
    
functionParams
    : IDENT '=' expression              # DefaultParam
    | IDENT                             # Param
    ;
      
functionCall
    : functionName '(' (expression ','?)* ')'
    ;
    
ifStatement
    : 'if' booleanExpression statementBlock elseBlock?
    ;
    
elseBlock
    : 'else' statementBlock
    ;
    
whileStatement
    : 'while' booleanExpression statementBlock
    ;

statementBlock
    : '{' statement* (returnStatement | statement)* '}'
//    | '{' statement* (returnStatement | statement?)* '}'
    ;
    
returnStatement
    : 'return' expression?
    ;

variableDeclaration
    : IDENT '=' expression              # ExpressionAssignment
    | IDENT '=' functionCall            # FunctionAssignment
    | IDENT                             # Initialisation
    ;
    
booleanExpression
    : expression COMP_OPERATOR expression           # Comparison
    | '!' booleanExpression                         # Negation
    | booleanExpression 'and' booleanExpression     # LogicalAnd
    | booleanExpression 'or' booleanExpression      # LogicalOr
    | '(' booleanExpression ')'                     # ParenthesizedBooleanExpression
    ;

expression 
    : NUMBER                                        # Literal
    | IDENT                                         # NestedVar
    | expression '!'                                # Factorial
    | <assoc=right> expression op='^' expression    # BinaryOperation
    | expression op=('*'|'/') expression            # BinaryOperation
    | expression op=('+'|'-') expression            # BinaryOperation
    | '(' expression ')'                            # ParenthesizedExpression
    ;
    
functionName
    : KW_PRINT
    | IDENT
    ;


KW_PRINT        : 'print';
COMP_OPERATOR   : '>' | '>=' | '<' | '<=' | '==' | '!=' ;
NUMBER          : NONZERO_DIGIT DIGIT* | ZERO;
IDENT           : LETTER (LETTER | DIGIT)*;
//NEWLINE         : '\r'? '\n';
WHITESPACE      : [ \t\n\r]+ -> skip;

fragment NONZERO_DIGIT  : [1-9];
fragment ZERO           : '0';
fragment DIGIT          : ZERO | NONZERO_DIGIT;
fragment LETTER         : [a-zA-Z];