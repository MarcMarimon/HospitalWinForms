using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class ListarForm : Form
    {
        private Hospital hospital;

        public ListarForm(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            cbTipos.Items.AddRange(new string[] { "Médicos", "Pacientes", "Personal Auxiliar", "Todos" });
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
            string tipo = cbTipos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipo))
                return;

            switch (tipo)
            {
                case "Médicos":
                    lbLista.Items.AddRange(hospital.Medicos.Select(m => m.ToString()).ToArray());
                    break;
                case "Pacientes":
                    lbLista.Items.AddRange(hospital.Pacientes.Select(p => p.ToString()).ToArray());
                    break;
                case "Personal Auxiliar":
                    lbLista.Items.AddRange(hospital.PersonalAuxiliar.Select(pa => pa.ToString()).ToArray());
                    break;
                case "Todos":
                    lbLista.Items.AddRange(hospital.Medicos.Select(m => m.ToString()).ToArray());
                    lbLista.Items.AddRange(hospital.Pacientes.Select(p => p.ToString()).ToArray());
                    lbLista.Items.AddRange(hospital.PersonalAuxiliar.Select(pa => pa.ToString()).ToArray());
                    break;
            }
        }
    }
}
