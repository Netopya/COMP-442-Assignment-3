using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public class FunctionEntry : Entry
    {
        public FunctionEntry(SymbolTable parent) : base(parent, EntryKinds.function)
        {

        }
    }
}
