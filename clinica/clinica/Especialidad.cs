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
    public partial class Especialidad : MaterialSkin.Controls.MaterialForm
    {
        public Especialidad()
        {
            InitializeComponent();
            CargarDatosEspecialidad();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            string codigo = cmbEspecialidad.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            switch (codigo)
            {
                case "100":
                    txtNom.Text = "Cardiología";
                    txtDes.Text = "Especialidad en enfermedades del corazón.";
                    txtEstado.Text = "0";
                    break;

                case "200":
                    txtNom.Text = "Neurología";
                    txtDes.Text = "Especialidad en enfermedades del sistema nervioso.";
                    txtEstado.Text = "1";
                    break;

                case "300":
                    txtNom.Text = "Pediatría";
                    txtDes.Text = "Especialidad en la salud de los niños.";
                    txtEstado.Text = "0";
                    break;

                default:
                    txtNom.Clear();
                    txtDes.Clear();
                    txtEstado.Clear();
                    break;
            }

            // Ahora, guarda estos valores en la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string especialidadID = cmbEspecialidad.SelectedItem?.ToString().Trim();
                string nombreEspecialidad = txtNom.Text.Trim();
                string descripcionEspecialidad = txtDes.Text.Trim();
                string estadoEspecialidad = txtEstado.Text.Trim();

                if (string.IsNullOrEmpty(especialidadID) || string.IsNullOrEmpty(nombreEspecialidad) || string.IsNullOrEmpty(descripcionEspecialidad) || string.IsNullOrEmpty(estadoEspecialidad))
                {
                    MessageBox.Show("Al ingresar los datos, deben ser completados");
                    return;
                }

                string query = "INSERT INTO especialidad (especialidadID, nombreEspecialidad, descripcionEspecialidad, estadoEspecialidad) VALUES (@EspecialidadID, @NombreEspecialidad, @DescripcionEspecialidad, @EstadoEspecialidad)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EspecialidadID", especialidadID);
                        command.Parameters.AddWithValue("@NombreEspecialidad", nombreEspecialidad);
                        command.Parameters.AddWithValue("@DescripcionEspecialidad", descripcionEspecialidad);
                        command.Parameters.AddWithValue("@EstadoEspecialidad", estadoEspecialidad);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Ingresados Correctamente.");
                            CargarDatosEspecialidad(); // Cargar los datos actualizados en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se ingresaron los datos.");
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

        private void btnElim_Click(object sender, EventArgs e)
        {
            string codigo = cmbEspecialidad.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "DELETE FROM especialidad WHERE especialidadID = @EspecialidadID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EspecialidadID", codigo);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Eliminados Correctamente.");
                            CargarDatosEspecialidad(); // Cargar los datos actualizados en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para eliminar.");
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

        private void btnMod_Click(object sender, EventArgs e)
        {
            string codigo = cmbEspecialidad.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string nombreEspecialidad = txtNom.Text.Trim();
                string descripcionEspecialidad = txtDes.Text.Trim();
                string estadoEspecialidad = txtEstado.Text.Trim();

                if (string.IsNullOrEmpty(nombreEspecialidad) || string.IsNullOrEmpty(descripcionEspecialidad) || string.IsNullOrEmpty(estadoEspecialidad))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string query = "UPDATE especialidad SET nombreEspecialidad = @NombreEspecialidad, descripcionEspecialidad = @DescripcionEspecialidad, estadoEspecialidad = @EstadoEspecialidad WHERE especialidadID = @EspecialidadID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EspecialidadID", codigo);
                        command.Parameters.AddWithValue("@NombreEspecialidad", nombreEspecialidad);
                        command.Parameters.AddWithValue("@DescripcionEspecialidad", descripcionEspecialidad);
                        command.Parameters.AddWithValue("@EstadoEspecialidad", estadoEspecialidad);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Modificados Correctamente.");
                            CargarDatosEspecialidad(); // Cargar los datos actualizados en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para modificar.");
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

        private void btnBusc_Click(object sender, EventArgs e)
        {
            string codigo = cmbEspecialidad.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "SELECT nombreEspecialidad, descripcionEspecialidad, estadoEspecialidad FROM especialidad WHERE especialidadID = @EspecialidadID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EspecialidadID", codigo);


                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNom.Text = reader["nombreEspecialidad"].ToString();
                                txtDes.Text = reader["descripcionEspecialidad"].ToString();
                                txtEstado.Text = reader["estadoEspecialidad"].ToString();
                                MessageBox.Show("Datos Encontrados.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos.");
                                txtNom.Clear();
                                txtDes.Clear();
                                txtEstado.Clear();
                            }
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

        private void CargarDatosEspecialidad()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "SELECT * FROM especialidad";

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
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

        private void CmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el cambio de selección en el ComboBox
        }




        private void cmbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNom_Click(object sender, EventArgs e)
        {

        }
    }
}
