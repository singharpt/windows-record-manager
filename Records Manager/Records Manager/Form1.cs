using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Data_Entry_Form
{
    /// <summary>
    /// This is the main class of the program.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private readonly FormIO formIObj;
        private bool errorFlag;
        private int backspaceCounter;
        private DateTime? editFnameTime;

        /// <summary>
        /// Constructor for the class Form1.
        /// Intialises all the components on the form and sets value to some global variables
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            formIObj = new FormIO();
            backspaceCounter = 0;
        }

        /// <summary>
        ///  This function is triggered when Add Data Button is pressed/clicked on the form.
        ///  It first checks if the form has any validation errors, if form has errors the add button event does not works.
        ///  If form has no errors, it populates the form data dictionary and saves the data in the textfile.
        /// </summary>
        private void Btn_save_Click(object sender, EventArgs e)
        {
            //This function call is made to sure that user has attempted all the textboxes, if not it sets the error provider.
            //The reason to make this function is that user might not attempt all textboxes and click on add data button.
            CheckTextBox();

            //This condition is to check if the form has no validation errors.
            if (CheckFormError() == false) 
            {

                string finalStatus;
                //Array of string below contains complete user information
                string[] value = new String[16] {Fname_tb.Text.ToString().Trim(),
                                 Initial_tb.Text.ToString().Trim(),
                                 Lname_tb.Text.ToString().Trim(),
                                 Add1_tb.Text.ToString().Trim(),
                                 Add2_tb.Text.ToString().Trim(),
                                 City_tb.Text.ToString().Trim(),   
                                 State_tb.Text.ToString().Trim(),
                                 Zip_tb.Text.ToString().Trim(),
                                 Gender_tb.Text.ToString().Trim(),
                                 Phone_tb.Text.ToString().Trim(),
                                 Email_tb.Text.ToString().Trim(),
                                 Purchase_tb.Text.ToString().Trim(),
                                 Date_tb.Text.ToString().Trim(), "", "", "" };

                //The string variable key_ below contains user's first name, last name and phone number strings concatenated into lower case alphabets without any spaces.
                string key_ = Fname_tb.Text.ToString().ToLower().Trim() + Lname_tb.Text.ToString().ToLower().Trim() + Phone_tb.Text.ToString().ToLower().Trim();
                key_ = key_.Replace(" ", "");

                //The condition is to check if user is already present or not in our data dictionary.
                if (formIObj.formDictObj.formDict.ContainsKey(key_)) 
                {
                    finalStatus = "The existing user <" + Fname_tb.Text.ToString() 
                                        + " " + Lname_tb.Text.ToString()
                                        + ", " + Phone_tb.Text.ToString()
                                        + "> was modified and data was saved successfully.";
                    value[13] = formIObj.formDictObj.formDict[key_].GetValue(13).ToString().Trim();
                    value[14] = formIObj.formDictObj.formDict[key_].GetValue(14).ToString().Trim();
                    value[15] = formIObj.formDictObj.formDict[key_].GetValue(15).ToString().Trim();
                }
                else
                {
                    finalStatus = "The new user <" + Fname_tb.Text.ToString()
                    + " " + Lname_tb.Text.ToString()
                    + ", " + Phone_tb.Text.ToString()
                    + "> was added and data was saved successfully.";
                    this.FormDataGrid.Rows.Add(Fname_tb.Text.ToString() + " " + Lname_tb.Text.ToString(), Phone_tb.Text.ToString());
                    this.FormDataGrid.Sort(FormDataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    value[13] = editFnameTime.ToString().Trim();
                    value[14] = DateTime.Now.ToString().Trim();
                    value[15] = backspaceCounter.ToString().Trim();
                }
                
                //Once the required variables are set, AddModifyData() function of class FormData.cs is called to add/modify the data in the dictionary.
                formIObj.formDictObj.AddModifyData(key_, value);
                //The below method calls the SaveData() function of the class FormIO.cs which saves the data in our data dictionary to the textfile.
                formIObj.SaveData();
                RichTextBox.Text = finalStatus;
                //These are the calls to the cleaning functions that resets the forms for a new entry.
                errorProvider.Clear();
                ClearFormData();
                ClearFormGrid();
            }
        }

        /// <summary>
        ///  This function is triggered when the form is loaded on the screen.
        ///  It first calls GetData() method of the class FormIO.cs which gets all the data from the textfile and trigers another method that populates the data dictionary.
        ///  It then populates the data grid with the data present in the data dictionary and clears the focus from data grid.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = Fname_tb;
            formIObj.GetData();
            PopulateFormDataGrid();
            ClearFormGrid();
            Date_tb.Text = DateTime.Now.ToString("MM/dd/yyyy");
            RichTextBox.Text = "You will find the status of your add, modify and delete operations here!";
        }

        /// <summary>
        ///  This function is a cleaning function, which resets the form on screen for new add/modify/delete operation.
        ///  It resets all the textboxes on the screen.
        ///  Enables the textboxes containing first/last name and phone number.
        ///  Resets the backspace counter & datetime variable that stores timestamp when user started filling the form.
        /// </summary>
        private void ClearFormData() 
        {
            var t = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox tb in t){ tb.Text = ""; }
            ActiveControl = Fname_tb;
            Fname_tb.ReadOnly = false;
            Lname_tb.ReadOnly = false;
            Phone_tb.ReadOnly = false;
            errorProvider.Clear();
            Date_tb.Text = DateTime.Now.ToString("MM/dd/yyyy");
            backspaceCounter = 0;
            editFnameTime = null;
            programStateLabel.Text = "\u25C9" + " Adding New Record";
        }

        /// <summary>
        ///  This function is a cleaning function, which resets the data grid present in the form on the screen.
        ///  It clears the current selection and sets the current cell to null.
        ///  It also counts the total rows in the data grid and displays on the form.
        /// </summary>
        private void ClearFormGrid()
        {
            FormDataGrid.ClearSelection();
            FormDataGrid.CurrentCell = null;
            totalRecordsLabel.Text = "Total Records : "+FormDataGrid.Rows.Count.ToString();
            ClearFormData();
        }

        /// <summary>
        ///  This function populates the data grid present in the form on the screen and sorts all the data in ascending order as per name column.
        /// </summary>
        private void PopulateFormDataGrid()
        {
            foreach (KeyValuePair<string, string[]> item in formIObj.formDictObj.formDict)
            {
                this.FormDataGrid.Rows.Add(item.Value[0].ToString().Trim() + " " + item.Value[2].ToString().Trim(), item.Value[9].ToString().Trim());
            }
            this.FormDataGrid.Sort(FormDataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        /// <summary>
        ///  This function is triggered when Delete Button is pressed/clicked on the form.
        ///  It a user is selected on the data grid, it first extracts the index of the current cell selected.
        ///  It then extracts the text present in the row that corresponds to the index extracted.
        ///  It then calls the DeleteData() method from the class FormData.cs which deletes the user selected.
        ///  It then calls the SaveData() method from the class FormIO.cs to save the data in the textfile.
        ///  In the end, calls the methods that cleans the data grid and resets the form for new record entry.
        /// </summary>
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (FormDataGrid.CurrentCell != null) 
            {
                string finalMessage;
                int index = this.FormDataGrid.CurrentRow.Index;
                string data = FormDataGrid.Rows[index].Cells[0].Value.ToString() +
                              FormDataGrid.Rows[index].Cells[1].Value.ToString();
                finalMessage = "The user <" + FormDataGrid.Rows[index].Cells[0].Value.ToString() + 
                                    ", " + FormDataGrid.Rows[index].Cells[1].Value.ToString() +
                                    "> was deleted and data was saved successfully!";
                data = data.Replace(" ", "").ToLower().Trim();
                FormDataGrid.Rows.RemoveAt(index);
                formIObj.formDictObj.DeleteData(data);
                RichTextBox.Text = finalMessage;
                ClearFormGrid();
                ClearFormData();
                formIObj.SaveData();
            }
        }

        /// <summary>
        ///  This function is a logical block used to display all the data of the selected user on the data grid. The function is triggered when focus enters the data grid.
        ///  It fills all the textboxes with the respective data stored for the user in the data dictionary and disables the first name, last name and phone number textboxes.
        /// </summary>
        private void DisplaySavedData(string key)
        {
            if (formIObj.formDictObj.formDict.ContainsKey(key))
            {
                Fname_tb.Text = formIObj.formDictObj.formDict[key][0].Trim();
                Initial_tb.Text = formIObj.formDictObj.formDict[key][1].Trim();
                Lname_tb.Text = formIObj.formDictObj.formDict[key][2].Trim();
                Add1_tb.Text = formIObj.formDictObj.formDict[key][3].Trim();
                Add2_tb.Text = formIObj.formDictObj.formDict[key][4].Trim();
                City_tb.Text = formIObj.formDictObj.formDict[key][5].Trim();
                State_tb.Text = formIObj.formDictObj.formDict[key][6].Trim();
                Zip_tb.Text = formIObj.formDictObj.formDict[key][7].Trim();
                Gender_tb.Text = formIObj.formDictObj.formDict[key][8].Trim();
                Phone_tb.Text = formIObj.formDictObj.formDict[key][9].Trim();
                Email_tb.Text = formIObj.formDictObj.formDict[key][10].Trim();
                Purchase_tb.Text = formIObj.formDictObj.formDict[key][11].Trim();
                Date_tb.Text = formIObj.formDictObj.formDict[key][12].Trim();
                Fname_tb.ReadOnly = true;
                Lname_tb.ReadOnly = true;
                Phone_tb.ReadOnly = true;
            }
        }

        /// <summary>
        ///  This function is triggered when Clear Data Button is pressed/clicked on the form.
        ///  It resets all the items on the form to their orignal state.
        /// </summary>
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ClearFormData();
            ClearFormGrid();
            RichTextBox.Text = "You will find the status of your add, modify and delete operations here!";
        }

        /// <summary>
        ///  This function is triggered when we leave the First Name Textbox.
        ///  It valdiates if the text entered is not null.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Fname_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Fname_tb.Text.Trim())) { errorProvider.SetError(Fname_tb, "Please Enter First Name!"); }
            else { errorProvider.SetError(Fname_tb, string.Empty); }
            WriteError();
            if (Fname_tb.Text.Length > 13) { Fname_tb.SelectionStart = 0; }            
        }

        /// <summary>
        ///  This function is triggered when we leave the Last Name Textbox.
        ///  It valdiates if the text entered is not null.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Lname_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Lname_tb.Text.Trim())) { errorProvider.SetError(Lname_tb, "Please Enter Last Name!"); }
            else { errorProvider.SetError(Lname_tb, string.Empty); }
            WriteError();
            if (Lname_tb.Text.Length > 13) { Lname_tb.SelectionStart = 0; }
        }

        /// <summary>
        ///  This function is triggered when we leave the Address1 Textbox.
        ///  It valdiates if the text entered is not null in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Add1_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Add1_tb.Text.Trim())) { errorProvider.SetError(Add1_tb, "Please Enter Address!"); }
            else { errorProvider.SetError(Add1_tb, string.Empty); }
            WriteError();
            if (Add1_tb.Text.Length > 23) { Add1_tb.SelectionStart = 0; }
        }

        /// <summary>
        ///  This function is triggered when we leave the Address2 Textbox.
        ///  It resets the selection pointer to start of the Address2 Textbox.
        /// </summary>
        private void Add2_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Add2_tb.Text.Length > 23) { Add2_tb.SelectionStart = 0; }
        }

        /// <summary>
        ///  This function is triggered when we leave the City Textbox.
        ///  It valdiates if the text entered is not null and has only valid literals in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void City_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(City_tb.Text.Trim())) { errorProvider.SetError(City_tb, "Please Enter City Name!"); }
            else if (!Regex.IsMatch(City_tb.Text, @"^[a-zA-Z]+(?:[\s-'.&/][a-zA-Z]+)*(?:[.|\s])?(?:[\(a-z\)])*$")) { errorProvider.SetError(City_tb, "Please Enter Valid City Name!"); }
            else { errorProvider.SetError(City_tb, string.Empty); }
            WriteError();
            if (City_tb.Text.Length > 15) { City_tb.SelectionStart = 0; }
        }

        /// <summary>
        ///  This function is triggered when we leave the State Textbox.
        ///  It valdiates if the text entered is not null and has only english alphabets in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void State_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(State_tb.Text.Trim())) { errorProvider.SetError(State_tb, "Please Enter State Name (ex. Texas = TX)!"); }
            else if (!Regex.IsMatch(State_tb.Text, @"^[A-Za-z]{2}$")) { errorProvider.SetError(State_tb, "Please Enter Exact 2 Letters (A-Z) In State Name!"); }
            else { errorProvider.SetError(State_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is triggered when we leave the Zip Code Textbox.
        ///  It valdiates if the text entered is not null and has only 5 or 9 digits in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Zip_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Zip_tb.Text.Trim())) { errorProvider.SetError(Zip_tb, "Please Enter Zip Code!"); }
            else if (!(Zip_tb.Text.Length == 5 || Zip_tb.Text.Length == 9)) { errorProvider.SetError(Zip_tb, "Please Enter a 5 or 9 Digit Zip Code!"); }
            else if (!Regex.IsMatch(Zip_tb.Text, @"^[0-9]+$")) { errorProvider.SetError(Zip_tb, "Please Enter Only Digits (0-9) In Zip Code!"); }
            else { errorProvider.SetError(Zip_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is triggered when we leave the Phone Number Textbox.
        ///  It valdiates if the text entered is not null and has exact 10 digits in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Phone_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Phone_tb.Text.Trim())) { errorProvider.SetError(Phone_tb, "Please Enter Phone Number!"); }
            else if (Phone_tb.Text.Length != 10) { errorProvider.SetError(Phone_tb, "Please Enter a 10 Digit Phone Number!"); }
            else if (!Regex.IsMatch(Phone_tb.Text, @"^[0-9]+$")) { errorProvider.SetError(Phone_tb, "Please Enter Only Digits (0-9) In Phone Number!"); }
            else { errorProvider.SetError(Phone_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is triggered when we leave the Email Address Textbox.
        ///  It valdiates if the text entered is not null and has the right email address format in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Email_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var em = new EmailAddressAttribute();
            if (string.IsNullOrEmpty(Email_tb.Text.Trim())) { errorProvider.SetError(Email_tb, "Please Enter E-Mail Address!"); }
            else if (!em.IsValid(Email_tb.Text)) { errorProvider.SetError(Email_tb, "Please Enter Valid E-Mail Address!"); }
            else { errorProvider.SetError(Email_tb, string.Empty); }
            WriteError();
            if ( Email_tb.Text.Length > 28 ) { Email_tb.SelectionStart = 0; }
        }

        /// <summary>
        ///  This function is triggered when we leave the Proof of Purchase Attached Textbox.
        ///  It valdiates if item is not null and has yes/no in it.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Purchase_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Purchase_tb.Text.Trim())) { errorProvider.SetError(Purchase_tb, "Please Type YES/NO In Proof Of Purchase Attached!"); }
            else if (!(Purchase_tb.Text.ToLower().Trim() == "yes" || Purchase_tb.Text.ToLower().Trim() == "no")) { errorProvider.SetError(Purchase_tb, "Please Type YES/NO In Proof Of Purchase Attached!"); }
            else { errorProvider.SetError(Purchase_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is triggered when we leave the Gender Textbox.
        ///  It valdiates if item has m/f in it, if not null.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Gender_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Gender_tb.Text.Trim())) { errorProvider.SetError(Gender_tb, string.Empty); }
            else if (!(Gender_tb.Text.ToLower().Trim() == "m" || Gender_tb.Text.ToLower().Trim() == "f")) { errorProvider.SetError(Gender_tb, "Please Type Only M/F In Gender!"); }
            else { errorProvider.SetError(Gender_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is triggered when we leave the Date Textbox.
        ///  It valdiates if the date entered is not null, has the right format, and is not greater than the current date.
        ///  If validation fails it sets the error provider with an error message and displays the error text on the rich text box present on the screen.
        /// </summary>
        private void Date_tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime value;
            DateTime curDate = DateTime.Now;
            if (string.IsNullOrEmpty(Date_tb.Text.Trim())) { errorProvider.SetError(Date_tb, "Please Enter Date (MM/DD/YYYY)!"); }
            else if (!DateTime.TryParse(Date_tb.Text, out value)) { errorProvider.SetError(Date_tb, "Please Enter Valid Date (MM/DD/YYYY)!"); }
            else if (value.Date > curDate.Date) { errorProvider.SetError(Date_tb, "Please Enter Date Which Is Less Than Current Date!"); }
            else { errorProvider.SetError(Date_tb, string.Empty); }
            WriteError();
        }

        /// <summary>
        ///  This function is a logical block triggered when we press the add data button.
        ///  It sets the value of the global variable errorFlag depending on if there is any validation error present in the form.
        ///  It returns a bool variable that is used in the main logic of the code.
        /// </summary>
        private bool CheckFormError() 
        {
            errorFlag = false;
            foreach (Control c in this.Controls) { if (errorProvider.GetError(c).Length > 0) { errorFlag = true; break; } }
            return errorFlag;
        }

        /// <summary>
        ///  This function is a logical block triggered when we press the add data button to check if no mandatory textboxes in the form are empty.
        ///  If any textbox is empty, it sets the error provider with the error message.
        /// </summary>
        private void CheckTextBox() 
        {
            if (Fname_tb.Text == string.Empty ||
               Lname_tb.Text == string.Empty ||
               Add1_tb.Text == string.Empty ||
               City_tb.Text == string.Empty ||
               State_tb.Text == string.Empty ||
               Zip_tb.Text == string.Empty ||
               Phone_tb.Text == string.Empty ||
               Email_tb.Text == string.Empty ||
               Purchase_tb.Text == string.Empty ||
               date.Text == string.Empty) 
            { 
                errorProvider.SetError(Btn_save, "Please Check If All Mandatory Fields Are Filled, If Yes Then Press The Add Button Again!");
                RichTextBox.Text = "Please Check If All Mandatory Fields Are Filled, If Yes Then Press The Add Button Again!";
            }
            else { errorProvider.SetError(Btn_save, string.Empty); }
        }

        /// <summary>
        ///  This function is a logical block used to store the timestamp of the event when user enters the first letter in the any textbox.
        ///  It checks if the editFnameTime is null, if yes then it stores the current timestamp in the editFnameTime DateTime variable.
        /// </summary>
        private void First_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (editFnameTime == null) { editFnameTime = DateTime.Now; }
        }

        /// <summary>
        ///  This function is a logical block used to store the timestamp of the event whenever user presses back space key in the form during data entry.
        ///  It increments the value of backspaceCounter variable which counts the number of time back space key is pressed for each add data function.
        /// </summary>
        private void BackSpaceCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back) { backspaceCounter += 1; } 
        }

        /// <summary>
        ///  This function is a logical block used to fix a bug in the form.
        /// </summary>
        private void FormDataGrid_Enter(object sender, EventArgs e)
        {
            bool flag = true;
            var tf = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox tb in tf) { if (!string.IsNullOrEmpty(tb.Text.Trim()) && tb!=Date_tb) { flag = false; break; } }
            if (flag == true) { ClearErrorProvider(); }
        }

        /// <summary>
        ///  This function is a logical block used to write all the error messages on the rich text box on the form.
        /// </summary>
        private void WriteError() 
        {
            string errorString = string.Empty;
            foreach (Control c in this.Controls) 
            {   if (!string.IsNullOrEmpty(errorProvider.GetError(c))) { errorString += errorProvider.GetError(c) + "\n"; }}
            RichTextBox.Text = errorString;
        }

        /// <summary>
        ///  This function is a logical block used to reset the error provider and the text to null in the rich text box on the form.
        /// </summary>
        private void ClearErrorProvider() { errorProvider.Clear(); RichTextBox.Text = ""; }

        /// <summary>
        ///  This function is a logical block used to display all the data of the selected user on the data grid. The function is triggered when focus enters the data grid.
        ///  It fills all the textboxes with the respective data stored for the user in the data dictionary.
        ///  Upon entry, it also clears all the errors present in the form.
        ///  This function only executes if there is data present in the data grid.
        /// </summary>
        private void FormDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (FormDataGrid.Rows.Count > 0)
            {
                ClearErrorProvider();
                int index = this.FormDataGrid.CurrentRow.Index;
                string data = FormDataGrid.Rows[index].Cells[0].Value.ToString() + FormDataGrid.Rows[index].Cells[1].Value.ToString();
                data = data.Replace(" ", "").ToLower().Trim();
                DisplaySavedData(data);
                programStateLabel.Text = "\u25C9" + " Modifying Existing Record";
            }
        }
    }
}