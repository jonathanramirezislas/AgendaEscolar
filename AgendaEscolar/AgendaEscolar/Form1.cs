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
    public partial class agendaForm : Form
    {
        string MarcadeAgua = "";
        int posicion = 0;
        DataSet dsResultados = new DataSet();
       
       
        Class_BaseDatos obj_Agenda = new Class_BaseDatos();
       
        public agendaForm()
        {
            InitializeComponent();
        }

        private void agendaForm_Load(object sender, EventArgs e)
        {

            dsResultados = obj_Agenda.CargaDatos("Select * From Cat_Carreras Order By NombreCarrera");
            CarreracomboBox.DataSource = dsResultados.Tables["Carreras"];
            CarreracomboBox.DisplayMember = dsResultados.Tables["Carreras"].Columns["NombreCarrera"].ToString();
            CarreracomboBox.ValueMember = "Id_Carrera";
        }

        private void CarreracomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(CarreracomboBox.SelectedValue.ToString());
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
          
            MarcadeAgua = "A";
            MessageBox.Show("Ha seleccionado el boton Agregar ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcadeAgua = "E";
          
            MessageBox.Show("Ha seleccionado el boton eliminar ");
           
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            switch (MarcadeAgua)
            {
                case "E":
                    Eliminar();
                    break;
                case "A":
                    Agregar();
                    break;
                case "U":
                    Actulizar();
                    break;
           }       

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                int Numcarrera_estudiante = 0;
                DataSet dscarrera;
                dscarrera = obj_Agenda.CargaDatos("Select * FROM Cat_Carreras");


                posicion--;
            
            DataSet ds;


            ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos");
            this.NoControltextBox.Text = ds.Tables[0].Rows[posicion][0].ToString();
            this.NombretextBox.Text = ds.Tables[0].Rows[posicion][1].ToString();
            this.DomiciliotextBox.Text = ds.Tables[0].Rows[posicion][2].ToString();
            this.FechaNacdateTimePicker.Text = ds.Tables[0].Rows[posicion][3].ToString();
            Numcarrera_estudiante = Convert.ToInt16(ds.Tables[0].Rows[posicion][4].ToString());
             this.CarreracomboBox.Text = dscarrera.Tables[0].Rows[Numcarrera_estudiante - 1][1].ToString();
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show("LLego al Inicio");
            }
        }

        private void FechaNacdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoControltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           
            MarcadeAgua = "U";
            MessageBox.Show("Ha seleccionado el boton Actualizar ");
        }

        private void buttonMostrarTablas_Click(object sender, EventArgs e)
        {
            Mostrar llamar = new Mostrar();
            llamar.Show();
        }

        private void buttonDer_Click(object sender, EventArgs e)
        {
            try { 
            posicion++;
            int Numcarrera_estudiante = 0;
            DataSet dscarrera;
            dscarrera = obj_Agenda.CargaDatos("Select * FROM Cat_Carreras");


            DataSet ds;

            
            ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos");
            this.NoControltextBox.Text = ds.Tables[0].Rows[posicion][0].ToString();
            this.NombretextBox.Text = ds.Tables[0].Rows[posicion][1].ToString();
            this.DomiciliotextBox.Text = ds.Tables[0].Rows[posicion][2].ToString();
            this.FechaNacdateTimePicker.Text = ds.Tables[0].Rows[posicion][3].ToString();
            Numcarrera_estudiante = Convert.ToInt16 (ds.Tables[0].Rows[posicion][4].ToString());
            this.CarreracomboBox.Text = dscarrera.Tables[0].Rows[Numcarrera_estudiante-1][1].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("LLego al fina retroceda");
            }

        }




        public void Eliminar()
        {
            Seleccionado selec = new Seleccionado();
            DataSet ds;
            ds = obj_Agenda.CargaDatos("Select * FROM AgendaAlumnos");
            selec.mostrar(NoControltextBox.Text);
            selec.Show();
            DialogResult result = MessageBox.Show("Seguro que desea elimnar   Mas infromacion en la pantalla?", "Salir", MessageBoxButtons.YesNoCancel);
            
            if (result == DialogResult.Yes)
            {

                string SentenciaSQL2 = string.Empty;
                SentenciaSQL2 = "Delete From AgendaAlumnos Where No_Control = '" + NoControltextBox.Text + "'";


                if (obj_Agenda.EjecutaSentencia(SentenciaSQL2) == false)
                {
                    MessageBox.Show("Se ha eliminado al alumno de la agenda.");

                }
                else
                {
                    MessageBox.Show("Problemas con la base de datos.");
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }

            selec.Hide();
        }

        public void Actulizar()
        {
            string SentenciaSQL1 = string.Empty;
            SentenciaSQL1 = "update AgendaAlumnos set NombreCompleto='" + NombretextBox.Text + "',Domicilio='" + DomiciliotextBox.Text + "',FechaNacimiento='"
                + FechaNacdateTimePicker.Text + "',Id_Carrera=" + CarreracomboBox.SelectedValue +
                 " Where No_Control = '" + NoControltextBox.Text + "'";
            if (obj_Agenda.EjecutaSentencia(SentenciaSQL1) == false)
            {
                MessageBox.Show("Se ha actualizado al alumno de la agenda.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
        }
        public void Agregar()
        {
                      
            string FormaSentencia = string.Empty;
            FormaSentencia = "Insert Into AgendaALumnos (No_Control, NombreCompleto, Domicilio, FechaNacimiento, Id_Carrera) " +
                " Values ('" + NoControltextBox.Text + "', '" + NombretextBox.Text + "', '" + DomiciliotextBox.Text +
                "', '" + FechaNacdateTimePicker.Text + "', " + CarreracomboBox.SelectedValue + ")";
            if (obj_Agenda.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El registro se ha agregado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
        }
    }
}
