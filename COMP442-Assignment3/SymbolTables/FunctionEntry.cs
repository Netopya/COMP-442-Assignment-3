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
            child = new SymbolTable("Function Symbol Table: " + name);
            this.type = type;
        }

        public override SymbolTable getChild()
        {
            return child;
        }

        public override string getType()
        {
            var parameters = child.GetEntries().Where(x => x.getKind() == EntryKinds.parameter);

            if (parameters.Count() == 0)
                return type;
            else
                return string.Format("{0} : {1}", type, string.Join(", ", parameters.Select(x => x.getType())));
        }

        public void AddParameters(IEnumerable<Variable> parameters)
        {
            // Create a new entry for each parameter and
            // they will add themselves to the current "child" symbol table
            foreach (var parameter in parameters)
            {
                new VarParamEntry(child, parameter, EntryKinds.parameter);
            }
        }
    }
}
