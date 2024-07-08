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
    public partial class MainForm : Form
    {
        private Hospital hospital;

        public MainForm()
        {
            InitializeComponent();
            hospital = new Hospital();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CrearMedicoForm(hospital));
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CrearPacienteForm(hospital));
        }

        private void btnCrearPersonalAuxiliar_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CrearPersonalAuxiliarForm(hospital));
        }

        private void btnAsignarPacienteAMedico_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AsignarPacienteAMedicoForm(hospital));
        }

        private void btnDesasignarPacienteAMedico_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new DesasignarPacienteAMedicoForm(hospital));
        }
        private void btnVerPacientesDeMedico_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new VerPacientesDeMedicoForm(hospital));
        }

        private void btnVerMedicosDePaciente_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new VerMedicosDePacienteForm(hospital));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ListarForm(hospital));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new EliminarForm(hospital));
        }

        private void LoadFormInPanel(Form form)
        {
            // Limpiar el panel derecho
            this.panelDerecho.Controls.Clear();

            // Configurar el formulario como hijo del panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Añadir el formulario al panel y mostrarlo
            this.panelDerecho.Controls.Add(form);
            form.Show();
        }
    }
}
