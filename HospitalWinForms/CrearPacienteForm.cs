using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class CrearPacienteForm : Form
    {
        private Hospital hospital;

        public CrearPacienteForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            hospital.CrearPaciente(txtNombre.Text, txtApellido.Text);
            MessageBox.Show($"Paciente {txtNombre.Text} {txtApellido.Text} creado.");
            txtNombre.Clear();
            txtApellido.Clear();
        }
    }
}
