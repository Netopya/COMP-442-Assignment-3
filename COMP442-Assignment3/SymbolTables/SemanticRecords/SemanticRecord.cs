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
        Size
    }

    public class SemanticRecord
    {
        public RecordTypes recordType
        {
            get; set;
        }

        string value;

        public SemanticRecord(RecordTypes recordType, string value)
        {
            this.recordType = recordType;
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }
      
    }

}
