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
    public partial class Resultado : MaterialSkin.Controls.MaterialForm
    {
        public Resultado()
        {
            InitializeComponent();
            examenMedico();
            medicina();
            CargarDatosResultados();
        }
        private void examenMedico()
        {
            DatabaseConnection dbConenection = new DatabaseConnection();
            using (MySqlConnection connection = dbConenection.GetConnection())
            {
                if (connection == null) return;
                string tipoUsuarioQuery = "SELECT examenMedicoID FROM examenMedico";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    ExamenMedico.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("examenMedicoID");
                        ExamenMedico.Items.Add(tipoUsuarioID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar tipoExamenID: {ex.Message}");
                }
            }
        }

        private void medicina()
        {
            DatabaseConnection dbConenection = new DatabaseConnection();
            using (MySqlConnection connection = dbConenection.GetConnection())
            {
                if (connection == null) return;
                string tipoUsuarioQuery = "SELECT medicamentoID FROM medicamento";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    MedicamentoID.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("medicamentoID");
                        MedicamentoID.Items.Add(tipoUsuarioID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar tipoExamenID: {ex.Message}");

                }
            }
        }

        private void CargarDatosResultados()
        {
            string query = "SELECT * FROM resultadoPrueba";
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


                    dataresultados.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de examenes: {ex.Message}");
                }
            }
        }
        private void Resultado_Load(object sender, EventArgs e)
        {


        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string IdExam = ExamenMedico.Text.Trim();
                string IdMed = MedicamentoID.Text.Trim();
                string estado = Act.Checked ? "1" : "0";
                DateTime fecha = dateTimePicker1.Value;

                if (string.IsNullOrEmpty(IdExam) || string.IsNullOrEmpty(IdMed) || fecha == default(DateTime))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                // Verifica si el examen y el medicamento existen
                string checkExamQuery = "SELECT COUNT(*) FROM examenmedico WHERE examenMedicoID = @IdExam";
                string checkMedQuery = "SELECT COUNT(*) FROM medicamento WHERE medicamentoID = @IdMed";

                try
                {
                    // Verificar si existe el examen
                    using (MySqlCommand checkExamCmd = new MySqlCommand(checkExamQuery, connection))
                    {
                        checkExamCmd.Parameters.AddWithValue("@IdExam", IdExam);
                        int examExists = Convert.ToInt32(checkExamCmd.ExecuteScalar());
                        if (examExists == 0)
                        {
                            MessageBox.Show("El ID de examen no existe.");
                            return;
                        }
                    }

                    // Verificar si existe el medicamento
                    using (MySqlCommand checkMedCmd = new MySqlCommand(checkMedQuery, connection))
                    {
                        checkMedCmd.Parameters.AddWithValue("@IdMed", IdMed);
                        int medExists = Convert.ToInt32(checkMedCmd.ExecuteScalar());
                        if (medExists == 0)
                        {
                            MessageBox.Show("El ID de medicamento no existe.");
                            return;
                        }
                    }

                    // Si ambos existen, proceder con la inserción
                    string query = "INSERT INTO resultadoPrueba (fechaEntregaResultado, examenMedicoID, medicamentoID, estadoResultado)" +
                                   " VALUES (@fecha, @IdExam, @IdMed, @estado)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdExam", IdExam);
                        command.Parameters.AddWithValue("@IdMed", IdMed);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.Parameters.AddWithValue("@fecha", fecha);

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
                        CargarDatosResultados();
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

        private void Buscar_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string query = "SELECT * FROM resultadoPrueba WHERE resultadoPruebaID = @cod";
                string cod = textBox1.Text.Trim();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", cod);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataresultados.DataSource = dataTable;
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
