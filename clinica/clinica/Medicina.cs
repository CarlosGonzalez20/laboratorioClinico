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
    public partial class Medicina : MaterialSkin.Controls.MaterialForm
    {
        public Medicina()
        {
            InitializeComponent();
            proveedores();
            CargarDatosmedicina();
            Limpiar();
        }

        private void Medicina_Load(object sender, EventArgs e)
        {

        }
        private void proveedores()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT proveedorID FROM proveedor";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    prove.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("proveedorID");
                        prove.Items.Add(tipoUsuarioID);
                    }
                    if (prove.Items.Count > 0)
                    {
                        prove.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }


        }
        private void CargarDatosmedicina()
        {
            string query = "SELECT * FROM medicamento";
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
                    datamedicina.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }
        private void Limpiar()
        {
            serie.Clear();
            barra.Clear();
            nom.Clear();
            //prove.Clear();
            can.Clear();
            pre.Clear();
            descrip.Clear();
            estatusActivo.Checked = false; // O establece el valor por defecto adecuado
        }

        private void ingresarmedicina_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string Serie = serie.Text.Trim();
                string Barra = barra.Text.Trim();
                string nombre = nom.Text.Trim();
                string provee = prove.Text.Trim();
                string cantidad = can.Text.Trim();
                string precio = pre.Text.Trim();
                string descripcion = descrip.Text.Trim();
                string estado = estatusActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(Barra) || string.IsNullOrEmpty(estado) ||
                        string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(provee) || string.IsNullOrEmpty(cantidad) ||
                        string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO medicamento (proveedorID, codigoBarrasMedicamento, nombreMedicamento, descripcionMedicamento, cantidadMedicamento, costoMedicamento, estadoMedicamento) " +
                                                          "VALUES (@provee, @Barra, @nombre, @descripcion, @cantidad, @precio, @estado)";
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        //command.Parameters.AddWithValue("@Serie", Serie);
                        command.Parameters.AddWithValue("@provee", provee);
                        command.Parameters.AddWithValue("@Barra", Barra);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.");
                        }
                        CargarDatosmedicina();
                        Limpiar();
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

        private void eliminarmedicina_Click(object sender, EventArgs e)
        {
            string idIngresado = serie.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese numero de serie.");
                return;
            }
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("No. serie inválido.");
                return;
            }

            string query = "UPDATE medicamento SET estadoMedicamento = 0 WHERE medicamentoID = @id";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int filasAfectadas = command.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado del medicamento se ha actualizado a inactivo.");
                            CargarDatosmedicina();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el No, serie  proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del paciente: {ex.Message}");
                }
            }
        }

        private void buscarmedicina_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string query = "SELECT citaID, horaCita, estadoCita, motivoCita FROM cita WHERE citaID = @citaID";
                string query = "SELECT * FROM medicamento WHERE medicamentoID = @Serie";
                string Serie = serie.Text.Trim(); // txtSearch es el campo de búsqueda

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Serie", Serie);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            datamedicina.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }

            }
        }

        private void modificarmedicina_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string query = "UPDATE medicamento SET " +
                    "proveedorID = @provee, " +
                    "codigoBarrasMedicamento = @Barra, " +
                    "nombreMedicamento = @nombre, " +
                    "descripcionMedicamento = @descripcion, " +
                    "cantidadMedicamento = @cantidad, " +
                    "costoMedicamento = @precio, " +
                    "estadoMedicamento = @estado " +
                    "WHERE medicamentoID = @Serie";

                string Serie = serie.Text.Trim();
                string Barra = barra.Text.Trim();
                string nombre = nom.Text.Trim();
                string provee = prove.Text.Trim();
                string cantidad = can.Text.Trim();
                string precio = pre.Text.Trim();
                string descripcion = descrip.Text.Trim();
                string estado = estatusActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(Serie) || string.IsNullOrEmpty(Barra) || string.IsNullOrEmpty(estado) ||
                        string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(provee) || string.IsNullOrEmpty(cantidad) ||
                        string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open(); // Asegúrate de abrir la conexión antes de ejecutar el comando
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Serie", Serie);
                        command.Parameters.AddWithValue("@provee", provee);
                        command.Parameters.AddWithValue("@Barra", Barra);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicamento modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún medicamento con el ID especificado.");
                        }
                        CargarDatosmedicina(); // INSTRUCCIÓN PARA REFRESCAR LOS DATOS DEL DataGridView
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close(); // Asegúrate de cerrar la conexión después de ejecutar el comando
                    }
                }
            }
        }
    }
}
