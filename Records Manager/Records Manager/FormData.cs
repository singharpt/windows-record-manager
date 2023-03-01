using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entry_Form
{
    /// <summary>
    /// This class FormData.cs contains the logic of the data dictionary that is used in the program to store all the data extracted from the text file.
    /// </summary>
    internal class FormData
    {
        //This is the data dictionary variable used in the complete program.
        public IDictionary<string, string[]> formDict;

        /// <summary>
        /// Constructor for the class FormData.
        /// Intialises all the formDict variable as dictionary where key is of string type and value is of type array of strings.
        /// </summary>
        public FormData() { formDict = new Dictionary<string, string[]>(); }

        /// <summary>
        /// This method adds key-value pair in the formDIct dictionary.
        /// </summary>
        public void AddModifyData(string key, string[] value)
        {
            if (formDict.ContainsKey(key) == true) { formDict[key] = value; }
            else { formDict.Add(key, value); }
        }

        /// <summary>
        /// This method delets key-value pair in the formDIct dictionary, if the key is present.
        /// </summary>
        public void DeleteData(string key) 
        {
            if (formDict.ContainsKey(key) == true) { formDict.Remove(key); }
        }

    }
}
