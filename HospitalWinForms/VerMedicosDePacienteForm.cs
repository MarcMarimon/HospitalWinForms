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
    public partial class VerMedicosDePacienteForm : Form
    {
        private Hospital hospital;

        public VerMedicosDePacienteForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;

            // Llenar combobox de pacientes
            cbPacientes.DataSource = hospital.Pacientes;
            cbPacientes.DisplayMember = "NombreCompleto";
            
        }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = (Paciente)cbPacientes.SelectedValue;

                if (paciente != null)
                {
                    lbLista.Items.Clear();
                    foreach (var medico in paciente.Medicos)
                    {
                        lbLista.Items.Add($"{medico.NombreCompleto}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void VerMedicosDePacienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}