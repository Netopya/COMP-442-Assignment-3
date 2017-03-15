using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    class MakeVariableTable : SemanticAction
    {
        public override void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            SymbolTable currentTable = symbolTable.Peek();

            SemanticRecord variableRecord = semanticRecordTable.Pop();

            Entry variableEntry = new VarParamEntry(currentTable, variableRecord.getVariable(), EntryKinds.variable);
        }

        public override string getProductName()
        {
            return "Add a variable to the symbolic table";
        }
    }
}
