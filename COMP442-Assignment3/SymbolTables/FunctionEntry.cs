using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP442_Assignment3.SymbolTables.SemanticActions;

namespace COMP442_Assignment3.SymbolTables
{
    public class FunctionEntry : Entry
    {
        SymbolTable child;
        string type;

        public FunctionEntry(SymbolTable parent, string name, string type) : base(parent, EntryKinds.function, name)
        {
            child = new SymbolTable("Function: " + name);
            this.type = type;
        }

        public override SymbolTable getChild()
        {
            return child;
        }

        public override string getType()
        {
            return type;
        }

        public void AddParameters(IEnumerable<Variable> parameters)
        {
            child.AddEntryRange(parameters.Select(x => new VarParamEntry(getParent(), x, EntryKinds.parameter)));
        }
    }
}
