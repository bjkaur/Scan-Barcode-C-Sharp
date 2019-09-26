using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace ScanBarcode
{
    internal class SSMManager
    {
        public int DataLength { get; set; }
        public int[] Masking { get; set; }
        public DateTime Date { get; set; }
      //  SSMManager mcMasker = new SSMManager();

        public SSMManager() { }

        public string GetID(string lsString)
        {
            string aID = "";
            foreach (int index in Masking)
            {
                char aChar = lsString.ElementAt(index - 1);
                aID += aChar.ToString();
            }
            return aID;
        }
        
        public bool Save(string isFilename = null)
        {
            JObject ajsoncontent = new JObject(
                new JProperty("Datalength", DataLength),
                new JProperty("Masking", Masking),
                new JProperty("Date", Date)
                );
            if (isFilename == null) isFilename = SSMPositionManager.MASK_FILE;
            File.WriteAllText(isFilename, ajsoncontent.ToString());
        
            return true;
        }
    }
}