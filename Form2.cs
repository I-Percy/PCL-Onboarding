using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void InsertDept(string deptName, string deptAbbr)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string query = "INSERT INTO dbo.dept_table (department_name, department_abbr) VALUES (@department_name, @department_abbr)";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@department_name", deptName);
        command.Parameters.AddWithValue("@department_abbr", deptAbbr);

        try
        {
          connection.Open();
          int result = command.ExecuteNonQuery();

          if (result < 0)
          {
            MessageBox.Show("Error inserting into DB");
          }
          else
          {
            MessageBox.Show("Department: " + deptName + " successfully added.");
          }

        }
        catch (SqlException ex) when (ex.Number == 2627)
        {
          MessageBox.Show("Department name or abbreviation is already in use!");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex);
        }
      }
    }

    public void deleteDept(string deptName)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string query = "DELETE FROM dbo.dept_table WHERE department_name = @department_name";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@department_name", deptName);

        try
        {
          connection.Open();
          int result = command.ExecuteNonQuery();

          if (result < 0)
          {
            MessageBox.Show("Error inserting into DB");
          }
          else
          {
            MessageBox.Show("Department: " + deptName+ " sucessfully deleted.");
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex);
          Console.WriteLine("Error: " + ex);
        }
      }
    }

    private void AddDeptBtn_Click(object sender, EventArgs e)
    {

      if (string.IsNullOrEmpty(DeptNameIn.Text))
      {
        MessageBox.Show("Error: Must include a department name.");
        return;
      }
      string DI = DeptNameIn.Text;
      string DA = deptAbbrIn.Text;
      InsertDept(DI, DA);
    }

    private void UpdateDeptBtn_Click(object sender, EventArgs e)
    {

    }

    private void DeleteDeptBtn_Click(object sender, EventArgs e)
    {

      if (string.IsNullOrEmpty(DeptNameIn.Text))
      {
        MessageBox.Show("Must include a department name.");
        return;
      }

      string dName = DeptNameIn.Text;
      deleteDept(dName);

    }

    private void BtnClear_Click(object sender, EventArgs e)
    {

    }
  }
}
