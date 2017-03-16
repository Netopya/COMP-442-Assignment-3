using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    class MakeClassTable : SemanticAction
    {
        public override List<string> ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            SymbolTable currentTable = symbolTable.Peek();

            Entry classEntry = new ClassEntry(lastToken.getSemanticName(), currentTable);

            symbolTable.Push(classEntry.getChild());

            return new List<string>();
        }

        public override string getProductName()
        {
            return "Make a class symbol table";
        }
    }
}
