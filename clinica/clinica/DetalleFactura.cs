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
    public partial class DetalleFactura : MaterialSkin.Controls.MaterialForm
    
    {
        public DetalleFactura()
        {
            InitializeComponent();
            paciente();
            f_detalle();
            cargardatosenca();
            cargardatosdetalle();
        }

        private void DetalleFactura_Load(object sender, EventArgs e)
        {

        }
        private void paciente()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT pacienteID FROM paciente";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    n_paciente.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("pacienteID");
                        n_paciente.Items.Add(tipoUsuarioID);
                    }
                    if (n_paciente.Items.Count > 0)
                    {
                        n_paciente.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }
        private void f_detalle()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT facturaEncabezadoID FROM facturaEncabezado";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    n_enca.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("facturaEncabezadoID");
                        n_enca.Items.Add(tipoUsuarioID);
                    }
                    if (n_enca.Items.Count > 0)
                    {
                        n_enca.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }
        private void cargardatosenca()
        {
            string query = "SELECT * FROM facturaEncabezado";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. factura");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataencabezado.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }
        private void cargardatosdetalle()
        {
            string query = "SELECT * FROM facturaDetalle";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. detalle");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    datadetalle.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }

        DateTime ho = DateTime.Now;

        private void ingresarencabezado_Click(object sender, EventArgs e)
        {
            Hora.Text = ho.ToShortTimeString();

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {

                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string serie = n_serie.Text.Trim();
                string pa = n_paciente.Text.Trim();
                string to = total.Text.Trim();
                string hora = Hora.Text.Trim();
                DateTime fechan = dateTimePicker1.Value; // Obteniendo el valor de DateTimePicker1
                string estado = estatusActivo1.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(pa) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(hora) ||
                            string.IsNullOrEmpty(estado) || fechan == default(DateTime))
                //string.IsNullOrEmpty(fechan) || string.IsNullOrEmpty(fechag))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO facturaEncabezado (pacienteID, fechaFactura, totalFactura, estadoFactura, horaFactura )" +
                                                          "VALUES (@pa, @fechan, @to, @estado, @hora)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        //command.Parameters.AddWithValue("@serie", serie);
                        command.Parameters.AddWithValue("@pa", pa);
                        command.Parameters.AddWithValue("@to", to);
                        command.Parameters.AddWithValue("@fechan", fechan);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.Parameters.AddWithValue("@hora", hora);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.");
                        }
                        cargardatosenca();
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

        private void eliminarencabezado_Click(object sender, EventArgs e)
        {
            string idIngresado = n_serie.Text.Trim();

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

            string query = "UPDATE facturaEncabezado SET estadoFactura = 0 WHERE facturaEncabezadoID = @id";
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
                            cargardatosenca();
                            //Limpiar();
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

        private void buscarencabezado_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string query = "SELECT citaID, horaCita, estadoCita, motivoCita FROM cita WHERE citaID = @citaID";
                string query = "SELECT * FROM facturaEncabezado WHERE facturaEncabezadoID = @serie";
                string serie = n_serie.Text.Trim(); // txtSearch es el campo de búsqueda

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@serie", serie);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataencabezado.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }

            }
        }

        private void modificarencabezado_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string query = "UPDATE facturaEncabezado SET " +
                               "pacienteID = @pa, " +
                               "fechaFactura = @fechan, " +
                               "totalFactura = @to, " +
                               "horaFactura = @hora, " +
                               "estadoFactura = @estado " + // Eliminé la coma extra aquí
                               "WHERE facturaEncabezadoID = @serie";

                string serie = n_serie.Text.Trim();
                string pa = n_paciente.Text.Trim();
                string to = total.Text.Trim();
                string hora = Hora.Text.Trim();
                DateTime fechan = dateTimePicker1.Value; // Obteniendo el valor de DateTimePicker1
                string estado = estatusActivo1.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(pa) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(hora) || string.IsNullOrEmpty(serie) ||
                            string.IsNullOrEmpty(estado) || fechan == default(DateTime))
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
                        command.Parameters.AddWithValue("@serie", serie);
                        command.Parameters.AddWithValue("@pa", pa);
                        command.Parameters.AddWithValue("@to", to);
                        command.Parameters.AddWithValue("@fechan", fechan);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.Parameters.AddWithValue("@hora", hora);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Factura modificada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna factura con el ID especificado.");
                        }
                        cargardatosenca(); // INSTRUCCIÓN PARA REFRESCAR LOS DATOS DEL DataGridView
                                           // Limpiar(); // Descomentar si es necesario limpiar los campos después de la actualización
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

        private void ingresardetalle_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {

                if (connection == null) return; // Verifica si la conexión fue exitosa

                string can = cantidad.Text.Trim();
                string pre = precio.Text.Trim();
                //string de = n_detalle.Text.Trim();
                string en = n_enca.Text.Trim();
                string des = descrip.Text.Trim();
                string estado = estatusActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(can) || string.IsNullOrEmpty(pre) ||
                            string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(des) || string.IsNullOrEmpty(en))
                //string.IsNullOrEmpty(fechan) || string.IsNullOrEmpty(fechag))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO facturaDetalle (facturaEncabezadoID, descripcionFacturaDetalle, cantidadFacturaDetalle, precioUnitarioFacturaDetalle, estadoFacturaDetalle )" +
                                                          "VALUES (@en, @des, @can, @pre, @estado)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        ///command.Parameters.AddWithValue("@de", de);
                        command.Parameters.AddWithValue("@en", en);
                        command.Parameters.AddWithValue("@des", des);
                        command.Parameters.AddWithValue("@can", can);
                        command.Parameters.AddWithValue("@pre", pre);
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
                        cargardatosdetalle();
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

        private void eliminardetalle_Click(object sender, EventArgs e)
        {
            string idIngresado = n_detalle.Text.Trim();

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

            string query = "UPDATE facturaDetalle SET estadoFacturaDetalle = 0 WHERE facturaDetalleID = @id";
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
                            cargardatosdetalle();
                            //Limpiar();
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

        private void buscardetalle_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string query = "SELECT citaID, horaCita, estadoCita, motivoCita FROM cita WHERE citaID = @citaID";
                string query = "SELECT * FROM facturaDetalle WHERE facturaDetalleID = @de";
                string de = n_detalle.Text.Trim(); // txtSearch es el campo de búsqueda

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@de", de);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            datadetalle.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }

            }
        }

        private void modificardetalle_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string query = "UPDATE facturaDetalle SET " +
                               "facturaEncabezadoID = @en, " +
                               "descripcionFacturaDetalle = @des, " +
                               "cantidadFacturaDetalle = @can, " +
                               "precioUnitarioFacturaDetalle = @pre, " +
                               "estadoFacturaDetalle = @estado " + // Nota: Cambié estadoEmpleado a estadoFacturaDetalle y quité la coma extra
                               "WHERE facturaDetalleID = @de";

                string can = cantidad.Text.Trim();
                string pre = precio.Text.Trim();
                string de = n_detalle.Text.Trim();
                string en = n_enca.Text.Trim();
                string des = descrip.Text.Trim();
                string estado = estatusActivo1.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(de) || string.IsNullOrEmpty(can) || string.IsNullOrEmpty(pre) ||
                            string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(des) || string.IsNullOrEmpty(en))
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
                        command.Parameters.AddWithValue("@de", de);
                        command.Parameters.AddWithValue("@en", en);
                        command.Parameters.AddWithValue("@des", des);
                        command.Parameters.AddWithValue("@can", can);
                        command.Parameters.AddWithValue("@pre", pre);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Factura detalle modificada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún detalle de factura con el ID especificado.");
                        }
                        cargardatosdetalle(); // INSTRUCCIÓN PARA REFRESCAR LOS DATOS DEL DataGridView
                                              // Limpiar(); // Descomentar si es necesario limpiar los campos después de la actualización
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
