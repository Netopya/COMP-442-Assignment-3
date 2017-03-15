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

        SymbolTable parent;
        EntryKinds kind;
        string name;

        public Entry(SymbolTable parent, EntryKinds kind, string name)
        {
            this.parent = parent;

            // Establish a two-way link in the tree
            parent.AddEntry(this);

            this.kind = kind;
            this.name = name;
        }

        public abstract SymbolTable getChild();

        public abstract string getType();

        public void printTable(int tabs, StringBuilder sb)
        {
            sb.Append(new String('\t', tabs));

            sb.AppendFormat("name: {0}, kind: {1}", name, kind.ToString());

            string type = getType();

            if(type != string.Empty)
            {
                sb.AppendFormat(", type: {0}", type);
            }

            sb.AppendLine();

            getChild().printTable(tabs + 1, sb);
        }
    }
}
