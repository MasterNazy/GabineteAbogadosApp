namespace GabineteAbogadosApp
{
    partial class FormAsuntos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumExpediente = new Label();
            lblFechaInicio = new Label();
            label3 = new Label();
            lblEstado = new Label();
            lblClienteID = new Label();
            txtNumExpediente = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            cbEstado = new ComboBox();
            txtClienteID = new TextBox();
            btnAgregarAsunto = new Button();
            btnMostrarAsuntos = new Button();
            btnActualizarAsunto = new Button();
            btnEliminarAsunto = new Button();
            dataGridAsuntos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridAsuntos).BeginInit();
            SuspendLayout();
            // 
            // lblNumExpediente
            // 
            lblNumExpediente.AutoSize = true;
            lblNumExpediente.Location = new Point(12, 33);
            lblNumExpediente.Name = "lblNumExpediente";
            lblNumExpediente.Size = new Size(127, 15);
            lblNumExpediente.TabIndex = 0;
            lblNumExpediente.Text = "Número de expediente";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(176, 33);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 15);
            lblFechaInicio.TabIndex = 1;
            lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 33);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Finalización";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(551, 33);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado";
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(678, 33);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(58, 15);
            lblClienteID.TabIndex = 4;
            lblClienteID.Text = "Cliente ID";
            // 
            // txtNumExpediente
            // 
            txtNumExpediente.Location = new Point(23, 77);
            txtNumExpediente.Name = "txtNumExpediente";
            txtNumExpediente.Size = new Size(100, 23);
            txtNumExpediente.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(155, 79);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(133, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(311, 79);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(154, 23);
            dtpFechaFin.TabIndex = 7;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "En trámite", "Archivado", "Resuelto" });
            cbEstado.Location = new Point(510, 77);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 8;
            cbEstado.SelectedIndexChanged += cbEstado_SelectedIndexChanged;
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(663, 77);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(113, 23);
            txtClienteID.TabIndex = 9;
            // 
            // btnAgregarAsunto
            // 
            btnAgregarAsunto.Location = new Point(31, 151);
            btnAgregarAsunto.Name = "btnAgregarAsunto";
            btnAgregarAsunto.Size = new Size(108, 40);
            btnAgregarAsunto.TabIndex = 10;
            btnAgregarAsunto.Text = "Agregar Asunto";
            btnAgregarAsunto.UseVisualStyleBackColor = true;
            btnAgregarAsunto.Click += btnAgregarAsunto_Click;
            // 
            // btnMostrarAsuntos
            // 
            btnMostrarAsuntos.Location = new Point(173, 151);
            btnMostrarAsuntos.Name = "btnMostrarAsuntos";
            btnMostrarAsuntos.Size = new Size(115, 40);
            btnMostrarAsuntos.TabIndex = 11;
            btnMostrarAsuntos.Text = "Mostrar Asunto";
            btnMostrarAsuntos.UseVisualStyleBackColor = true;
            btnMostrarAsuntos.Click += btnMostrarAsuntos_Click;
            // 
            // btnActualizarAsunto
            // 
            btnActualizarAsunto.Location = new Point(320, 151);
            btnActualizarAsunto.Name = "btnActualizarAsunto";
            btnActualizarAsunto.Size = new Size(126, 40);
            btnActualizarAsunto.TabIndex = 12;
            btnActualizarAsunto.Text = "Actualizar Asunto";
            btnActualizarAsunto.UseVisualStyleBackColor = true;
            btnActualizarAsunto.Click += btnActualizarAsunto_Click;
            // 
            // btnEliminarAsunto
            // 
            btnEliminarAsunto.Location = new Point(486, 151);
            btnEliminarAsunto.Name = "btnEliminarAsunto";
            btnEliminarAsunto.Size = new Size(107, 40);
            btnEliminarAsunto.TabIndex = 13;
            btnEliminarAsunto.Text = "Eliminar Asunto";
            btnEliminarAsunto.UseVisualStyleBackColor = true;
            btnEliminarAsunto.Click += btnEliminarAsunto_Click;
            // 
            // dataGridAsuntos
            // 
            dataGridAsuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAsuntos.Location = new Point(31, 225);
            dataGridAsuntos.Name = "dataGridAsuntos";
            dataGridAsuntos.Size = new Size(745, 213);
            dataGridAsuntos.TabIndex = 14;
            // 
            // FormAsuntos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridAsuntos);
            Controls.Add(btnEliminarAsunto);
            Controls.Add(btnActualizarAsunto);
            Controls.Add(btnMostrarAsuntos);
            Controls.Add(btnAgregarAsunto);
            Controls.Add(txtClienteID);
            Controls.Add(cbEstado);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(txtNumExpediente);
            Controls.Add(lblClienteID);
            Controls.Add(lblEstado);
            Controls.Add(label3);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblNumExpediente);
            Name = "FormAsuntos";
            Text = "FormAsuntos";
            ((System.ComponentModel.ISupportInitialize)dataGridAsuntos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumExpediente;
        private Label lblFechaInicio;
        private Label label3;
        private Label lblEstado;
        private Label lblClienteID;
        private TextBox txtNumExpediente;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private ComboBox cbEstado;
        private TextBox txtClienteID;
        private Button btnAgregarAsunto;
        private Button btnMostrarAsuntos;
        private Button btnActualizarAsunto;
        private Button btnEliminarAsunto;
        private DataGridView dataGridAsuntos;
    }
}