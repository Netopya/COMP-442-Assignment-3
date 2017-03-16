using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    public class AddTypeToList : SemanticAction
    {
        public override List<string> ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            semanticRecordTable.Push(new SemanticRecord(RecordTypes.TypeName, lastToken.getSemanticName()));

            return new List<string>();
        }

        public override string getProductName()
        {
            return "Add a named type to the semantic stack";
        }
    }
}
