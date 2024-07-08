namespace HospitalWinForms
{
    partial class VerPacientesDeMedicoForm
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
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(398, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ver Pacientes De Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico:";
            // 
            // cbMedicos
            // 
            this.cbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(86, 75);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(200, 28);
            this.cbMedicos.TabIndex = 1;
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPacientes.Location = new System.Drawing.Point(106, 115);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarPacientes.TabIndex = 2;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(26, 155);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(260, 284);
            this.lbLista.TabIndex = 3;
            // 
            // VerPacientesDeMedicoForm
            // 
            this.ClientSize = new System.Drawing.Size(522, 451);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.label1);
            this.Name = "VerPacientesDeMedicoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.ListBox lbLista;
    }
}
