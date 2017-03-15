﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    class MigrateVariableToList : SemanticAction
    {
        public override void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            Variable variable = new Variable();
            while(semanticRecordTable.Peek().recordType == RecordTypes.IdName 
                || semanticRecordTable.Peek().recordType == RecordTypes.TypeName 
                || semanticRecordTable.Peek().recordType == RecordTypes.Size)
            {
                SemanticRecord topRecord = semanticRecordTable.Pop();
                switch (topRecord.recordType)
                {
                    case RecordTypes.Size:
                        variable.AddDimension(int.Parse(topRecord.getValue()));
                        break;
                    case RecordTypes.IdName:
                        variable.SetName(topRecord.getValue());
                        break;
                    case RecordTypes.TypeName:
                        variable.SetType(topRecord.getValue());
                        SemanticRecord variableRecord = new SemanticRecord(variable);
                        semanticRecordTable.Push(variableRecord);
                        break;
                    default:
                        // This should only occur if the grammar is not valid
                        Console.WriteLine("Grammar error, parsed rule that placed unexpected character on semantic stack");
                        break;
                }
            }
        }

        public override string getProductName()
        {
            return "Construct a variable and place it on the semantic stack";
        }
    }
}