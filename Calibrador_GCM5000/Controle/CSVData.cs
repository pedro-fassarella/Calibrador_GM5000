using GenericParsing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibrador_GCM5000.Controle
{
    public class CSVData
    {

        public static DataTable GetDataTableFromFile(string filePath)
        {
            using GenericParserAdapter parser = new(filePath);
            parser.FirstRowHasHeader = true;
            return parser.GetDataTable();
        }
    }
}
