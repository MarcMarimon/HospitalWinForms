namespace HospitalWinForms
{
    partial class EliminarForm
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Medico",
            "Paciente",
            "Personal Auxiliar"});
            this.cmbTipo.Location = new System.Drawing.Point(32, 68);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 28);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 20;
            this.lstElementos.Location = new System.Drawing.Point(32, 148);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(200, 124);
            this.lstElementos.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(32, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(32, 108);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 26);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(32, 93);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 20);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar:";
            // 
            // EliminarForm
            // 
            this.ClientSize = new System.Drawing.Size(477, 430);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.btnEliminar);
            this.Name = "EliminarForm";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}
