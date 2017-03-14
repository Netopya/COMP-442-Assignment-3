﻿using COMP442_Assignment3.SymbolTables.SemanticActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.SymbolTables;
using COMP442_Assignment3.SymbolTables.SemanticRecords;
using COMP442_Assignment3.Tokens;
using COMP442_Assignment3.Lexical;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    public class MakeFunctionTable : SemanticAction
    {
        public override void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTables.SymbolTable> symbolTable, IToken lastToken)
        {
            
        }

        public override string getProductName()
        {
            return "Make program entry in symbol table";
        }
    }
}