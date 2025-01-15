
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FNameIn = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LName = new System.Windows.Forms.Label();
            this.LNameIn = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PhoneNumIn = new System.Windows.Forms.MaskedTextBox();
            this.PhoneN = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmailIn = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ActiveCheck = new System.Windows.Forms.CheckBox();
            this.Active = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DeptList = new System.Windows.Forms.CheckedListBox();
            this.DeptSelect = new System.Windows.Forms.Label();
            this.DeptManagerShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNameIn
            // 
            this.FNameIn.CausesValidation = false;
            this.FNameIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FNameIn.Location = new System.Drawing.Point(277, 10);
            this.FNameIn.Name = "FNameIn";
            this.FNameIn.Size = new System.Drawing.Size(529, 50);
            this.FNameIn.TabIndex = 0;
            this.FNameIn.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FNameIn);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 65);
            this.panel1.TabIndex = 1;
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(3, 13);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(227, 39);
            this.FName.TabIndex = 1;
            this.FName.Text = "*First Name: ";
            this.FName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LName);
            this.panel2.Controls.Add(this.LNameIn);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 65);
            this.panel2.TabIndex = 2;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(4, 12);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(214, 39);
            this.LName.TabIndex = 1;
            this.LName.Text = "*Last Name:";
            this.LName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LNameIn
            // 
            this.LNameIn.CausesValidation = false;
            this.LNameIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LNameIn.Location = new System.Drawing.Point(277, 9);
            this.LNameIn.Name = "LNameIn";
            this.LNameIn.Size = new System.Drawing.Size(529, 50);
            this.LNameIn.TabIndex = 0;
            this.LNameIn.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PhoneNumIn);
            this.panel3.Controls.Add(this.PhoneN);
            this.panel3.Location = new System.Drawing.Point(3, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 65);
            this.panel3.TabIndex = 3;
            // 
            // PhoneNumIn
            // 
            this.PhoneNumIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhoneNumIn.Location = new System.Drawing.Point(277, 12);
            this.PhoneNumIn.Mask = "(999) 000-0000";
            this.PhoneNumIn.Name = "PhoneNumIn";
            this.PhoneNumIn.Size = new System.Drawing.Size(237, 45);
            this.PhoneNumIn.TabIndex = 4;
            // 
            // PhoneN
            // 
            this.PhoneN.AutoSize = true;
            this.PhoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneN.Location = new System.Drawing.Point(59, 15);
            this.PhoneN.Name = "PhoneN";
            this.PhoneN.Size = new System.Drawing.Size(171, 39);
            this.PhoneN.TabIndex = 1;
            this.PhoneN.Text = "Phone #: ";
            this.PhoneN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EmailIn);
            this.panel4.Controls.Add(this.Email);
            this.panel4.Location = new System.Drawing.Point(3, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 65);
            this.panel4.TabIndex = 5;
            // 
            // EmailIn
            // 
            this.EmailIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailIn.Location = new System.Drawing.Point(277, 9);
            this.EmailIn.Name = "EmailIn";
            this.EmailIn.Size = new System.Drawing.Size(529, 45);
            this.EmailIn.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(76, 12);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(154, 39);
            this.Email.TabIndex = 1;
            this.Email.Text = "*E-Mail: ";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubmitBtn.Location = new System.Drawing.Point(3, 3);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(294, 130);
            this.SubmitBtn.TabIndex = 5;
            this.SubmitBtn.Text = "Add User";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ActiveCheck);
            this.panel5.Controls.Add(this.Active);
            this.panel5.Location = new System.Drawing.Point(3, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 65);
            this.panel5.TabIndex = 2;
            // 
            // ActiveCheck
            // 
            this.ActiveCheck.AutoSize = true;
            this.ActiveCheck.Checked = true;
            this.ActiveCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ActiveCheck.Location = new System.Drawing.Point(277, 9);
            this.ActiveCheck.Name = "ActiveCheck";
            this.ActiveCheck.Size = new System.Drawing.Size(529, 43);
            this.ActiveCheck.TabIndex = 2;
            this.ActiveCheck.Text = "Yes (checked), No (unchecked)";
            this.ActiveCheck.UseVisualStyleBackColor = true;
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.Location = new System.Drawing.Point(94, 10);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(136, 39);
            this.Active.TabIndex = 1;
            this.Active.Text = "Active: ";
            this.Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StartDatePicker);
            this.panel6.Controls.Add(this.StartDate);
            this.panel6.Location = new System.Drawing.Point(3, 358);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(809, 65);
            this.panel6.TabIndex = 6;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartDatePicker.Checked = false;
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(277, 8);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(420, 45);
            this.StartDatePicker.TabIndex = 2;
            this.StartDatePicker.Value = new System.DateTime(2025, 1, 10, 0, 0, 0, 0);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(31, 8);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(199, 39);
            this.StartDate.TabIndex = 1;
            this.StartDate.Text = "Start Date: ";
            this.StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.EndDatePicker);
            this.panel7.Controls.Add(this.EndDate);
            this.panel7.Location = new System.Drawing.Point(3, 429);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(809, 65);
            this.panel7.TabIndex = 7;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EndDatePicker.Checked = false;
            this.EndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(277, 8);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(420, 45);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Value = new System.DateTime(9996, 12, 31, 0, 0, 0, 0);
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(43, 13);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(187, 39);
            this.EndDate.TabIndex = 1;
            this.EndDate.Text = "End Date: ";
            this.EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 515);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Teal;
            this.BtnClear.Location = new System.Drawing.Point(303, 139);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(291, 133);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear All";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "(* Indicates Req\'d Field to Add User)";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateBtn.Location = new System.Drawing.Point(303, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(291, 130);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update User";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Location = new System.Drawing.Point(600, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(276, 130);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Delete/update a user by entering email.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.SubmitBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UpdateBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClear, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 957);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 272);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DeptList);
            this.panel8.Controls.Add(this.DeptSelect);
            this.panel8.Location = new System.Drawing.Point(12, 603);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(923, 193);
            this.panel8.TabIndex = 15;
            // 
            // DeptList
            // 
            this.DeptList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeptList.FormattingEnabled = true;
            this.DeptList.Location = new System.Drawing.Point(280, 10);
            this.DeptList.Name = "DeptList";
            this.DeptList.Size = new System.Drawing.Size(532, 172);
            this.DeptList.TabIndex = 17;
            this.DeptList.SelectedIndexChanged += new System.EventHandler(this.DeptList_SelectedIndexChanged);
            // 
            // DeptSelect
            // 
            this.DeptSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeptSelect.AutoSize = true;
            this.DeptSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptSelect.Location = new System.Drawing.Point(19, 77);
            this.DeptSelect.Name = "DeptSelect";
            this.DeptSelect.Size = new System.Drawing.Size(214, 39);
            this.DeptSelect.TabIndex = 1;
            this.DeptSelect.Text = "Department:";
            this.DeptSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeptManagerShow
            // 
            this.DeptManagerShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeptManagerShow.Location = new System.Drawing.Point(29, 802);
            this.DeptManagerShow.Name = "DeptManagerShow";
            this.DeptManagerShow.Size = new System.Drawing.Size(294, 130);
            this.DeptManagerShow.TabIndex = 16;
            this.DeptManagerShow.Text = "Department Manager";
            this.DeptManagerShow.UseVisualStyleBackColor = false;
            this.DeptManagerShow.Click += new System.EventHandler(this.DeptManagerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 1288);
            this.Controls.Add(this.DeptManagerShow);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Onboarding - Isaac Percy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.RichTextBox FNameIn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label FName;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label LName;
    private System.Windows.Forms.RichTextBox LNameIn;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label PhoneN;
    private System.Windows.Forms.MaskedTextBox PhoneNumIn;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.MaskedTextBox EmailIn;
    private System.Windows.Forms.Label Email;
    private System.Windows.Forms.Button SubmitBtn;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.CheckBox ActiveCheck;
    private System.Windows.Forms.Label Active;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.DateTimePicker StartDatePicker;
    private System.Windows.Forms.Label StartDate;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.DateTimePicker EndDatePicker;
    private System.Windows.Forms.Label EndDate;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button BtnClear;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button UpdateBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.Label DeptSelect;
    private System.Windows.Forms.Button DeptManagerShow;
    private System.Windows.Forms.CheckedListBox DeptList;
  }
}

