using System.Runtime.CompilerServices;

namespace RecordAnalyzer
{
    /// <summary>
    ///  This is main file for the project Asg3_axs210204
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly FormIO formIObj; //This is the object for the class FormIO.cs
        public string filePath; //A string variable to store the file path of the file selected by the user
        public string[] result; //An array of string that will contain all the calculated data.

        /// <summary>
        ///  Constructor for Form1.
        ///  Initializes all the required contents of the form and the global variables.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            formIObj= new FormIO();
            result= new string[9];
            openFileDialog.InitialDirectory = Application.StartupPath;
        }

        /// <summary>
        ///  This function is triggered when the form loads.
        ///  It sets the initial text in the rich text box and sets the active control of the program to the browse button.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            statusBox.Text = "\u25C9 Please select the file to be analyzed using the browse button. ";
            ActiveControl = BtnBrowse;
            statusBox.BackColor = Color.Cornsilk;
        }

        /// <summary>
        ///  This function is triggered when the browse button is clicked on the screen.
        ///  Opun clicking this button a file browser opens on screen through which the user selects the target file. 
        /// </summary>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            ClearFormData(); //This function call is made to clear the screen when browse button is pressed/clicked.
            if (openFileDialog.ShowDialog() == DialogResult.OK) //Condition to check if the file is selected successfully.
            {
                filePath = openFileDialog.FileName;
                fileBrowseTb.Text = filePath;
                string checkGetData = formIObj.GetData(filePath); //The function call is made to the method in class FormIO.cs, that returns a string to know if the data in file is retreived or not.
                if (checkGetData != "true") { statusBox.Text = checkGetData; statusBox.BackColor = Color.LightPink; } //If the data was not retrieved, an error message is displayed in the rich text box.
                else //If the data is retreived then analyze button is enabled and user is instructed to press/click it.
                {
                    statusBox.BackColor = Color.Cornsilk;
                    BtnAnalyze.Enabled = true;
                    ActiveControl = BtnAnalyze;
                    statusBox.Text = "\u25C9 To analyze the selected file click/press the analyze data button.";
                }
            }    
        }

        /// <summary>
        ///  This function is triggered when analyze button is pressed on the screen.
        ///  It triggers another function that populates all the textboxes present on the screen.
        /// </summary>
        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            statusBox.BackColor = Color.White;
            statusBox.Text = "\u25C9 To view more information about each field shown on screen press TAB or click the field's respective text box.";
            Populate_TextBoxes();
            BtnAnalyze.Enabled = false; //Once the data is displayed on the screen, the analyze button is disabled.
        }

        /// <summary>
        ///  This function is triggered when user presses/clicks the analyse button.
        ///  It is heart of this program where all the required calculations are done.
        /// </summary>
        private void Populate_TextBoxes()
        {
            var exitTimeList = new List<DateTime>(); //This list will contain all the timestamps of the time when user started entering a new record.
            var entryTimeList = new List<DateTime>(); //This list will contain all the timestamps of the time when user finished entering the record.
            int totalBackspace = 0; //This variable is used to count the total number of backspaces entered by the user.
            DateTime entryTime, exitTime;
            foreach (KeyValuePair<string, string[]> key in formIObj.formDictObj.formDict)
            {
                entryTime = DateTime.Parse(key.Value[13]);
                exitTime = DateTime.Parse(key.Value[14]);
                entryTimeList.Add(entryTime);
                exitTimeList.Add(exitTime);
                totalBackspace += Convert.ToInt32((key.Value[15]));
            }
            entryTimeList = entryTimeList.OrderBy(x => x).ToList(); //Once all the items are populated in the list it is sorted in ascending order as per the timestamp. 
            exitTimeList = exitTimeList.OrderBy(x => x).ToList(); //Once all the items are populated in the list it is sorted in ascending order as per the timestamp. 

            int totalRecords = formIObj.formDictObj.formDict.Count;
            int i = 0;
            int j = 0;

            TimeSpan minEntryTime = new TimeSpan(1000000, 0, 0); //This variable is used to store the minimum entry time.
            TimeSpan maxEntryTime = new TimeSpan(0, 0, 0); //This variable is used to store the max entry time.
            TimeSpan minInterTime = new TimeSpan(1000000, 0, 0); //This variable is used to store the minimum inter-record time.
            TimeSpan maxInterTime = new TimeSpan(0, 0, 0); //This variable is used to store the max inter-record time.
            TimeSpan totalTime; //This variable is used to store the total time.
            var avgEntryTime = new List<TimeSpan>(); //This is a list of timespan used to calculate the average entry time.
            var avgInterTime = new List<TimeSpan>(); //This is a list of timespan used to calculate the average inter-record time.

            totalTime = exitTimeList[totalRecords-1] - entryTimeList[0];

            //This loop calculates the min, max & avg inter-record time by finding the difference between the entry time of (i+1)'th record and exit time of (i)'th record.
            while (i < totalRecords - 1) 
            {   
                TimeSpan interDifference = entryTimeList[i + 1] - exitTimeList[i];
                if (minInterTime > interDifference) { minInterTime = interDifference; }
                if (maxInterTime < interDifference) { maxInterTime = interDifference; }
                avgInterTime.Add(interDifference);
                i++;
            }

            //This loop calculates the min, max & avg entry time by finding the difference between the entry time of (i)'th record and exit time of (i)'th record.
            while (j < totalRecords)
            {
                TimeSpan entryDifference = exitTimeList[j] - entryTimeList[j];
                if (minEntryTime > (entryDifference)) { minEntryTime = entryDifference; }
                if (maxEntryTime < (entryDifference)) { maxEntryTime = entryDifference; }
                avgEntryTime.Add(entryDifference);
                j++;
            }

            //Once all the variables are populated with their respected values, the result list is populated.
            result[0] = totalRecords.ToString();
            result[1] = minEntryTime.ToString(@"mm\:ss"); //All the timespans are converted in the format of MM:SS
            result[2] = maxEntryTime.ToString(@"mm\:ss");
            result[3] = new TimeSpan(Convert.ToInt64(avgEntryTime.Average(t => t.Ticks))).ToString(@"mm\:ss");
            result[4] = minInterTime.ToString(@"mm\:ss");
            result[5] = maxInterTime.ToString(@"mm\:ss");
            result[6] = new TimeSpan(Convert.ToInt64(avgInterTime.Average(t => t.Ticks))).ToString(@"mm\:ss");
            result[7] = totalTime.ToString(@"mm\:ss");
            result[8] = totalBackspace.ToString();

            //All the textboxes on the screen are populated with their respective data using the result array.
            recordsTb.Text = result[0];
            minEntryTb.Text = result[1];
            maxEntryTb.Text = result[2];
            avgEntryTb.Text = result[3];
            minInterTb.Text = result[4];
            maxInterTb.Text = result[5];
            avgInterTb.Text = result[6];
            totalTimeTb.Text = result[7];
            backspaceTb.Text = result[8];
        }


        /// <summary>
        ///  This function is triggered when user presses/clicks the browse button or the save button.
        ///  It sets all the textboxes on the screen with empty string and sets the active control of the program to the browse button.
        /// </summary>
        private void ClearFormData() 
        {
            var t = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox tb in t) { tb.Text = ""; }
            ActiveControl = BtnBrowse;
            filePath = string.Empty;
            BtnAnalyze.Enabled = false;
            //statusBox.Text = "\u25C9 To analyze the selected file click/press the analyze data button.";
        }

        /// <summary>
        ///  This function is triggered when the text is changed on any texbox on the screen.
        ///  If the text is changed and the text boxes are not empty, this function enables the save button.
        ///  If the text is changed and the text boxes are empty, this function will disable the save button.
        /// </summary>
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recordsTb.Text.ToString().Trim()))
                BtnSave.Enabled = false;
            else
                BtnSave.Enabled = true;
        }

        /// <summary>
        ///  This function is triggered when the a textbox gets focus on the screen.
        ///  Based upon what text box it is, a unique message gets displayed on the rich text box on the screen.
        /// </summary>
        private void Tb_GotFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(minEntryTb.Text.ToString().Trim()))
            {
                labelStatusBox.Text = "Information Box";
                statusBox.BackColor = Color.White;
            }

            if ((recordsTb as Control).Focused && !string.IsNullOrEmpty(minEntryTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Number of records displays the total number of records available in the text file. " +
                                 "In this text file, currently there are " + recordsTb.Text + " records available." +
                                 "\n\n\u25C9 To view more information about each field shown on screen press TAB or click the field's respective text box.";
                                 recordsTb.SelectionStart = recordsTb.Text.Length;
            }
            else if ((minEntryTb as Control).Focused && !string.IsNullOrEmpty(minEntryTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Minimum entry time displays the minimum time taken to record one entry." +
                                 "\n\n In this text file, the fastest entry was done by the user in just " + minEntryTb.Text + " MM:SS";
                                 minEntryTb.SelectionStart = minEntryTb.Text.Length;
            }
            else if ((maxEntryTb as Control).Focused && !string.IsNullOrEmpty(maxEntryTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Maximum entry time displays the maximum time taken to record one entry." +
                                 "\n\n In this text file, the slowest entry was done by the user in " + maxEntryTb.Text + " MM:SS";
                                 maxEntryTb.SelectionStart = maxEntryTb.Text.Length;
            }
            else if ((avgEntryTb as Control).Focused && !string.IsNullOrEmpty(avgEntryTb.Text.ToString().Trim())) 
            {
                statusBox.Text = "\u25C9 Average entry time displays the average time taken to record one entry." +
                                 "\n\n In this text file, the user took " + avgEntryTb.Text + " MM:SS on an average to do one entry.";
                                 avgEntryTb.SelectionStart = avgEntryTb.Text.Length;
            }
            else if ((minInterTb as Control).Focused && !string.IsNullOrEmpty(minInterTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Minimum inter-record time displays the minimum time taken between two entries." +
                                 "\n\n In this text file, the minimum time taken by the user from finishing one entry to moving on another entry is " + minInterTb.Text + " MM:SS.";
                                 minInterTb.SelectionStart = minInterTb.Text.Length;
            }
            else if ((maxInterTb as Control).Focused && !string.IsNullOrEmpty(maxInterTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Maximum inter-record time displays the maximum time taken between two entries." +
                                 "\n\n In this text file, the maximum time taken by the user from finishing one entry to moving on another entry is " + maxInterTb.Text + " MM:SS.";
                                 maxInterTb.SelectionStart = maxInterTb.Text.Length;
            }
            else if ((avgInterTb as Control).Focused && !string.IsNullOrEmpty(avgInterTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Average inter-record time displays the average time taken between two entries." +
                                 "\n\n In this text file, the user took " + avgInterTb.Text + " MM:SS on an average between any two entries.";;
                                 avgInterTb.SelectionStart = avgInterTb.Text.Length;
            }
            else if ((totalTimeTb as Control).Focused && !string.IsNullOrEmpty(totalTimeTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Total time displays the total time taken to enter all the records." +
                                 "\n\n To enter " + recordsTb.Text + " records, the user took a total time of " + totalTimeTb.Text + " MM:SS.";
                                 totalTimeTb.SelectionStart = totalTimeTb.Text.Length;
            }
            else if ((backspaceTb as Control).Focused && !string.IsNullOrEmpty(backspaceTb.Text.ToString().Trim())) 
            { 
                statusBox.Text = "\u25C9 Backspace count displays the total number of time back space key was pressed during data entry." +
                                 "\n\n In this file, user pressed the back key " + backspaceTb.Text + " number of times while entering all the records.";
                                 backspaceTb.SelectionStart = backspaceTb.Text.Length;
            }
        }

        /// <summary>
        ///  This function is triggered when focus enters the save button.
        ///  It will display a meesage on the rich text box, instructing user of what will happen if they press/click this button
        /// </summary>
        private void BtnSave_Enter(object sender, EventArgs e)
        {
            labelStatusBox.Text = "Instruction Box";
            statusBox.BackColor = Color.Cornsilk;
            statusBox.Text = "\u25C9 To save the displayed data, press or click the save button. This will save the data in the disk as a text file";
            ActiveControl = BtnSave;
        }

        /// <summary>
        ///  This function is triggered when the save button is clicked/pressed.
        ///  It will call the method SaveData of the class FormIO.cs which saves the displayed data to the disk in a text file.
        ///  It will display a meesage on the rich text box, instructing user that the file was saved and he can select a new file to analyze.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            formIObj.SaveData(result);
            ClearFormData();
            statusBox.Text = "\u25C9 The data was saved successfully in the disk as a text file. To analyze another file, click/press browse button to select a new file.";
        }

        /// <summary>
        ///  This function is triggered when focus enters the browse button.
        ///  It will display a message on the rich text box, instructing user of what will happen if they press/click this button.
        /// </summary>
        private void BtnBrowse_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recordsTb.Text.ToString().Trim()) && string.IsNullOrEmpty(fileBrowseTb.Text.ToString().Trim()))
            { statusBox.Text = "\u25C9 Please select the file to be analyzed using the browse button."; labelStatusBox.Text = "Instruction Box"; statusBox.BackColor = Color.Cornsilk; }
            else if (!string.IsNullOrEmpty(recordsTb.Text.ToString().Trim()) && !string.IsNullOrEmpty(fileBrowseTb.Text.ToString().Trim()))
            { statusBox.Text = "\u25C9 To start again and analyze another file, press/click the browse button to open a new file."; labelStatusBox.Text = "Instruction Box"; statusBox.BackColor = Color.Cornsilk; }
        }
    }
}