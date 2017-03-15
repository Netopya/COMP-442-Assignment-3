using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.Lexical;
using COMP442_Assignment3.SymbolTables.SemanticRecords;

namespace COMP442_Assignment3.SymbolTables.SemanticActions
{
    public class MakeFunctionTable : SemanticAction
    {
        public override void ExecuteSemanticAction(Stack<SemanticRecord> semanticRecordTable, Stack<SymbolTable> symbolTable, IToken lastToken)
        {
            SymbolTable currentTable = symbolTable.Peek();

            //SemanticRecord typeRecord = semanticRecordTable.Pop();

            LinkedList<Variable> foundParameters = new LinkedList<Variable>();

            bool entryCreated = false;

            while(!entryCreated)
            {
                SemanticRecord topRecord = semanticRecordTable.Pop();

                switch(topRecord.recordType)
                {
                    case RecordTypes.Variable:
                        foundParameters.AddFirst(topRecord.getVariable());
                        break;
                    case RecordTypes.TypeName:
                        FunctionEntry funcEntry = new FunctionEntry(currentTable, lastToken.getSemanticName(), topRecord.getValue());
                        funcEntry.AddParameters(foundParameters);

                        symbolTable.Push(funcEntry.getChild());

                        entryCreated = true;

                        break;
                    default:
                        // This should only fail if there is an error in the grammar.
                        Console.WriteLine("Grammar error, parsed rule that placed unexpected character on semantic stack");
                        break;
                }
            }
        }

        public override string getProductName()
        {
            return "Make the table for a function";
        }
    }
}
