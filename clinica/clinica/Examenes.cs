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
    public partial class Examenes : MaterialSkin.Controls.MaterialForm
    {
        private object id;

        public Examenes()
        {
            InitializeComponent();
            examenMedico();
            CargarDatosexamenes();
            CargarDatosexamenes2();
        }

        private void Examenes_Load(object sender, EventArgs e)
        {

        }

        private void examenMedico()
        {
            DatabaseConnection dbConenection = new DatabaseConnection();
            using (MySqlConnection connection = dbConenection.GetConnection())
            {
                if (connection == null) return;
                string tipoUsuarioQuery = "SELECT tipoExamenID FROM tipoExamen";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    Correlativo.Items.Clear();  // Limpia los items del ComboBox
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("tipoExamenID");
                        Correlativo.Items.Add(tipoUsuarioID);  // Añade el ID al ComboBox
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar tipoExamenID: {ex.Message}");
                }
            }
        }

        private void CargarDatosexamenes()
        {
            string query = "SELECT * FROM tipoExamen";
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

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    datatipoExamen.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de examenes: {ex.Message}");
                }
            }
        }
        private void CargarDatosexamenes2()
        {
            string query = "SELECT * FROM examenMedico";
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

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    dataExamenMedico.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de examenes: {ex.Message}");
                }
            }
        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                //string id = identexamen.Text.Trim();
                string desc = descripcion.Text.Trim();
                string estado = activo.Checked ? "1" : "0";

                // Concatenado los tipos de examen seleccionados
                List<string> tiposExamenSeleccionados = new List<string>();
                if (Examen1.Checked) tiposExamenSeleccionados.Add("Análisis de Sangre");
                if (Examen2.Checked) tiposExamenSeleccionados.Add("Análisis de Orina");
                if (Examen3.Checked) tiposExamenSeleccionados.Add("Prueba Genética");
                if (Examen4.Checked) tiposExamenSeleccionados.Add("Prueba de Imagenología Médica");
                if (Examen5.Checked) tiposExamenSeleccionados.Add("Análisis de Fluidos Corporales");

                string tipoExamen = string.Join(", ", tiposExamenSeleccionados);
                if (tipoExamen.Length > 100)
                {
                    tipoExamen = tipoExamen.Substring(0, 100);
                }

                if (string.IsNullOrEmpty(tipoExamen) ||
                    string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("Por favor, complete todos los campos");
                    return;
                }

                string query = "INSERT INTO tipoExamen (nombreTipoExamen, descripcionTipoExamen, estadoTipoExamen)" +
                               " VALUES (@tipoExamen, @desc, @estado)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tipoExamen", tipoExamen);
                        command.Parameters.AddWithValue("@desc", desc);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron los datos");
                        }


                        CargarDatosexamenes();
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string idIngresado = identexamen.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese código.");
                return;
            }


            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("Código inválido.");
                return;
            }

            string query = "UPDATE tipoExamen SET estadoTipoExamen = 0 WHERE tipoExamenID = @id";
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
                            MessageBox.Show("El estado del examen se ha actualizado a inactivo.");
                            CargarDatosexamenes();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el código proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del examen: {ex.Message}");
                }
            }
        }


        private void Buscar_Click(object sender, EventArgs e)
        {

        }



        private void Asangre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Correlativo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click_1(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string query = "SELECT * FROM tipoExamen WHERE tipoExamenID = @cod";
                string cod = identexamen.Text.Trim();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", cod);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            datatipoExamen.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string query = "UPDATE tipoExamen SET " +
                               "nombreTipoExamen = @tipoExamen, " +
                               "descripcionTipoExamen = @desc, " +
                               "estadoTipoExamen = @estado " +
                               "WHERE tipoExamenID = @id";

                string id = identexamen.Text.Trim();
                string desc = descripcion.Text.Trim();
                string estado = activo.Checked ? "1" : "0";

                List<string> tiposExamenSeleccionados = new List<string>();
                if (Examen1.Checked) tiposExamenSeleccionados.Add("Análisis de Sangre");
                if (Examen2.Checked) tiposExamenSeleccionados.Add("Análisis de Orina");
                if (Examen3.Checked) tiposExamenSeleccionados.Add("Prueba Genética");
                if (Examen4.Checked) tiposExamenSeleccionados.Add("Prueba de Imagenología Médica");
                if (Examen5.Checked) tiposExamenSeleccionados.Add("Análisis de Fluidos Corporales");

                string tipoExamen = string.Join(", ", tiposExamenSeleccionados);

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tipoExamen) ||
                    string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                try
                {
                    // Verificar si la conexión está cerrada antes de abrirla
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tipoExamen", tipoExamen);
                        command.Parameters.AddWithValue("@desc", desc);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Examen modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún examen con el ID especificado.");
                        }

                        CargarDatosexamenes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
                finally
                {
                    // Verificar si la conexión está abierta antes de cerrarla
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void Ingre_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                //string id = Idex.Text.Trim(); // ID del examen médico
                string tipoExamenID = Correlativo.Text.Trim(); // Correlativo del tipo de examen
                string estado = Acti.Checked ? "1" : "0"; // Estado del examen médico

                // Calcular tiempo de espera y costo en función del tipo de examen
                int tiempoEspera = 0;
                decimal costo = 0;

                switch (tipoExamenID)
                {
                    case "1":
                        tiempoEspera = 15;
                        costo = 50.00m;
                        break;
                    case "2":
                        tiempoEspera = 10;
                        costo = 30.00m;
                        break;
                    // Otros casos específicos...
                    default:
                        if (int.TryParse(tipoExamenID, out int idNum) && idNum >= 11)
                        {
                            tiempoEspera = 30; // Tiempo genérico para IDs >= 11
                            costo = 120.00m; // Costo genérico para IDs >= 11
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione un tipo de examen válido");
                            return;
                        }
                        break;
                }


                // Mostrar el tiempo de espera y el costo en las labels correspondientes
                Tiempo.Text = tiempoEspera.ToString() + " minutos";
                pago.Text = costo.ToString("C");

                // Validar que todos los campos estén llenos
                if (string.IsNullOrEmpty(tipoExamenID) || string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("Por favor, complete todos los campos");
                    return;
                }

                string query = "INSERT INTO examenMedico (tipoExamenID, tiempoEsperaExamenMedico, costoExamenMedico, estadoExamenMedico)" +
                               " VALUES (@tipoExamenID, @tiempoEspera, @costo, @estado)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tipoExamenID", tipoExamenID);
                        command.Parameters.AddWithValue("@tiempoEspera", tiempoEspera);
                        command.Parameters.AddWithValue("@costo", costo);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron los datos");
                        }

                        // Refrescar datos si es necesario
                        CargarDatosexamenes2();
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


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Busc_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string query = "SELECT * FROM examenMedico WHERE examenMedicoID = @code";
                string code = Idex.Text.Trim();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@code", code);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataExamenMedico.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }
            }
        }
    }
}
