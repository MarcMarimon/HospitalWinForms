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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(398, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ver Medicos De Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // cbPacientes
            // 
            this.cbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(106, 71);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(200, 28);
            this.cbPacientes.TabIndex = 1;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMedicos.Location = new System.Drawing.Point(105, 114);
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
            this.lbLista.Location = new System.Drawing.Point(25, 154);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(260, 284);
            this.lbLista.TabIndex = 3;
            // 
            // VerMedicosDePacienteForm
            // 
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.label1);
            this.Name = "VerMedicosDePacienteForm";
            this.Load += new System.EventHandler(this.VerMedicosDePacienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.ListBox lbLista;
    }
}
