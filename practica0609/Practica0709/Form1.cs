using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0709
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataDg.Columns.Add("idStudent", "CODIGO");
            DataDg.Columns.Add("firstname", "NOMBRE");
            DataDg.Columns.Add("lastname", "APELLIDO");
            DataDg.Columns.Add("Age", "EDAD");
            DataDg.Columns.Add("gender", "Genero");
            foreach (var student in selectAllData ())
            {
                DataDg.Rows.Add(student.idStudent, student.firstname, student.lastname, student.Age, student.gender );
                  
            }
        }
        private List<Student> selectAllData()
        {
            List<Student> result = (
                 from student in Student.GetStudents()
                 select new Student()
                 {
                     idStudent = student.idStudent,
                     firstname = student.firstname,
                     lastname = student.lastname ,
                     Age = student.Age,
                     gender = student.gender 

                     
                 }
               ).ToList();
            return result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
