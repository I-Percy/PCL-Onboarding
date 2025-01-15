
namespace WindowsFormsApp1
{
  partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeptAbbv = new System.Windows.Forms.Label();
            this.DeptName = new System.Windows.Forms.Label();
            this.DeptNameIn = new System.Windows.Forms.TextBox();
            this.deptAbbrIn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddDeptBtn = new System.Windows.Forms.Button();
            this.DeleteDeptBtn = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.UpdateDeptBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.18041F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.81959F));
            this.tableLayoutPanel1.Controls.Add(this.DeptAbbv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeptName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeptNameIn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deptAbbrIn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.16484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.83517F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DeptAbbv
            // 
            this.DeptAbbv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeptAbbv.AutoSize = true;
            this.DeptAbbv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeptAbbv.Location = new System.Drawing.Point(75, 74);
            this.DeptAbbv.Name = "DeptAbbv";
            this.DeptAbbv.Size = new System.Drawing.Size(194, 78);
            this.DeptAbbv.TabIndex = 2;
            this.DeptAbbv.Text = "Department Abbrev.";
            this.DeptAbbv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeptName
            // 
            this.DeptName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeptName.AutoSize = true;
            this.DeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeptName.Location = new System.Drawing.Point(35, 10);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(234, 39);
            this.DeptName.TabIndex = 0;
            this.DeptName.Text = "* Department: ";
            this.DeptName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeptNameIn
            // 
            this.DeptNameIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeptNameIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeptNameIn.Location = new System.Drawing.Point(275, 7);
            this.DeptNameIn.Name = "DeptNameIn";
            this.DeptNameIn.Size = new System.Drawing.Size(385, 45);
            this.DeptNameIn.TabIndex = 1;
            // 
            // deptAbbrIn
            // 
            this.deptAbbrIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deptAbbrIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deptAbbrIn.Location = new System.Drawing.Point(275, 91);
            this.deptAbbrIn.Name = "deptAbbrIn";
            this.deptAbbrIn.Size = new System.Drawing.Size(385, 45);
            this.deptAbbrIn.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.AddDeptBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteDeptBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.UpdateDeptBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 283);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // AddDeptBtn
            // 
            this.AddDeptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddDeptBtn.Location = new System.Drawing.Point(3, 3);
            this.AddDeptBtn.Name = "AddDeptBtn";
            this.AddDeptBtn.Size = new System.Drawing.Size(247, 130);
            this.AddDeptBtn.TabIndex = 5;
            this.AddDeptBtn.Text = "Add Department";
            this.AddDeptBtn.UseVisualStyleBackColor = false;
            this.AddDeptBtn.Click += new System.EventHandler(this.AddDeptBtn_Click);
            // 
            // DeleteDeptBtn
            // 
            this.DeleteDeptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteDeptBtn.Location = new System.Drawing.Point(522, 3);
            this.DeleteDeptBtn.Name = "DeleteDeptBtn";
            this.DeleteDeptBtn.Size = new System.Drawing.Size(254, 130);
            this.DeleteDeptBtn.TabIndex = 12;
            this.DeleteDeptBtn.Text = "Delete Department";
            this.DeleteDeptBtn.UseVisualStyleBackColor = false;
            this.DeleteDeptBtn.Click += new System.EventHandler(this.DeleteDeptBtn_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Teal;
            this.BtnClear.Location = new System.Drawing.Point(256, 139);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(260, 144);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear All";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // UpdateDeptBtn
            // 
            this.UpdateDeptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateDeptBtn.Location = new System.Drawing.Point(256, 3);
            this.UpdateDeptBtn.Name = "UpdateDeptBtn";
            this.UpdateDeptBtn.Size = new System.Drawing.Size(260, 130);
            this.UpdateDeptBtn.TabIndex = 11;
            this.UpdateDeptBtn.Text = "Update Department";
            this.UpdateDeptBtn.UseVisualStyleBackColor = false;
            this.UpdateDeptBtn.Click += new System.EventHandler(this.UpdateDeptBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 820);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "DeptManager ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label DeptName;
    private System.Windows.Forms.TextBox DeptNameIn;
    private System.Windows.Forms.Label DeptAbbv;
    private System.Windows.Forms.TextBox deptAbbrIn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button AddDeptBtn;
    private System.Windows.Forms.Button DeleteDeptBtn;
    private System.Windows.Forms.Button UpdateDeptBtn;
    private System.Windows.Forms.Button BtnClear;
  }
}
