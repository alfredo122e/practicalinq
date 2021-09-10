using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string fistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }

        //metodo  con la coleccion de datos
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent=1001, fistName="Fernando", lastName="Juárez", age=23, nationality="Salvadoreño"},
                new Student{idStudent=1002, fistName="Xiomara", lastName="Torres", age=25, nationality= "Colombiana"},
                new Student{idStudent=1003, fistName="Francisco", lastName="Argueta", age=29, nationality= "Español"},
                new Student{idStudent=1004, fistName="Luis", lastName="Velázquez", age=19, nationality= "Argentino"},
                new Student{idStudent=1005, fistName="Vanessa", lastName="Fuentes", age=20, nationality= "Costarricense"},
            };
            return students; //retornamos coleccion
        }
       
    }
}
