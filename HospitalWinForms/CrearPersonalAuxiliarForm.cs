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
    public partial class CrearPersonalAuxiliarForm : Form
    {
        private Hospital hospital;

        public CrearPersonalAuxiliarForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;

            // Llenar ComboBox con los valores del enum Departamento
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (cmbDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un departamento.");
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            Departamento departamento = (Departamento)cmbDepartamento.SelectedItem;

            hospital.CrearPersonalAuxiliar(nombre, apellido, departamento);
            MessageBox.Show($"Personal auxiliar {nombre} {apellido} creado en el departamento de {departamento}.");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbDepartamento.SelectedIndex = -1;
        }
    }
}

