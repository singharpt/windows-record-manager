namespace Data_Entry_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.initial = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.add2 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.purchase = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.Fname_tb = new System.Windows.Forms.TextBox();
            this.Initial_tb = new System.Windows.Forms.TextBox();
            this.Lname_tb = new System.Windows.Forms.TextBox();
            this.Add1_tb = new System.Windows.Forms.TextBox();
            this.Add2_tb = new System.Windows.Forms.TextBox();
            this.City_tb = new System.Windows.Forms.TextBox();
            this.State_tb = new System.Windows.Forms.TextBox();
            this.Zip_tb = new System.Windows.Forms.TextBox();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.Date_tb = new System.Windows.Forms.TextBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.FormDataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Gender_tb = new System.Windows.Forms.TextBox();
            this.Purchase_tb = new System.Windows.Forms.TextBox();
            this.totalRecordsLabel = new System.Windows.Forms.Label();
            this.programStateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FormDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(466, 31);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(64, 15);
            this.fname.TabIndex = 17;
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(467, 58);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(63, 15);
            this.lname.TabIndex = 19;
            this.lname.Text = "Last Name";
            // 
            // initial
            // 
            this.initial.AutoSize = true;
            this.initial.Location = new System.Drawing.Point(667, 30);
            this.initial.Name = "initial";
            this.initial.Size = new System.Drawing.Size(36, 15);
            this.initial.TabIndex = 18;
            this.initial.Text = "Initial";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(447, 85);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(83, 15);
            this.add1.TabIndex = 20;
            this.add1.Text = "Address Line 1";
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(447, 112);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(83, 15);
            this.add2.TabIndex = 2;
            this.add2.Text = "Address Line 2";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(497, 166);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(33, 15);
            this.state.TabIndex = 23;
            this.state.Text = "State";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(442, 247);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(88, 15);
            this.phone.TabIndex = 26;
            this.phone.Text = "Phone Number";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(502, 139);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(28, 15);
            this.city.TabIndex = 22;
            this.city.Text = "City";
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Location = new System.Drawing.Point(475, 193);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(55, 15);
            this.zip.TabIndex = 24;
            this.zip.Text = "Zip Code";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(485, 220);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(45, 15);
            this.gender.TabIndex = 25;
            this.gender.Text = "Gender";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(446, 274);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(86, 15);
            this.email.TabIndex = 27;
            this.email.Text = "E-mail Address";
            // 
            // purchase
            // 
            this.purchase.AutoSize = true;
            this.purchase.Location = new System.Drawing.Point(380, 301);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(152, 15);
            this.purchase.TabIndex = 28;
            this.purchase.Text = "Proof of Purchase Attached";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(452, 328);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(81, 15);
            this.date.TabIndex = 29;
            this.date.Text = "Date Received";
            // 
            // Fname_tb
            // 
            this.Fname_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Fname_tb.Location = new System.Drawing.Point(536, 25);
            this.Fname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fname_tb.MaxLength = 25;
            this.Fname_tb.Name = "Fname_tb";
            this.Fname_tb.Size = new System.Drawing.Size(102, 23);
            this.Fname_tb.TabIndex = 0;
            this.Fname_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Fname_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Fname_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Fname_tb_Validating);
            // 
            // Initial_tb
            // 
            this.Initial_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Initial_tb.Location = new System.Drawing.Point(708, 25);
            this.Initial_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Initial_tb.MaxLength = 1;
            this.Initial_tb.Name = "Initial_tb";
            this.Initial_tb.Size = new System.Drawing.Size(24, 23);
            this.Initial_tb.TabIndex = 1;
            this.Initial_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Initial_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            // 
            // Lname_tb
            // 
            this.Lname_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Lname_tb.Location = new System.Drawing.Point(536, 52);
            this.Lname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lname_tb.MaxLength = 25;
            this.Lname_tb.Name = "Lname_tb";
            this.Lname_tb.Size = new System.Drawing.Size(102, 23);
            this.Lname_tb.TabIndex = 2;
            this.Lname_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Lname_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Lname_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Lname_tb_Validating);
            // 
            // Add1_tb
            // 
            this.Add1_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Add1_tb.Location = new System.Drawing.Point(536, 79);
            this.Add1_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add1_tb.MaxLength = 35;
            this.Add1_tb.Name = "Add1_tb";
            this.Add1_tb.Size = new System.Drawing.Size(140, 23);
            this.Add1_tb.TabIndex = 3;
            this.Add1_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Add1_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Add1_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Add1_tb_Validating);
            // 
            // Add2_tb
            // 
            this.Add2_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Add2_tb.Location = new System.Drawing.Point(536, 106);
            this.Add2_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add2_tb.MaxLength = 35;
            this.Add2_tb.Name = "Add2_tb";
            this.Add2_tb.Size = new System.Drawing.Size(140, 23);
            this.Add2_tb.TabIndex = 4;
            this.Add2_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Add2_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Add2_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Add2_tb_Validating);
            // 
            // City_tb
            // 
            this.City_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.City_tb.Location = new System.Drawing.Point(536, 133);
            this.City_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.City_tb.MaxLength = 25;
            this.City_tb.Name = "City_tb";
            this.City_tb.Size = new System.Drawing.Size(102, 23);
            this.City_tb.TabIndex = 5;
            this.City_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.City_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.City_tb.Validating += new System.ComponentModel.CancelEventHandler(this.City_tb_Validating);
            // 
            // State_tb
            // 
            this.State_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.State_tb.Location = new System.Drawing.Point(536, 160);
            this.State_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.State_tb.MaxLength = 2;
            this.State_tb.Name = "State_tb";
            this.State_tb.Size = new System.Drawing.Size(29, 23);
            this.State_tb.TabIndex = 6;
            this.State_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.State_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.State_tb.Validating += new System.ComponentModel.CancelEventHandler(this.State_tb_Validating);
            // 
            // Zip_tb
            // 
            this.Zip_tb.Location = new System.Drawing.Point(536, 187);
            this.Zip_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zip_tb.MaxLength = 9;
            this.Zip_tb.Name = "Zip_tb";
            this.Zip_tb.Size = new System.Drawing.Size(67, 23);
            this.Zip_tb.TabIndex = 7;
            this.Zip_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Zip_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Zip_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Zip_tb_Validating);
            // 
            // Phone_tb
            // 
            this.Phone_tb.Location = new System.Drawing.Point(536, 241);
            this.Phone_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phone_tb.MaxLength = 10;
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(67, 23);
            this.Phone_tb.TabIndex = 9;
            this.Phone_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Phone_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Phone_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Phone_tb_Validating);
            // 
            // Email_tb
            // 
            this.Email_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Email_tb.Location = new System.Drawing.Point(536, 268);
            this.Email_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email_tb.MaxLength = 60;
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(196, 23);
            this.Email_tb.TabIndex = 10;
            this.Email_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Email_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Email_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Email_tb_Validating);
            // 
            // Date_tb
            // 
            this.Date_tb.Location = new System.Drawing.Point(536, 322);
            this.Date_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_tb.MaxLength = 10;
            this.Date_tb.Name = "Date_tb";
            this.Date_tb.PlaceholderText = "MM/DD/YYYY";
            this.Date_tb.Size = new System.Drawing.Size(84, 23);
            this.Date_tb.TabIndex = 12;
            this.Date_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Date_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Date_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Date_tb_Validating);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_save.Location = new System.Drawing.Point(54, 342);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 27);
            this.Btn_save.TabIndex = 13;
            this.Btn_save.Text = "Add Data";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_delete.Location = new System.Drawing.Point(154, 342);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(75, 27);
            this.Btn_delete.TabIndex = 14;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_clear.Location = new System.Drawing.Point(254, 342);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(75, 27);
            this.Btn_clear.TabIndex = 15;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // FormDataGrid
            // 
            this.FormDataGrid.AllowUserToAddRows = false;
            this.FormDataGrid.AllowUserToDeleteRows = false;
            this.FormDataGrid.AllowUserToResizeColumns = false;
            this.FormDataGrid.AllowUserToResizeRows = false;
            this.FormDataGrid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.FormDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FormDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FormDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phoneNum});
            this.FormDataGrid.GridColor = System.Drawing.Color.White;
            this.FormDataGrid.Location = new System.Drawing.Point(24, 27);
            this.FormDataGrid.MultiSelect = false;
            this.FormDataGrid.Name = "FormDataGrid";
            this.FormDataGrid.ReadOnly = true;
            this.FormDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FormDataGrid.RowHeadersVisible = false;
            this.FormDataGrid.RowTemplate.Height = 25;
            this.FormDataGrid.RowTemplate.ReadOnly = true;
            this.FormDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormDataGrid.ShowCellToolTips = false;
            this.FormDataGrid.ShowEditingIcon = false;
            this.FormDataGrid.Size = new System.Drawing.Size(333, 181);
            this.FormDataGrid.StandardTab = true;
            this.FormDataGrid.TabIndex = 16;
            this.FormDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormDataGrid_CellEnter);
            this.FormDataGrid.Enter += new System.EventHandler(this.FormDataGrid_Enter);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 108.6294F;
            this.name.HeaderText = "Name";
            this.name.MaxInputLength = 52;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNum.FillWeight = 91.37055F;
            this.phoneNum.HeaderText = "Phone Number";
            this.phoneNum.MaxInputLength = 10;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RichTextBox.Location = new System.Drawing.Point(24, 235);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(333, 94);
            this.RichTextBox.TabIndex = 17;
            this.RichTextBox.TabStop = false;
            this.RichTextBox.Text = "You will find the status of your add, modify and delete operations here.\n";
            // 
            // Gender_tb
            // 
            this.Gender_tb.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F"});
            this.Gender_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Gender_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Gender_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Gender_tb.Location = new System.Drawing.Point(536, 214);
            this.Gender_tb.MaxLength = 1;
            this.Gender_tb.Name = "Gender_tb";
            this.Gender_tb.Size = new System.Drawing.Size(29, 23);
            this.Gender_tb.TabIndex = 8;
            this.Gender_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Gender_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Gender_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Gender_tb_Validating);
            // 
            // Purchase_tb
            // 
            this.Purchase_tb.AutoCompleteCustomSource.AddRange(new string[] {
            "YES",
            "NO"});
            this.Purchase_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Purchase_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Purchase_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Purchase_tb.Location = new System.Drawing.Point(536, 295);
            this.Purchase_tb.MaxLength = 3;
            this.Purchase_tb.Name = "Purchase_tb";
            this.Purchase_tb.Size = new System.Drawing.Size(43, 23);
            this.Purchase_tb.TabIndex = 11;
            this.Purchase_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackSpaceCounter_KeyDown);
            this.Purchase_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_KeyPress);
            this.Purchase_tb.Validating += new System.ComponentModel.CancelEventHandler(this.Purchase_tb_Validating);
            // 
            // totalRecordsLabel
            // 
            this.totalRecordsLabel.AutoSize = true;
            this.totalRecordsLabel.Location = new System.Drawing.Point(266, 211);
            this.totalRecordsLabel.Name = "totalRecordsLabel";
            this.totalRecordsLabel.Size = new System.Drawing.Size(77, 15);
            this.totalRecordsLabel.TabIndex = 30;
            this.totalRecordsLabel.Text = "Total Records";
            // 
            // programStateLabel
            // 
            this.programStateLabel.Location = new System.Drawing.Point(567, 369);
            this.programStateLabel.Name = "programStateLabel";
            this.programStateLabel.Size = new System.Drawing.Size(186, 17);
            this.programStateLabel.TabIndex = 31;
            this.programStateLabel.Text = "Program Status Label";
            this.programStateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 389);
            this.Controls.Add(this.programStateLabel);
            this.Controls.Add(this.totalRecordsLabel);
            this.Controls.Add(this.Purchase_tb);
            this.Controls.Add(this.Gender_tb);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.FormDataGrid);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Date_tb);
            this.Controls.Add(this.Email_tb);
            this.Controls.Add(this.Phone_tb);
            this.Controls.Add(this.Zip_tb);
            this.Controls.Add(this.State_tb);
            this.Controls.Add(this.City_tb);
            this.Controls.Add(this.Add2_tb);
            this.Controls.Add(this.Add1_tb);
            this.Controls.Add(this.Lname_tb);
            this.Controls.Add(this.Initial_tb);
            this.Controls.Add(this.Fname_tb);
            this.Controls.Add(this.date);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.email);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.city);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.state);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.initial);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(772, 428);
            this.MinimumSize = new System.Drawing.Size(772, 428);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fname;
        private Label lname;
        private Label initial;
        private Label add1;
        private Label add2;
        private Label state;
        private Label phone;
        private Label city;
        private Label zip;
        private Label gender;
        private Label email;
        private Label purchase;
        private Label date;
        private TextBox Fname_tb;
        private TextBox Initial_tb;
        private TextBox Lname_tb;
        private TextBox Add1_tb;
        private TextBox Add2_tb;
        private TextBox City_tb;
        private TextBox State_tb;
        private TextBox Zip_tb;
        private TextBox Phone_tb;
        private TextBox Email_tb;
        private TextBox Date_tb;
        private Button Btn_save;
        private Button Btn_delete;
        private Button Btn_clear;
        private DataGridView FormDataGrid;
        private ErrorProvider errorProvider;
        private RichTextBox RichTextBox;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phoneNum;
        private TextBox Purchase_tb;
        private TextBox Gender_tb;
        private Label programStateLabel;
        private Label totalRecordsLabel;
    }
}