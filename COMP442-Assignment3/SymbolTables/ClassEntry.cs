using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public class ClassEntry : Entry
    {
        SymbolTable child;

        public ClassEntry(string name, SymbolTable parent) : base(parent, EntryKinds.classKind, name)
        {
            child = new SymbolTable("Class: " + name);
        }

        public override SymbolTable getChild()
        {
            return child;
        }

        public override string getType()
        {
            return string.Empty;
        }
    }
}
