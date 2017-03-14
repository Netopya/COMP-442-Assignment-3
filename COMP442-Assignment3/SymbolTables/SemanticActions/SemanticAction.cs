using COMP442_Assignment3.Syntactic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Tokens;
using COMP442_Assignment3.SymbolTables.SemanticRecords;
using COMP442_Assignment3.Lexical;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    public abstract class SemanticAction : IProduceable
    {
        public abstract void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken);

        public List<Token> getFirstSet()
        {
            throw new NotImplementedException();
        }

        public List<Token> getFollowSet()
        {
            throw new NotImplementedException();
        }

        public abstract string getProductName();

        public bool isTerminal()
        {
            return false;
        }
    }
}
