using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    class AddIdToList : SemanticAction
    {
        public override List<string> ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            List<string> errors = new List<string>();
            string idName = lastToken.getSemanticName();

            foreach (SymbolTable table in symbolTable)
            {
                foreach(Entry entry in table.GetEntries())
                {
                    if (entry.getName() == idName)
                    {
                        errors.Add(string.Format("Identifier {0} at line {1} has already been declared", idName, lastToken.getLine()));
                        break;
                    }
                }

                if (errors.Any())
                    break;
            }

            semanticRecordTable.Push(new SemanticRecord(RecordTypes.IdName, idName));

            return errors;
        }

        public override string getProductName()
        {
            return "Add a named type to the semantic stack";
        }
    }
}
