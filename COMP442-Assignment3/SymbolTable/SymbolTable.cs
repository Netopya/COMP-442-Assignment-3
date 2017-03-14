using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTable
{
    public class SymbolTable
    {
        string name;
        Entry parent;
        List<Entry> entries = new List<Entry>();
    }
}