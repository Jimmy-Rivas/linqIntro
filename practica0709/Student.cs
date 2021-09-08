using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica0709
{
    class student
    {
        public int idStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    
        public static List<student> Getstudent()
        {
            List<student> students = new List<student>
            {
                new student{idStudent=1001, FirstName = "Ana", LastName = "Flores",Age = 22},
                new student{idStudent=1002, FirstName = "Sofia", LastName = "Lopez",Age = 18},
                new student{idStudent=1003, FirstName = "Mario", LastName = "Gomes",Age = 28},
                new student{idStudent=1004, FirstName = "Carlos", LastName = "Bonilla",Age = 30},
                new student{idStudent=1005, FirstName = "Daniel", LastName = "Miranda",Age = 19},
                new student{idStudent=1006, FirstName = "Pablo", LastName = "Mendez",Age = 27},
                new student{idStudent=1007, FirstName = "Gisela", LastName = "Espinoza",Age = 20},

            };

            return students;
               

            
        }

        
    }
}
