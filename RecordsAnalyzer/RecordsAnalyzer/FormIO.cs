using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordAnalyzer
{
    /// <summary>
    /// This class FormIO.cs is used for the input and output functions of the program.
    /// </summary>
    internal class FormIO
    {
        public FormData formDictObj;

        /// <summary>
        /// Constructor for the class FormIO.
        /// Intialises the filePath variable and formDictObj object to access class FormData.cs.
        /// </summary>
        public FormIO() 
        {
            formDictObj = new FormData();
        }

        /// <summary>
        /// This function first checks if the filePath exists.
        /// If the file path exists and the file is found then it extracts all the data and triggers the AddData() function of the class FormDict.cs.
        /// If any error is encountered during the data extraction, the function returns a string displaying the error message. Else, it will returna string "true".
        /// </summary>
        public string GetData(string filePath) 
        {
            if (File.Exists(filePath))
            {
                StreamReader readFile = new StreamReader(filePath);
                string line;
                int i = 0;
                while ((line = readFile.ReadLine()) != null)
                {
                    i++;
                    string[] value = line.Split(new char[] { '\t' });
                    if (value.Length != 16) { return "\u25C9 Cannot analyze the file as it has invalid data. Please select a new file using the browse button."; }
                    string key = value[0].ToLower().Trim() + value[2].ToLower().Trim() + value[9].ToLower().Trim();
                    key = key.Replace(" ", "");
                    formDictObj.AddData(key, value);
                }
                if (i == 0) { return "\u25C9 Cannot analyze an empty file. Please select a different file."; }
                readFile.Close();
                return "true";
            }
            else
                return "\u25C9 Selected file does not exist. Please select a different file.";
        }

        /// <summary>
        /// This function saves the items present inside the result parameter passed to this mwthod in a specific way to a textfile present at the specified filePath.
        /// </summary>
        public void SaveData(string[] result)
        {
            string filePath = Path.Combine(Application.StartupPath, "OutputFile.txt");
            StreamWriter writeFile = new StreamWriter(filePath);
            writeFile.WriteLine("Number of records : " + result[0]);
            writeFile.WriteLine("Minimum entry time : " + result[1]);
            writeFile.WriteLine("Maximum entry time : " + result[2]);
            writeFile.WriteLine("Average entry time : " + result[3]);
            writeFile.WriteLine("Minimum inter-record time : " + result[4]);
            writeFile.WriteLine("Maximum inter-record time : " + result[5]);
            writeFile.WriteLine("Average inter-record time : " + result[6]);
            writeFile.WriteLine("Total time : " + result[7]);
            writeFile.WriteLine("Backspace count : " + result[8]);
            writeFile.Close();
        }
    }
}
