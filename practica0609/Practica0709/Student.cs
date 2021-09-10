using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0709
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int Age { get; set; }
        public string gender { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student { idStudent = 1001, firstname = "Ana", lastname = "Flores", Age = 22, gender = "Femenino"},
                new Student { idStudent = 1002, firstname = "Sofia", lastname = "Martinez", Age = 23, gender = "Femenino "},
                new Student { idStudent = 1003, firstname = "Pedro", lastname = "Canales", Age = 24, gender = "Masculino"},
                new Student { idStudent = 1004, firstname = "Carlos", lastname = "Gomes", Age = 25, gender = "Masculino"},
                new Student { idStudent = 1005, firstname = "Daniel", lastname = "Miranda", Age = 26, gender = "Masculino"  },
                new Student { idStudent = 1006, firstname = "Gisela", lastname = "Espinoza", Age = 20, gender = "Femenino"},
                new Student { idStudent = 1007, firstname = "Eli", lastname = "Gonzales", Age = 24, gender = "Masculino" },
            };
            return students;
        }
    }
}
            
        
    

