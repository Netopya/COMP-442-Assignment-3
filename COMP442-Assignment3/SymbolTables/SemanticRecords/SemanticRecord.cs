using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP442_Assignment3.SymbolTables.SemanticRecords
{
    public enum RecordTypes
    {
        TypeName,
        IdName,
        Size,
        Variable
    }

    public class SemanticRecord
    {
        public RecordTypes recordType
        {
            get; set;
        }

        string value;
        Variable variable;

        public SemanticRecord(RecordTypes recordType, string value)
        {
            this.recordType = recordType;
            this.value = value;
        }

        public SemanticRecord(Variable variable)
        {
            this.variable = variable;
            this.recordType = RecordTypes.Variable;
        }

        public string getValue()
        {
            return value;
        }
      
        public Variable getVariable()
        {
            return variable;
        }
    }

}
