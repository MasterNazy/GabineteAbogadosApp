using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabineteAbogadosApp
{
    public partial class FormProcuradores : Form
    {
        public FormProcuradores()
        {
            InitializeComponent();
        }

        private void btnAgregarProcurador_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Procuradores (DNI, Nombre, Direccion) VALUES (@DNI, @Nombre, @Direccion)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", txtDNI.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Procurador agregado correctamente");
                        else
                            MessageBox.Show("Error al agregar el procurador");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnMostrarProcuradores_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Procuradores";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable table = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    dataGridProcuradores.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los procuradores: " + ex.Message);
                }
            }
        }

        private void btnActualizarProcurador_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Procuradores SET DNI = @DNI, Nombre = @Nombre, Direccion = @Direccion WHERE ProcuradorID = @ProcuradorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", txtDNI.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@ProcuradorID", txtProcuradorID.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Procurador actualizado correctamente");
                        else
                            MessageBox.Show("No se encontró el procurador para actualizar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminarProcurador_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Procuradores WHERE ProcuradorID = @ProcuradorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProcuradorID", txtProcuradorID.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Procurador eliminado correctamente");
                        else
                            MessageBox.Show("No se encontró el procurador para eliminar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
