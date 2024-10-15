namespace GabineteAbogadosApp
{
    partial class FormProcuradores
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProcuradorID = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnAgregarProcurador = new Button();
            btnMostrarProcuradores = new Button();
            btnActualizarProcurador = new Button();
            btnEliminarProcurador = new Button();
            dataGridProcuradores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridProcuradores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Procurador ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 27);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 27);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 27);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección";
            // 
            // txtProcuradorID
            // 
            txtProcuradorID.Location = new Point(12, 64);
            txtProcuradorID.Name = "txtProcuradorID";
            txtProcuradorID.Size = new Size(132, 23);
            txtProcuradorID.TabIndex = 4;
            txtProcuradorID.Visible = false;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(178, 64);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(149, 23);
            txtDNI.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(396, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(565, 64);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(165, 23);
            txtDireccion.TabIndex = 7;
            // 
            // btnAgregarProcurador
            // 
            btnAgregarProcurador.Location = new Point(21, 112);
            btnAgregarProcurador.Name = "btnAgregarProcurador";
            btnAgregarProcurador.Size = new Size(117, 46);
            btnAgregarProcurador.TabIndex = 8;
            btnAgregarProcurador.Text = "Agregar Procurador";
            btnAgregarProcurador.UseVisualStyleBackColor = true;
            btnAgregarProcurador.Click += btnAgregarProcurador_Click;
            // 
            // btnMostrarProcuradores
            // 
            btnMostrarProcuradores.Location = new Point(172, 112);
            btnMostrarProcuradores.Name = "btnMostrarProcuradores";
            btnMostrarProcuradores.Size = new Size(111, 49);
            btnMostrarProcuradores.TabIndex = 9;
            btnMostrarProcuradores.Text = "Mostrar Procuradores";
            btnMostrarProcuradores.UseVisualStyleBackColor = true;
            btnMostrarProcuradores.Click += btnMostrarProcuradores_Click;
            // 
            // btnActualizarProcurador
            // 
            btnActualizarProcurador.Location = new Point(304, 112);
            btnActualizarProcurador.Name = "btnActualizarProcurador";
            btnActualizarProcurador.Size = new Size(111, 46);
            btnActualizarProcurador.TabIndex = 10;
            btnActualizarProcurador.Text = "Actualizar Procurador";
            btnActualizarProcurador.UseVisualStyleBackColor = true;
            btnActualizarProcurador.Click += btnActualizarProcurador_Click;
            // 
            // btnEliminarProcurador
            // 
            btnEliminarProcurador.Location = new Point(440, 112);
            btnEliminarProcurador.Name = "btnEliminarProcurador";
            btnEliminarProcurador.Size = new Size(104, 46);
            btnEliminarProcurador.TabIndex = 11;
            btnEliminarProcurador.Text = "Eliminar Procurador";
            btnEliminarProcurador.UseVisualStyleBackColor = true;
            btnEliminarProcurador.Click += btnEliminarProcurador_Click;
            // 
            // dataGridProcuradores
            // 
            dataGridProcuradores.AllowUserToAddRows = false;
            dataGridProcuradores.AllowUserToDeleteRows = false;
            dataGridProcuradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProcuradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProcuradores.Location = new Point(12, 179);
            dataGridProcuradores.Name = "dataGridProcuradores";
            dataGridProcuradores.ReadOnly = true;
            dataGridProcuradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProcuradores.Size = new Size(712, 209);
            dataGridProcuradores.TabIndex = 12;
            // 
            // FormProcuradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridProcuradores);
            Controls.Add(btnEliminarProcurador);
            Controls.Add(btnActualizarProcurador);
            Controls.Add(btnMostrarProcuradores);
            Controls.Add(btnAgregarProcurador);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtProcuradorID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProcuradores";
            Text = "FormProcuradores";
            ((System.ComponentModel.ISupportInitialize)dataGridProcuradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProcuradorID;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Button btnAgregarProcurador;
        private Button btnMostrarProcuradores;
        private Button btnActualizarProcurador;
        private Button btnEliminarProcurador;
        private DataGridView dataGridProcuradores;
    }
}