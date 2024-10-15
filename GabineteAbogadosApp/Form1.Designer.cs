namespace GabineteAbogadosApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDNI = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnAgregarCliente = new Button();
            btnMostrarClientes = new Button();
            dataGridClientes = new DataGridView();
            btnConectar = new Button();
            btnActualizarCliente = new Button();
            btnEliminarCliente = new Button();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(58, 25);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(190, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(334, 25);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(12, 56);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(123, 23);
            txtDNI.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(307, 56);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(118, 23);
            txtDireccion.TabIndex = 7;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(26, 135);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(109, 43);
            btnAgregarCliente.TabIndex = 10;
            btnAgregarCliente.Text = "Agregar Clientes";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(161, 135);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(101, 42);
            btnMostrarClientes.TabIndex = 11;
            btnMostrarClientes.Text = "Mostrar Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(12, 196);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.Size = new Size(716, 150);
            dataGridClientes.TabIndex = 12;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(498, 135);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(111, 43);
            btnConectar.TabIndex = 13;
            btnConectar.Text = "Conectar a BD";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += button1_Click;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.Location = new Point(278, 135);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(92, 42);
            btnActualizarCliente.TabIndex = 14;
            btnActualizarCliente.Text = "Actualizar";
            btnActualizarCliente.UseVisualStyleBackColor = true;
            btnActualizarCliente.Click += btnActualizarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(376, 135);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(86, 42);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(468, 25);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(584, 25);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(442, 56);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(557, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnActualizarCliente);
            Controls.Add(btnConectar);
            Controls.Add(dataGridClientes);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDNI;
        private Label lblNombre;
        private Label lblDireccion;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Button btnAgregarCliente;
        private Button btnMostrarClientes;
        private DataGridView dataGridClientes;
        private Button btnConectar;
        private Button btnActualizarCliente;
        private Button btnEliminarCliente;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtTelefono;
        private TextBox txtEmail;
    }
}
