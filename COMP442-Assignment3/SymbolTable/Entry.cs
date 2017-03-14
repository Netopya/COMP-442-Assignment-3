using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public enum EntryKinds
    {
        function,
        classKind,
        parameter,
        variable
    };

    public abstract class Entry
    {
        bool declared;

        SymbolTable child;
        SymbolTable parent;
        EntryKinds kind;

        public Entry(SymbolTable parent, EntryKinds kind)
        {
            this.parent = parent;
            this.kind = kind;
        }

    }
}
