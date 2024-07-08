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
    public partial class AsignarPacienteAMedicoForm : Form
    {
        private Hospital hospital;

        public AsignarPacienteAMedicoForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;

            // Llenar combobox de médicos
            cbMedicos.DataSource = hospital.Medicos;
            cbMedicos.DisplayMember = "NombreCompleto";
            

            // Llenar combobox de pacientes
            cbPacientes.DataSource = hospital.Pacientes;
            cbPacientes.DisplayMember = "NombreCompleto";
 
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {                
                Medico medico = (Medico)cbMedicos.SelectedItem;
                Paciente paciente = (Paciente)cbPacientes.SelectedItem;

                hospital.AsignarPacienteAMedico(paciente, medico);
                MessageBox.Show("Paciente asignado a médico correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
