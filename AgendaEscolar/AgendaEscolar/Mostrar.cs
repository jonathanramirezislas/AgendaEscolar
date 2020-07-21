using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaEscolar
{
    public partial class Mostrar : Form
    {
        DataSet dsResultados = new DataSet();
        Class_BaseDatos obj_Agenda = new Class_BaseDatos();
        
        public Mostrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                //seleccioname todo de la tabla clientes donde en la columna nombre cliete pude ser el que yo te mande 
                string cmd = "Select * FROM AgendaAlumnos  WHERE No_Control LIKE ('%" + textBox1.Text + "%')";

                ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos  WHERE Id_Carrera LIKE ('%" + CarreracomboBox.SelectedValue + "%')");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {

            dsResultados = obj_Agenda.CargaDatos("Select * From Cat_Carreras Order By NombreCarrera");
            CarreracomboBox.DataSource = dsResultados.Tables["Carreras"];
            CarreracomboBox.DisplayMember = dsResultados.Tables["Carreras"].Columns["NombreCarrera"].ToString();
            CarreracomboBox.ValueMember = "Id_Carrera";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
              

                ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos  WHERE No_Control LIKE ('%" + textBox1.Text + "%')");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                

                ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }

        }



    }
}
