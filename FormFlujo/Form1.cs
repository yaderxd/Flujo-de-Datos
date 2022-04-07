using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFlujo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string NameFichero;

        Persona ObjectPersona = new Persona();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFichero_Click(object sender, EventArgs e)
        {
            SaveFileDialog select = new SaveFileDialog();
            DialogResult r = select.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                return;
            }
            NameFichero = select.FileName;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameFichero))
            {
                MessageBox.Show("No se,Espero haberte ayudado");
                return;
            }
            ObjectPersona = new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido=txtApellido.Text,
                Edad=Convert.ToInt32(txtEdad.Text),
                Cedula=txtCedula.Text
            };
            using(FileStream fs =new FileStream(NameFichero, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter xd= new StreamWriter(fs))
                {
                    xd.WriteLine(ObjectPersona.Nombre + " " + ObjectPersona.Apellido + " " + ObjectPersona.Edad + " " + ObjectPersona.Cedula);
                }
            }
        }
       
    }
}
