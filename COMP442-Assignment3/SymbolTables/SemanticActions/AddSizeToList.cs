﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    class AddSizeToList : SemanticAction
    {
        public override void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            semanticRecordTable.Push(new SemanticRecord(RecordTypes.Size, lastToken.getSemanticName()));
        }

        public override string getProductName()
        {
            return "Add a size value to the semantic stack";
        }
    }
}
