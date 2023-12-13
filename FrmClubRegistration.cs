using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LabExercise1
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            //wala lang to
        }

        private void btnDeleteRows_Click(object sender, EventArgs e)
        {
            //wala lang to
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updMem = new FrmUpdateMember();
            updMem.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
        if (long.TryParse(TBStudentID.Text, out long studentId) &&
       int.TryParse(TBAge.Text, out int age))
            {
                StudentId = studentId;
                LastName = TBLastName.Text;
                FirstName = TBFirstName.Text;
                MiddleName = TBMiddleName.Text;
                Age = age;
                Gender = CBGender.Text;
                Program = CBProgram.Text;
                ID = RegistrationID();
                clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
                RefreshListOfMembers();
                clearText();
            }
            else
            {
                MessageBox.Show("Invalid input for Student ID or Age.");
            }
            
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Refresh Button
            RefreshListOfMembers();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfMembers();
        }
        public void RefreshListOfMembers()
        {
            clubRegistrationQuery.DisplayList();
            DataGridView.DataSource = clubRegistrationQuery.bindingSource;
        }
        public int RegistrationID() {
            count++;
            return count;
        }
        void clearText() {
            TBFirstName.Text = "";
            TBMiddleName.Text = "";
            TBLastName.Text = "";
            TBAge.Text = "";
            CBGender.Text = "";
            CBProgram.Text = "";
            TBStudentID.Text = "";
        }
    }
}
