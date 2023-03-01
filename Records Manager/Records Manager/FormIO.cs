using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entry_Form
{
    /// <summary>
    /// This class FormIO.cs is used for the input and output functions of the program.
    /// </summary>
    internal class FormIO
    {
        private string filePath;
        public FormData formDictObj;

        /// <summary>
        /// Constructor for the class FormIO.
        /// Intialises the filePath variable and formDictObj object to access class FormData.cs.
        /// </summary>
        public FormIO() 
        {
            filePath = Path.Combine(Application.StartupPath, "Data.txt");
            formDictObj = new FormData();
        }

        /// <summary>
        /// This function first checks if the filePath exists.
        /// If the file path exists and the file is found then it extracts all the data and triggers the AddModifyData() function of the class FormDict.cs.
        /// If the file is not found it creates and new file at the filePath specified.
        /// </summary>
        public void GetData() 
        {
            if (File.Exists(filePath))
            {
                StreamReader readFile = new StreamReader(filePath);
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    string[] value = line.Split(new char[] { '\t' });
                    string key = value[0].ToLower().Trim() + value[2].ToLower().Trim() + value[9].ToLower().Trim();
                    key = key.Replace(" ", "");
                    formDictObj.AddModifyData(key, value);
                }
                readFile.Close();
            }
        }

        /// <summary>
        /// This function saves the data present in the data dictionary to the textfile present at the specified filePath.
        /// </summary>
        public void SaveData()
        {
            StreamWriter writeFile = new StreamWriter(filePath);
            foreach (KeyValuePair<string, string[]> key in formDictObj.formDict) 
            {
                string output = string.Join("\t", key.Value);
                writeFile.WriteLine(output);
            }
            writeFile.Close();
        }
    }
}
