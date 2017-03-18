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
        public static ClassEntry intClass = new ClassEntry("int");
        public static ClassEntry floatClass = new ClassEntry("float");

        public override List<string> ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            ClassEntry typeClass = null;
            List<string> errors = new List<string>();
            string searchType = lastToken.getSemanticName();

            if (lastToken.getToken() == Tokens.TokenList.IntRes)
            {
                typeClass = intClass;
            }
            else if(lastToken.getToken() == Tokens.TokenList.FloatRes)
            {
                typeClass = floatClass;
            }
            else if(symbolTable.Any() && symbolTable.Peek().getParent() != null && symbolTable.Peek().getParent().getName() == searchType)
            {
                errors.Add(string.Format("{0}'s member variable or function parameter cannot refer to its own class at line {1}", searchType, lastToken.getLine()));
                typeClass = symbolTable.Peek().getParent() as ClassEntry;
            }
            else
            {
                foreach (SymbolTable table in symbolTable)
                {
                    typeClass = table.GetEntries().FirstOrDefault(x => x.getKind() == EntryKinds.classKind && x.getName() == searchType) as ClassEntry;

                    if (typeClass != null)
                        break;
                }
            }
            

            if(typeClass != null)
                semanticRecordTable.Push(new SemanticRecord(typeClass));
            else
            {
                errors.Add(string.Format("Type name: {0} does not exist at line {1}", searchType, lastToken.getLine()));
                semanticRecordTable.Push(new SemanticRecord(new ClassEntry(searchType)));
            }

            return errors;
        }

        public override string getProductName()
        {
            return "Add a named type to the semantic stack";
        }
    }
}
