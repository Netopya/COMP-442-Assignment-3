using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables
{
    public class Variable
    {
        // SHOULD BE LINK TO CLASS
        string type;

        string name;

        LinkedList<int> dimensions = new LinkedList<int>();

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public void AddDimension(int dimension)
        {
            dimensions.AddFirst(dimension);
        }

    }
}
