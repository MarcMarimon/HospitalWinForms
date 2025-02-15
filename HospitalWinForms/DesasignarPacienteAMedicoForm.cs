﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class DesasignarPacienteAMedicoForm : Form
    {
        private Hospital hospital;

        public DesasignarPacienteAMedicoForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            cmbMedicos.DataSource = hospital.Medicos;
            cmbMedicos.DisplayMember = "NombreCompleto";
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var medico = cmbMedicos.SelectedItem as Medico;
            if (medico != null)
            {
                lstPacientes.DataSource = medico.Pacientes.ToList();
                lstPacientes.DisplayMember = "NombreCompleto";
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            var medico = cmbMedicos.SelectedItem as Medico;
            var paciente = lstPacientes.SelectedItem as Paciente;

            if (medico != null && paciente != null)
            {
                hospital.DesasignarPacienteDeMedico(medico, paciente);
                MessageBox.Show($"Paciente {paciente.NombreCompleto} desasignado del medico {medico.NombreCompleto}.");
                // Actualizar la lista de pacientes
                lstPacientes.DataSource = medico.Pacientes.ToList();
            }
        }
    }
}
