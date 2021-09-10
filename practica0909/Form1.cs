using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica0909
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            
        }

        private void btaGetName_Click(object sender, EventArgs e)
        {
            //llamado al método selectName
            selectName();
        }

        //MÉTODO PARA OBTENER NOMBRES DE LA COLECCIÓN
        private void selectName()
        {
            lstName.Items.Clear();
            List<string> query = (
                from Student in Student.GetStudents()
                select Student.fistName
                ).ToList();

            //recorrer lista y llenar lstNames
            foreach (var name in query)
            {
                //llenar lstnames
                lstName.Items.Add(name);
            }
        }

        private void btaBorrar_Click(object sender, EventArgs e)
        {
            lstName.Items.Clear();
        }

        private void btaGetData_Click(object sender, EventArgs e)
        {
            //agregar columnas al DataGridView
            dgData.Columns.Add("idStudent", "CÓDIGO");
            dgData.Columns.Add("fistnama", "NOMBRE");
            dgData.Columns.Add("lastname", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("nationality", "NACIONALIDAD");

            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.fistName, student.lastName,
                    student.age, student.nationality);
            }    

        }

        //metodo para consultar todos los datos de la coleccion

        private List<Student>  selectAllData()
        {

            
            List<Student> query = (
                from Student in Student.GetStudents()
                select new Student()
                {
                    idStudent = Student.idStudent,
                    fistName = Student.fistName,
                    lastName = Student.lastName,
                    age = Student.age,
                    nationality = Student.nationality
                }
                ).ToList();
            return query;
        }
    }

}
