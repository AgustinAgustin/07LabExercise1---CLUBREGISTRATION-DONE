using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _07LabExercise1
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect = new SqlConnection(connectionString);
        private SqlCommand sqlCommand;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mj\\source\\repos\\07LabExercise1\\ClubDB.mdf;Integrated Security=True";
        public DataTable dataTable;
        public BindingSource bindingSource;

        public string _Firstname, _Lastname, _Middlename, _Gender, _Program;
        public int _Age;

        SqlConnection SC = new SqlConnection(connectionString);
        DataTable DT = new DataTable();
        BindingSource BS = new BindingSource();

        public bool DisplayList()
        {
            string ViewClubMembers = ("SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers");

            dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ViewClubMembers, SC);
            bindingSource = new BindingSource();
            dataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }
        public bool RegisterStudent(int ID, long StudentId, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                sqlConnect.Open();

                using (sqlCommand = new SqlCommand("INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect))
                {
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentId;
                    sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                    sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                    sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                    sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                    sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                    sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering student: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnect.Close();
            }
        }
    }
}
