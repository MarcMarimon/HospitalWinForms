using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class EliminarForm : Form
    {
        private Hospital hospital;

        public EliminarForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            cmbTipo.SelectedIndex = 0; // Seleccionar el primer elemento por defecto
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ListBox de elementos
            lstElementos.Items.Clear();

            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Medico":
                    lstElementos.Items.AddRange(hospital.Medicos.Select(m => m.NombreCompleto).ToArray());
                    break;
                case "Paciente":
                    lstElementos.Items.AddRange(hospital.Pacientes.Select(p => p.NombreCompleto).ToArray());
                    break;
                case "Personal Auxiliar":
                    lstElementos.Items.AddRange(hospital.PersonalAuxiliar.Select(pa => pa.NombreCompleto).ToArray());
                    break;
            }

            // Limpiar el TextBox de búsqueda
            txtBuscar.Text = string.Empty;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Medico":
                    lstElementos.Items.Clear();
                    lstElementos.Items.AddRange(hospital.Medicos.Where(m => m.NombreCompleto.ToLower().Contains(filtro)).Select(m => m.NombreCompleto).ToArray());
                    break;
                case "Paciente":
                    lstElementos.Items.Clear();
                    lstElementos.Items.AddRange(hospital.Pacientes.Where(p => p.NombreCompleto.ToLower().Contains(filtro)).Select(p => p.NombreCompleto).ToArray());
                    break;
                case "Personal Auxiliar":
                    lstElementos.Items.Clear();
                    lstElementos.Items.AddRange(hospital.PersonalAuxiliar.Where(pa => pa.NombreCompleto.ToLower().Contains(filtro)).Select(pa => pa.NombreCompleto).ToArray());
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstElementos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para eliminar.");
                return;
            }

            string elementoAEliminar = lstElementos.SelectedItem.ToString();

            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Medico":
                    var medico = hospital.Medicos.FirstOrDefault(m => m.NombreCompleto == elementoAEliminar);
                    if (medico != null)
                    {
                        hospital.EliminarMedico(medico);
                        MessageBox.Show($"Medico {elementoAEliminar} eliminado.");
                    }
                    break;
                case "Paciente":
                    var paciente = hospital.Pacientes.FirstOrDefault(p => p.NombreCompleto == elementoAEliminar);
                    if (paciente != null)
                    {
                        hospital.EliminarPaciente(paciente);
                        MessageBox.Show($"Paciente {elementoAEliminar} eliminado.");
                    }
                    break;
                case "Personal Auxiliar":
                    var personalAuxiliar = hospital.PersonalAuxiliar.FirstOrDefault(pa => pa.NombreCompleto == elementoAEliminar);
                    if (personalAuxiliar != null)
                    {
                        hospital.EliminarPersonalAuxiliar(personalAuxiliar);
                        MessageBox.Show($"Personal Auxiliar {elementoAEliminar} eliminado.");
                    }
                    break;
            }

            // Actualizar la lista de elementos después de la eliminación
            cmbTipo_SelectedIndexChanged(sender, e);
        }
    }
}
