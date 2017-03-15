using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public class SymbolTable
    {
        string name;
        Entry parent;
        List<Entry> entries = new List<Entry>();

        public SymbolTable(string name)
        {
            this.name = name;
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }

        public string printTable()
        {
            StringBuilder sb = new StringBuilder();

            printTable(0, sb);

            return sb.ToString();
        }

        public void printTable(int tabs, StringBuilder sb)
        {
            sb.Append(new String('\t', tabs));
            sb.AppendLine(name);

            foreach(var entry in entries)
            {
                //sb.Append(new String('\t', tabs + 1));
                entry.printTable(tabs, sb);
            }
        }
    }
}