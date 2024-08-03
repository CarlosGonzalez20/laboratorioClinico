using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace clinica
{
    public partial class tipoEmpleado : MaterialSkin.Controls.MaterialForm
    {
        public tipoEmpleado()
        {
            InitializeComponent();
            cargarInformacion();
        }

        private void cargarInformacion()
        {
            string query = "SELECT * FROM tipoEmpleado";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Pacientes");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoTipo.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }



        }


        private void tipoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void ingresarTipo_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string tipo = tipoEmpleados.Text.Trim();
                string descripcion = Descripcion.Text.Trim();
                string salario = salarios.Text.Trim();
                string estados = radioActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(salario))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO tipoEmpleado (nombreTipoEmpleado, descripcionTipoEmpleado, salarioTipoEmpleado, estadoTipoEmpleado) VALUES (@tipo, @descripcion, @salario, @estados)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa AddWithValue para agregar los parámetros
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@salario", salario);
                        command.Parameters.AddWithValue("@estados", estados);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                            cargarInformacion(); // Llama a cargarInformacion() después de insertar los datos
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void eliminarTipo_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                string id = idTipo.Text.Trim(); // Asegúrate de tener un TextBox para el ID

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Por favor, proporciona un ID.");
                    return;
                }

                string query = "DELETE FROM tipoEmpleado WHERE tipoEmpleadoID = @id";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                            cargarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buscarTipo_Click(object sender, EventArgs e)
        {

            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                        return;
                    }

                    string id = idTipo.Text.Trim(); // Asegúrate de tener un TextBox para el ID

                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Por favor, proporciona un ID.");
                        return;
                    }

                    string query = "SELECT * FROM tipoEmpleado WHERE tipoEmpleadoID = @id";

                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                infoTipo.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                                infoTipo.DataSource = null; // Limpia el DataGridView si no se encuentra nada
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error en la base de datos: " + ex.Message);
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


