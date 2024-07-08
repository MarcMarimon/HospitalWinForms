namespace HospitalWinForms
{
    partial class VerMedicosDePacienteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // cbPacientes
            // 
            this.cbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(101, 17);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(200, 28);
            this.cbPacientes.TabIndex = 1;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(100, 60);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarMedicos.TabIndex = 2;
            this.btnMostrarMedicos.Text = "Mostrar Médicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(20, 100);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(260, 284);
            this.lbLista.TabIndex = 3;
            // 
            // VerMedicosDePacienteForm
            // 
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.label1);
            this.Name = "VerMedicosDePacienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.ListBox lbLista;
    }
}
