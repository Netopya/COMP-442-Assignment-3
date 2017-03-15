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

        public string GetName()
        {
            return name;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public void AddDimension(int dimension)
        {
            dimensions.AddFirst(dimension);
        }

        public string formatString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(type);
            foreach(int dimension in dimensions)
            {
                sb.AppendFormat("[{0}]", dimension);
            }

            return sb.ToString();
        }
    }
}
