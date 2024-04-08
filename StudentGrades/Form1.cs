using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentGrades.frmStudentGrades;

namespace StudentGrades
{
    public partial class frmStudentGrades : Form
    {

        private List<Student> students;
        public frmStudentGrades()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            students = StudentManager.LoadData();
        }

            private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtInput.Text.Trim();
            Student student = students.FirstOrDefault(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (student != null)
            {
                double avgLabGrade = student.GetAverageLabGrade();
                double avgTestGrade = student.GetAverageTestGrade();
                double overallGrade = student.GetOverallGrade();

                lblOutput.Text = $"Average Lab Grade: {avgLabGrade:F2}\n" +
                                 $"Average Test Grade: {avgTestGrade:F2}\n" +
                                 $"Overall Grade: {overallGrade:F2}";
            }
            else
            {
                lblOutput.Text = $"{searchName} not found";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblOutput.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public class Student
        {
            public string Name { get; set; }
            public int TestGrade { get; set; }
            public int LabGrade { get; set; }

            public Student(string name, int testGrade, int labGrade)
            {
                Name = name;
                TestGrade = testGrade;
                LabGrade = labGrade;
            }

            public double GetAverageLabGrade()
            {
                return LabGrade;
            }

            public double GetAverageTestGrade()
            {
                return TestGrade;
            }

            public double GetOverallGrade()
            {
                return 0.4 * LabGrade + 0.6 * TestGrade;
            }
        }

    }
}
