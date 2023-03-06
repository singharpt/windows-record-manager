namespace RecordAnalyzer
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
            this.recordsTb = new System.Windows.Forms.TextBox();
            this.minEntryTb = new System.Windows.Forms.TextBox();
            this.maxEntryTb = new System.Windows.Forms.TextBox();
            this.avgEntryTb = new System.Windows.Forms.TextBox();
            this.minInterTb = new System.Windows.Forms.TextBox();
            this.maxInterTb = new System.Windows.Forms.TextBox();
            this.avgInterTb = new System.Windows.Forms.TextBox();
            this.totalTimeTb = new System.Windows.Forms.TextBox();
            this.backspaceTb = new System.Windows.Forms.TextBox();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.minEntryLabel = new System.Windows.Forms.Label();
            this.maxEntryLabel = new System.Windows.Forms.Label();
            this.avgEntryLabel = new System.Windows.Forms.Label();
            this.minInterLabel = new System.Windows.Forms.Label();
            this.maxInterLabel = new System.Windows.Forms.Label();
            this.avgInterLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.fileBrowseTb = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.RichTextBox();
            this.backspaceLabel = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.labelStatusBox = new System.Windows.Forms.Label();
            this.unitLabel1 = new System.Windows.Forms.Label();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.unitLabel3 = new System.Windows.Forms.Label();
            this.unitLabel4 = new System.Windows.Forms.Label();
            this.unitLabel5 = new System.Windows.Forms.Label();
            this.unitLabel6 = new System.Windows.Forms.Label();
            this.unitLabel7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordsTb
            // 
            this.recordsTb.AcceptsTab = true;
            this.recordsTb.BackColor = System.Drawing.SystemColors.Window;
            this.recordsTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordsTb.Location = new System.Drawing.Point(297, 140);
            this.recordsTb.Name = "recordsTb";
            this.recordsTb.ReadOnly = true;
            this.recordsTb.Size = new System.Drawing.Size(51, 25);
            this.recordsTb.TabIndex = 3;
            this.recordsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordsTb.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            this.recordsTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // minEntryTb
            // 
            this.minEntryTb.AcceptsTab = true;
            this.minEntryTb.BackColor = System.Drawing.SystemColors.Window;
            this.minEntryTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minEntryTb.Location = new System.Drawing.Point(297, 180);
            this.minEntryTb.Name = "minEntryTb";
            this.minEntryTb.ReadOnly = true;
            this.minEntryTb.Size = new System.Drawing.Size(51, 25);
            this.minEntryTb.TabIndex = 4;
            this.minEntryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minEntryTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // maxEntryTb
            // 
            this.maxEntryTb.AcceptsTab = true;
            this.maxEntryTb.BackColor = System.Drawing.SystemColors.Window;
            this.maxEntryTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxEntryTb.Location = new System.Drawing.Point(297, 220);
            this.maxEntryTb.Name = "maxEntryTb";
            this.maxEntryTb.ReadOnly = true;
            this.maxEntryTb.Size = new System.Drawing.Size(51, 25);
            this.maxEntryTb.TabIndex = 5;
            this.maxEntryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxEntryTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // avgEntryTb
            // 
            this.avgEntryTb.AcceptsTab = true;
            this.avgEntryTb.BackColor = System.Drawing.SystemColors.Window;
            this.avgEntryTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgEntryTb.Location = new System.Drawing.Point(297, 260);
            this.avgEntryTb.Name = "avgEntryTb";
            this.avgEntryTb.ReadOnly = true;
            this.avgEntryTb.Size = new System.Drawing.Size(51, 25);
            this.avgEntryTb.TabIndex = 6;
            this.avgEntryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.avgEntryTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // minInterTb
            // 
            this.minInterTb.AcceptsTab = true;
            this.minInterTb.BackColor = System.Drawing.SystemColors.Window;
            this.minInterTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minInterTb.Location = new System.Drawing.Point(297, 300);
            this.minInterTb.Name = "minInterTb";
            this.minInterTb.ReadOnly = true;
            this.minInterTb.Size = new System.Drawing.Size(52, 25);
            this.minInterTb.TabIndex = 7;
            this.minInterTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minInterTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // maxInterTb
            // 
            this.maxInterTb.AcceptsTab = true;
            this.maxInterTb.BackColor = System.Drawing.SystemColors.Window;
            this.maxInterTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxInterTb.Location = new System.Drawing.Point(298, 340);
            this.maxInterTb.Name = "maxInterTb";
            this.maxInterTb.ReadOnly = true;
            this.maxInterTb.Size = new System.Drawing.Size(51, 25);
            this.maxInterTb.TabIndex = 8;
            this.maxInterTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxInterTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // avgInterTb
            // 
            this.avgInterTb.AcceptsTab = true;
            this.avgInterTb.BackColor = System.Drawing.SystemColors.Window;
            this.avgInterTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgInterTb.Location = new System.Drawing.Point(298, 380);
            this.avgInterTb.Name = "avgInterTb";
            this.avgInterTb.ReadOnly = true;
            this.avgInterTb.Size = new System.Drawing.Size(51, 25);
            this.avgInterTb.TabIndex = 9;
            this.avgInterTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.avgInterTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // totalTimeTb
            // 
            this.totalTimeTb.AcceptsTab = true;
            this.totalTimeTb.BackColor = System.Drawing.SystemColors.Window;
            this.totalTimeTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTimeTb.Location = new System.Drawing.Point(297, 420);
            this.totalTimeTb.Name = "totalTimeTb";
            this.totalTimeTb.ReadOnly = true;
            this.totalTimeTb.Size = new System.Drawing.Size(51, 25);
            this.totalTimeTb.TabIndex = 10;
            this.totalTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalTimeTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // backspaceTb
            // 
            this.backspaceTb.AcceptsTab = true;
            this.backspaceTb.BackColor = System.Drawing.SystemColors.Window;
            this.backspaceTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backspaceTb.Location = new System.Drawing.Point(298, 460);
            this.backspaceTb.Name = "backspaceTb";
            this.backspaceTb.ReadOnly = true;
            this.backspaceTb.Size = new System.Drawing.Size(52, 25);
            this.backspaceTb.TabIndex = 11;
            this.backspaceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backspaceTb.GotFocus += new System.EventHandler(this.Tb_GotFocus);
            // 
            // recordsLabel
            // 
            this.recordsLabel.AutoSize = true;
            this.recordsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordsLabel.Location = new System.Drawing.Point(151, 143);
            this.recordsLabel.Name = "recordsLabel";
            this.recordsLabel.Size = new System.Drawing.Size(124, 17);
            this.recordsLabel.TabIndex = 9;
            this.recordsLabel.Text = "Number of Records";
            // 
            // minEntryLabel
            // 
            this.minEntryLabel.AutoSize = true;
            this.minEntryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minEntryLabel.Location = new System.Drawing.Point(148, 183);
            this.minEntryLabel.Name = "minEntryLabel";
            this.minEntryLabel.Size = new System.Drawing.Size(127, 17);
            this.minEntryLabel.TabIndex = 10;
            this.minEntryLabel.Text = "Minimum Entry Time";
            // 
            // maxEntryLabel
            // 
            this.maxEntryLabel.AutoSize = true;
            this.maxEntryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxEntryLabel.Location = new System.Drawing.Point(145, 223);
            this.maxEntryLabel.Name = "maxEntryLabel";
            this.maxEntryLabel.Size = new System.Drawing.Size(130, 17);
            this.maxEntryLabel.TabIndex = 11;
            this.maxEntryLabel.Text = "Maximum Entry Time";
            // 
            // avgEntryLabel
            // 
            this.avgEntryLabel.AutoSize = true;
            this.avgEntryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgEntryLabel.Location = new System.Drawing.Point(154, 263);
            this.avgEntryLabel.Name = "avgEntryLabel";
            this.avgEntryLabel.Size = new System.Drawing.Size(121, 17);
            this.avgEntryLabel.TabIndex = 12;
            this.avgEntryLabel.Text = "Average Entry Time";
            // 
            // minInterLabel
            // 
            this.minInterLabel.AutoSize = true;
            this.minInterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minInterLabel.Location = new System.Drawing.Point(104, 303);
            this.minInterLabel.Name = "minInterLabel";
            this.minInterLabel.Size = new System.Drawing.Size(171, 17);
            this.minInterLabel.TabIndex = 13;
            this.minInterLabel.Text = "Minimum Inter-Record Time";
            // 
            // maxInterLabel
            // 
            this.maxInterLabel.AutoSize = true;
            this.maxInterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxInterLabel.Location = new System.Drawing.Point(101, 343);
            this.maxInterLabel.Name = "maxInterLabel";
            this.maxInterLabel.Size = new System.Drawing.Size(174, 17);
            this.maxInterLabel.TabIndex = 14;
            this.maxInterLabel.Text = "Maximum Inter-Record Time";
            // 
            // avgInterLabel
            // 
            this.avgInterLabel.AutoSize = true;
            this.avgInterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgInterLabel.Location = new System.Drawing.Point(110, 383);
            this.avgInterLabel.Name = "avgInterLabel";
            this.avgInterLabel.Size = new System.Drawing.Size(165, 17);
            this.avgInterLabel.TabIndex = 16;
            this.avgInterLabel.Text = "Average Inter-Record Time";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTimeLabel.Location = new System.Drawing.Point(207, 423);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(68, 17);
            this.totalTimeLabel.TabIndex = 17;
            this.totalTimeLabel.Text = "Total Time";
            // 
            // fileBrowseTb
            // 
            this.fileBrowseTb.BackColor = System.Drawing.SystemColors.Window;
            this.fileBrowseTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileBrowseTb.Location = new System.Drawing.Point(107, 26);
            this.fileBrowseTb.Name = "fileBrowseTb";
            this.fileBrowseTb.ReadOnly = true;
            this.fileBrowseTb.Size = new System.Drawing.Size(547, 25);
            this.fileBrowseTb.TabIndex = 18;
            this.fileBrowseTb.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Text Files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathLabel.Location = new System.Drawing.Point(38, 31);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(56, 17);
            this.filePathLabel.TabIndex = 19;
            this.filePathLabel.Text = "File Path";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBrowse.Location = new System.Drawing.Point(662, 25);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(98, 27);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            this.BtnBrowse.Enter += new System.EventHandler(this.BtnBrowse_Enter);
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAnalyze.Enabled = false;
            this.BtnAnalyze.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnalyze.Location = new System.Drawing.Point(107, 90);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(291, 33);
            this.BtnAnalyze.TabIndex = 2;
            this.BtnAnalyze.Text = "Analyse Data";
            this.BtnAnalyze.UseVisualStyleBackColor = false;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusBox.Location = new System.Drawing.Point(447, 140);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(313, 105);
            this.statusBox.TabIndex = 22;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "";
            // 
            // backspaceLabel
            // 
            this.backspaceLabel.AutoSize = true;
            this.backspaceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backspaceLabel.Location = new System.Drawing.Point(157, 463);
            this.backspaceLabel.Name = "backspaceLabel";
            this.backspaceLabel.Size = new System.Drawing.Size(118, 17);
            this.backspaceLabel.TabIndex = 23;
            this.backspaceLabel.Text = "Backspace Counter";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(447, 260);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 33);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save Data";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.Enter += new System.EventHandler(this.BtnSave_Enter);
            this.BtnSave.MouseHover += new System.EventHandler(this.BtnSave_Enter);
            // 
            // labelStatusBox
            // 
            this.labelStatusBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatusBox.Location = new System.Drawing.Point(447, 90);
            this.labelStatusBox.Name = "labelStatusBox";
            this.labelStatusBox.Size = new System.Drawing.Size(123, 34);
            this.labelStatusBox.TabIndex = 26;
            this.labelStatusBox.Text = "Instruction Box";
            this.labelStatusBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitLabel1
            // 
            this.unitLabel1.AutoSize = true;
            this.unitLabel1.Location = new System.Drawing.Point(354, 185);
            this.unitLabel1.Name = "unitLabel1";
            this.unitLabel1.Size = new System.Drawing.Size(44, 15);
            this.unitLabel1.TabIndex = 27;
            this.unitLabel1.Text = "MM:SS";
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Location = new System.Drawing.Point(354, 225);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(44, 15);
            this.unitLabel2.TabIndex = 28;
            this.unitLabel2.Text = "MM:SS";
            // 
            // unitLabel3
            // 
            this.unitLabel3.AutoSize = true;
            this.unitLabel3.Location = new System.Drawing.Point(354, 265);
            this.unitLabel3.Name = "unitLabel3";
            this.unitLabel3.Size = new System.Drawing.Size(44, 15);
            this.unitLabel3.TabIndex = 29;
            this.unitLabel3.Text = "MM:SS";
            // 
            // unitLabel4
            // 
            this.unitLabel4.AutoSize = true;
            this.unitLabel4.Location = new System.Drawing.Point(354, 305);
            this.unitLabel4.Name = "unitLabel4";
            this.unitLabel4.Size = new System.Drawing.Size(44, 15);
            this.unitLabel4.TabIndex = 30;
            this.unitLabel4.Text = "MM:SS";
            // 
            // unitLabel5
            // 
            this.unitLabel5.AutoSize = true;
            this.unitLabel5.Location = new System.Drawing.Point(354, 345);
            this.unitLabel5.Name = "unitLabel5";
            this.unitLabel5.Size = new System.Drawing.Size(44, 15);
            this.unitLabel5.TabIndex = 31;
            this.unitLabel5.Text = "MM:SS";
            // 
            // unitLabel6
            // 
            this.unitLabel6.AutoSize = true;
            this.unitLabel6.Location = new System.Drawing.Point(354, 385);
            this.unitLabel6.Name = "unitLabel6";
            this.unitLabel6.Size = new System.Drawing.Size(44, 15);
            this.unitLabel6.TabIndex = 32;
            this.unitLabel6.Text = "MM:SS";
            // 
            // unitLabel7
            // 
            this.unitLabel7.AutoSize = true;
            this.unitLabel7.Location = new System.Drawing.Point(354, 425);
            this.unitLabel7.Name = "unitLabel7";
            this.unitLabel7.Size = new System.Drawing.Size(44, 15);
            this.unitLabel7.TabIndex = 33;
            this.unitLabel7.Text = "MM:SS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.Controls.Add(this.unitLabel7);
            this.Controls.Add(this.unitLabel6);
            this.Controls.Add(this.unitLabel5);
            this.Controls.Add(this.unitLabel4);
            this.Controls.Add(this.unitLabel3);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.unitLabel1);
            this.Controls.Add(this.labelStatusBox);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.backspaceLabel);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.fileBrowseTb);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.avgInterLabel);
            this.Controls.Add(this.maxInterLabel);
            this.Controls.Add(this.minInterLabel);
            this.Controls.Add(this.avgEntryLabel);
            this.Controls.Add(this.maxEntryLabel);
            this.Controls.Add(this.minEntryLabel);
            this.Controls.Add(this.recordsLabel);
            this.Controls.Add(this.backspaceTb);
            this.Controls.Add(this.totalTimeTb);
            this.Controls.Add(this.avgInterTb);
            this.Controls.Add(this.maxInterTb);
            this.Controls.Add(this.minInterTb);
            this.Controls.Add(this.avgEntryTb);
            this.Controls.Add(this.maxEntryTb);
            this.Controls.Add(this.minEntryTb);
            this.Controls.Add(this.recordsTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 549);
            this.MinimumSize = new System.Drawing.Size(831, 549);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asg3-axs210204";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox recordsTb;
        private TextBox minEntryTb;
        private TextBox maxEntryTb;
        private TextBox avgEntryTb;
        private TextBox minInterTb;
        private TextBox maxInterTb;
        private TextBox avgInterTb;
        private TextBox totalTimeTb;
        private TextBox backspaceTb;
        private Label recordsLabel;
        private Label minEntryLabel;
        private Label maxEntryLabel;
        private Label avgEntryLabel;
        private Label minInterLabel;
        private Label maxInterLabel;
        private Label avgInterLabel;
        private Label totalTimeLabel;
        private TextBox fileBrowseTb;
        private OpenFileDialog openFileDialog;
        private Label filePathLabel;
        private Button BtnBrowse;
        private Button BtnAnalyze;
        private RichTextBox statusBox;
        private Label backspaceLabel;
        private Button BtnSave;
        private Label labelStatusBox;
        private Label unitLabel1;
        private Label unitLabel2;
        private Label unitLabel3;
        private Label unitLabel4;
        private Label unitLabel5;
        private Label unitLabel6;
        private Label unitLabel7;
    }
}