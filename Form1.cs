using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDepartments();
        }


    /*
     * Parameters for connecting to and inserting into the DB 
     */
    public void insertToDB(string firstN, string lastN, string email, int? phoneNum, bool isActive, DateTime startDay, DateTime endDay, object department)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string query = "INSERT INTO dbo.users_table (first_name, last_name, phone_number, email, active, start_date, end_date, department) VALUES (@first_name, @last_name, @phone_number, @email, @active, @start_date, @end_date, @department)";


      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@first_name", firstN);
        command.Parameters.AddWithValue("@last_name", lastN);
        command.Parameters.AddWithValue("@phone_number", phoneNum.HasValue ? (object)phoneNum.Value : DBNull.Value);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@active", isActive);
        command.Parameters.AddWithValue("@start_date", startDay);
        command.Parameters.AddWithValue("@end_date", endDay);
        command.Parameters.AddWithValue("@department", department ?? DBNull.Value);

        try
        {
          connection.Open();
          int result = command.ExecuteNonQuery();

          if(result < 0)
          {
            MessageBox.Show("Error inserting into DB");
          }
          else
          {
            MessageBox.Show("User: " + email + " successfully added.");
            //saveUserDepartments(email);
          }

        }

        //Handle already added emails - only unique ones allowed 
        catch (SqlException ex) when (ex.Number == 2627)
        {
          MessageBox.Show("Email is already in use!");
        }

        catch(Exception ex)
        {
          MessageBox.Show("Error: " + ex);
        }
      }
    }

    /*
     * Update entry in DB
     */
    public void updateDB(string firstN, string lastN, string email, int? phoneNum, bool isActive, DateTime? startDay, DateTime? endDay, object department)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string BASEquery = "UPDATE dbo.users_table SET ";


      List<string> updateFields = new List<string>();
      List<SqlParameter> parameters = new List<SqlParameter>();

      using (SqlConnection connection = new SqlConnection(connectionString))
      {

        connection.Open();

        // Get curr values in table
        string SELquery = "SELECT first_name, last_name, email, phone_number, active, start_date, end_date, department FROM dbo.users_table WHERE email = @email";

        SqlCommand SELcommand = new SqlCommand(SELquery, connection);
        SELcommand.Parameters.AddWithValue("@email", email);

        SqlDataReader reader = SELcommand.ExecuteReader();

        if (reader.Read())
        {
          string currentFirstN = reader["first_name"].ToString();
          string currentLastN = reader["last_name"].ToString();
          int? currentPhoneNum = reader["phone_number"] as int?;
          bool currentIsActive = (bool)reader["active"];
          DateTime? currentStartDay = reader["start_date"] as DateTime?;
          DateTime? currentEndDay = reader["end_date"] as DateTime?;
          object currentDepartment = reader["department"];

          reader.Close();

          if (!string.IsNullOrEmpty(firstN) && firstN != currentFirstN)
          {
            updateFields.Add("first_name = @first_name");
            parameters.Add(new SqlParameter("@first_name", firstN));
          }

          if (!string.IsNullOrEmpty(lastN) && lastN != currentLastN)
          {
            updateFields.Add("last_name = @last_name");
            parameters.Add(new SqlParameter("@last_name", lastN));
          }

          if (phoneNum.HasValue && phoneNum != currentPhoneNum)
          {
            updateFields.Add("phone_number = @phone_number");
            parameters.Add(new SqlParameter("@phone_number", phoneNum));
          }

          if (isActive != currentIsActive)
          {
            updateFields.Add("active = @active");
            parameters.Add(new SqlParameter("@active", isActive));
          }

          if (startDay.HasValue && startDay != currentStartDay)
          {
            updateFields.Add("start_date = @start_date");
            parameters.Add(new SqlParameter("@start_date", startDay));
          }

          if (endDay.HasValue && endDay != currentEndDay)
         {
            updateFields.Add("end_date = @end_date");
            parameters.Add(new SqlParameter("@end_date", endDay));
          }

          if (department != null && department != currentDepartment)
          {
            updateFields.Add("department = @department");
            parameters.Add(new SqlParameter("@department", department));
          }


          if (updateFields.Count > 0)
          {
            string UPDquery = BASEquery + string.Join(", ", updateFields) + " WHERE email = @email";
            parameters.Add(new SqlParameter("@email", email));

            SqlCommand command = new SqlCommand(UPDquery, connection);
            command.Parameters.AddRange(parameters.ToArray());

            try
            {
              int result = command.ExecuteNonQuery();

              if (result < 0)
              {
                MessageBox.Show("Eror uploading data to DB");
              }
              else
              {
                MessageBox.Show("User " + email + " successfully updated");
              }
            }
            catch (Exception ex)
            {
              MessageBox.Show("Error: " + ex.Message);
              Console.WriteLine("Error: " + ex);
            }
          }
          else
          {
            MessageBox.Show("No changes detected for user " + email);
          }
        }
        else
        {
          MessageBox.Show("User not found");
        }
      }
    }


    /*
     * Delete an entry from the DB
     * 
     * TODO: Currently using email as a param since it's unique and should only be known to the user, unlike ID. 
     */
    public void deleteFromDB(string email)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string query = "DELETE FROM dbo.users_table WHERE email = @email";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@email", email);

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
            MessageBox.Show("User: " + email + " sucessfully deleted.");
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex);
          Console.WriteLine("Error: " + ex);
        }
      }
    }


    /*
     * Note: Taken from C# docs example and modified for use here. 
     * Link to original: https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-strip-invalid-characters-from-a-string
     */
    static string CleanInput(string strIn)
    {
      // Replace invalid characters with empty strings.
      try
      {
        return Regex.Replace(strIn, @"[^\w]", "",
                             RegexOptions.None, TimeSpan.FromSeconds(1.5));
      }
      // If we timeout when replacing invalid characters, we should return Empty.
      catch (RegexMatchTimeoutException)
      {
        return String.Empty;
      }
    }

    /*
     * Submit button
     * Submit the users info to the DB
     * 
     * Constraints: First name, last name, and email can not be empty. 
     */
    private void submitBtn_Click(object sender, EventArgs e)
    {

      if (FNameIn.Text.Trim().Length == 0)
      {
        MessageBox.Show("Please enter a first name");
        return;
      }

      if (LNameIn.Text.Trim().Length == 0)
      {
        MessageBox.Show("Please enter a last name.");
        return;
      }

      // Check if email follows the format of *@*.*
      string email = EmailIn.Text;
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

      if (!Regex.IsMatch(email, pattern))
      {
        MessageBox.Show("Please enter a valid email address.");
        return;
      }

      // Sanitize inputs for first/last name and phone number.
      // Prevents unnecessary chars from being entered into db. 
      string FN = CleanInput(FNameIn.Text);
      string LN = CleanInput(LNameIn.Text);
      string PN = CleanInput(PhoneNumIn.Text);
      string EM = EmailIn.Text;
      bool CH = ActiveCheck.Checked;
      DateTime SD = StartDatePicker.Value;
      DateTime ED = EndDatePicker.Value;
      object DP = DeptList.SelectedItem;

      int? CPN = null;

      if (!string.IsNullOrEmpty(PN) && int.TryParse(PN, out int parsedPN))
      {
        CPN = parsedPN;
      }

      //SQL additions here
      insertToDB(FN, LN, EM, CPN, CH, SD, ED, DP);
    }


    /*
     * Clear button 
     * Clears the entries back to default.
     * 
     * TODO: Add this after submit button clicked?
     */
    private void BtnClear_Click(object sender, EventArgs e)
    {
      FNameIn.Text = null;
      LNameIn.Text = null;
      EmailIn.Text = null;
      ActiveCheck.Checked = true;
      EndDatePicker.Value = new DateTime(9996, 12, 31, 0, 0, 0, 0);
    }


    /*
     * Update button
     * Update a user's info based on email provided
     * 
     * NOTE: EMail is immutable. 
     */
    private void UpdateBtn_Click(object sender, EventArgs e)
    {
      // CHeck if email follows the format of *@*.*
      string email = EmailIn.Text;
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

      if (!Regex.IsMatch(email, pattern))
      {
        MessageBox.Show("Please enter a valid email address.");
        return;
      }

      // Sanitize inputs for first/last name and phone number.
      // Prevents unnecessary chars from being entered into db. 
      string FN = CleanInput(FNameIn.Text);
      string LN = CleanInput(LNameIn.Text);
      string PN = CleanInput(PhoneNumIn.Text);
      string EM = EmailIn.Text;
      bool CH = ActiveCheck.Checked;
      DateTime SD = StartDatePicker.Value;
      DateTime ED = EndDatePicker.Value;
      object DP = DeptList.SelectedItem;

      int? CPN = null;

      if (!string.IsNullOrEmpty(PN) && int.TryParse(PN, out int parsedPN))
      {
        CPN = parsedPN;
      }
      //int CPN = Convert.ToInt32(PN);

      updateDB(FN, LN, EM, CPN, CH, SD, ED, DP);
    }


    /*
     * Delete button
     * Delete a user from the DB based on provided email. 
     */
    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      // Check if email follows the format of *@*.*
      string email = EmailIn.Text;
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

      if (!Regex.IsMatch(email, pattern))
      {
        MessageBox.Show("Please enter a valid email address.");
        return;
      }

      deleteFromDB(EmailIn.Text);
    }


    /*
     *  TODO: May want to move these two functions into Form2 
     *        So they don't get overwritten when updating the users...
     *        Check with Shiney what she thinks... 
     */
    private void DeptManagerBtn_Click(object sender, EventArgs e)
    {
      //this.Hide();
      var m = new Form2();
      m.Show();
    }

    private void loadDepartments()
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string query = "SELECT department_name FROM dept_table";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

        DeptList.DataSource = dataTable;
        DeptList.DisplayMember = "department_name";
      }
    }

    /*
    private int getUserID(string email)
    {
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";
      string getID = "SELECT id FROM users_table WHERE email = @email";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(getID, connection);
        connection.Open();
        object result = command.ExecuteScalar(); //Returns first column of first row in result (this case: ID)
        return Convert.ToInt32(result);
      }
    }


    private void saveUserDepartments(string email)
    {

      int userID = getUserID(email);
      string connectionString = "Server=29J50542\\SQLEXPRESS01;Database=MyDatabase;Trusted_Connection=True;";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        connection.Open();

        foreach(var item in DeptList.CheckedItems)
        {
          DataRowView row = item as DataRowView;
          Console.WriteLine("Row: " + row);
        }
      }
    }
    */

    private void DeptList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
