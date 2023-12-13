using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LabExercise1
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            Sqlconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mj\\source\\repos\\07LabExercise1\\ClubDB.mdf;Integrated Security=True";
            connection = new SqlConnection(Sqlconnection);
            string query = "SELECT  * FROM ClubMembers";
            connection.ConnectionString = Sqlconnection;
            using (connection) {
                if(connection.State != ConnectionState.Open)
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@ID", Convert.ToInt64(CbRegistredStudentID.SelectedItem));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        CbRegistredStudentID.Items.Add(reader.GetInt64(1));
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string UpdateQue = "UPDATE ClubMembers SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, Age = @age, Gender = @gender, Program = @program WHERE StudentId = @ID";

            connection.ConnectionString = Sqlconnection;
            using (connection) {
            if(connection.State != ConnectionState.Open)
                    connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQue, connection)) {
                    command.Parameters.AddWithValue("@ID", StudentId);
                    command.Parameters.AddWithValue("@firstName", TBFirstname.Text);
                    command.Parameters.AddWithValue("@middleName", TBmiddleName.Text);
                    command.Parameters.AddWithValue("@lastName", TBlastname.Text);
                    command.Parameters.AddWithValue("@age", Convert.ToInt32(TBAge.Text));
                    command.Parameters.AddWithValue("@gender", CBGender.Text);
                    command.Parameters.AddWithValue("@program", cbProgram.Text);

                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }

            MessageBox.Show("Success Updating!");
            this.Close();
            
        }
        private long StudentId;
        SqlConnection connection;

        string Sqlconnection;
        private void CbRegistredStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ClubMembers Where StudentId = @ID";
            connection.ConnectionString = Sqlconnection;

            using (connection)
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                using (SqlCommand comm = new SqlCommand(query, connection))
                {

                    comm.Parameters.AddWithValue("@ID", Convert.ToInt64(CbRegistredStudentID.SelectedItem));
                    SqlDataReader reader = comm.ExecuteReader();

                    if (reader.Read())
                    {

                        StudentId = reader.GetInt64(1);
                        FirstName = reader.GetString(2);
                        MiddleName = reader.GetString(3);
                        LastName = reader.GetString(4);
                        Age = reader.GetInt32(5);
                        Gender = reader.GetString(6);
                        Program = reader.GetString(7);

                        FillData();
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        void FillData() {
            CbRegistredStudentID.Text = StudentId.ToString();
            TBFirstname.Text = FirstName;
            TBmiddleName.Text = MiddleName;
            TBlastname.Text = LastName;
            TBAge.Text = Age.ToString();
            CBGender.Text = Gender;
            cbProgram.Text = Program;
        }
        

    }
}
