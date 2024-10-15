using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace GabineteAbogadosApp
{
    public partial class FormAsuntos : Form
    {
        public FormAsuntos()
        {
            InitializeComponent();
        }

        private void btnAgregarAsunto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Asuntos (NumeroExpediente, FechaInicio, FechaFin, Estado, ClienteID) VALUES (@NumeroExpediente, @FechaInicio, @FechaFin, @Estado, @ClienteID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroExpediente", txtNumExpediente.Text);
                    command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                    command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);
                    command.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ClienteID", txtClienteID.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Asunto agregado correctamente");
                        else
                            MessageBox.Show("Error al agregar el asunto");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnMostrarAsuntos_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Asuntos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable table = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    dataGridAsuntos.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los datos: " + ex.Message);
                }
            }
        }

        private void btnActualizarAsunto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Asuntos SET FechaInicio = @FechaInicio, FechaFin = @FechaFin, Estado = @Estado, ClienteID = @ClienteID WHERE NumeroExpediente = @NumeroExpediente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroExpediente", txtNumExpediente.Text);
                    command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                    command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);
                    command.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ClienteID", txtClienteID.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Asunto actualizado correctamente");
                        else
                            MessageBox.Show("No se encontró el asunto para actualizar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminarAsunto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Asuntos WHERE NumeroExpediente = @NumeroExpediente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroExpediente", txtNumExpediente.Text.Trim());

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Asunto eliminado correctamente");
                        else
                            MessageBox.Show("No se encontró el asunto para eliminar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

