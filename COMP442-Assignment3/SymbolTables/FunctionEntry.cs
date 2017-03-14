using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public class FunctionEntry : Entry
    {
        SymbolTable child;

        public FunctionEntry(SymbolTable parent, string name) : base(parent, EntryKinds.function, name)
        {
            child = new SymbolTable("Function: " + name);
        }

        public override SymbolTable getChild()
        {
            return child;
        }
        
    }
}
