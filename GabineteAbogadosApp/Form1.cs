using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace GabineteAbogadosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (DNI, Nombre, Direccion, Telefono, Email) VALUES (@DNI, @Nombre, @Direccion, @Telefono, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", txtDNI.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Cliente agregado correctamente");
                        else
                            MessageBox.Show("Error al agregar el cliente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable table = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    dataGridClientes.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los datos: " + ex.Message);
                }
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE DNI = @DNI";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", txtDNI.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Cliente actualizado correctamente");
                        else
                            MessageBox.Show("No se encontró el cliente para actualizar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GabineteAbogadosDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clientes WHERE DNI = @DNI";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Cliente eliminado correctamente");
                        else
                            MessageBox.Show("No se encontró el cliente para eliminar");
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
