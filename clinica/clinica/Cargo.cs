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
using System.Data.SqlClient;



namespace clinica
{
    public partial class Cargo : MaterialSkin.Controls.MaterialForm
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {

        }
        private void ingresarPaciente_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string cargo = cargos.Text.Trim();
                string descripcion = Descripcion.Text.Trim();
                string estados = radioActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(estados))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO cargoPersonalLaboratorio (nombrePosicionPersonalLab, descripcionPosicionPersonalLab, estadoPosicionPersonalLab) VALUES (@cargo, @descripcion, @estados)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        command.Parameters.AddWithValue("@cargo", cargo);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@estados", estados);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
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




        private void eliminarPaciente_Click(object sender, EventArgs e)
        {


            string connectionString = "server=localhost;user=root;database=laboratorioclinico;password=12345;";

            // Suponiendo que tienes un TextBox llamado txtID para ingresar el ID del registro a eliminar
            string id = idCargo.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string query = "DELETE FROM cargoPersonalLaboratorio WHERE  posicionPersonalLabID = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
    }

