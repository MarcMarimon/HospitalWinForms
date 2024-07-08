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
    public partial class VerPacientesDeMedicoForm : Form
    {
        private Hospital hospital;

        public VerPacientesDeMedicoForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;

            // Llenar combobox de médicos
            cbMedicos.DataSource = hospital.Medicos;
            cbMedicos.DisplayMember = "NombreCompleto";
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = (Medico)cbMedicos.SelectedItem;

                if (medico != null)
                {
                    lbLista.Items.Clear();
                    foreach (var paciente in medico.Pacientes)
                    {
                        lbLista.Items.Add($"{paciente.NombreCompleto}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
