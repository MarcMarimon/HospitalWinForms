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
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            hospital.CrearMedico(txtNombre.Text, txtApellido.Text);
            MessageBox.Show($"Médico {txtNombre.Text} {txtApellido.Text} creado.");
            txtNombre.Clear();
            txtApellido.Clear();
        }
    }
}
