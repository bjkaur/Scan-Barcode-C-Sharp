using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.IO;

namespace ScanBarcode
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    internal class SSMPositionManager

    {
        public static string MASK_FILE = "masking.json";

        private SSMManager mcMasker;

        public SSMPositionManager()
        {
            //
            // TODO: Add constructor logic here
            LoadMasker();
        }

        public void LoadMasker(string lsFilename = null)
        {
            if (lsFilename == null) lsFilename = SSMPositionManager.MASK_FILE;
            try
            {
                using (StreamReader aSReader = File.OpenText(lsFilename))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    mcMasker = (SSMManager)serializer.Deserialize(aSReader, typeof(SSMManager));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetID(string lsID)
        {
            return mcMasker.GetID(lsID);
        }

        public void PrintPositions()
        {

        }

    }
}
