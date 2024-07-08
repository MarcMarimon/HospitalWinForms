using System;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class CrearMedicoForm : Form
    {
        private Hospital hospital;

        public CrearMedicoForm(Hospital hospital)
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
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            hospital.CrearMedico(nombre, apellido);
            MessageBox.Show($"Médico {nombre} {apellido} creado.");
            txtNombre.Clear();
            txtApellido.Clear();
        }
    }
}
