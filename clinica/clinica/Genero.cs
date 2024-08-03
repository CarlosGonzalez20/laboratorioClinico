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
    public partial class Genero : MaterialSkin.Controls.MaterialForm
    {
        public Genero()
        {
            InitializeComponent();
            CargarDatosGenero();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            string codigo = CmbGenero.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }


            switch (codigo)
            {
                case "1":
                    txtNom.Text = "Masculino";
                    txtEstado.Text = "0";
                    break;

                case "2":
                    txtNom.Text = "Femenino";
                    txtEstado.Text = "1";
                    break;

                case "3":
                    txtNom.Text = "Masculino";
                    txtEstado.Text = "0";
                    break;

                case "4":
                    txtNom.Text = "Femenino";
                    txtEstado.Text = "1";
                    break;

                case "5":
                    txtNom.Text = "Masculino";
                    txtEstado.Text = "0";
                    break;

                case "6":
                    txtNom.Text = "Femenino";
                    txtEstado.Text = "1";
                    break;


                default:
                    txtNom.Clear();
                    txtEstado.Clear();
                    break;
            }

            // Ahora, guarda estos valores en la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string generoID = CmbGenero.SelectedItem?.ToString().Trim();
                string nombreGenero = txtNom.Text.Trim();
                string estadoGenero = txtEstado.Text.Trim();

                if (string.IsNullOrEmpty(generoID) || string.IsNullOrEmpty(nombreGenero) || string.IsNullOrEmpty(estadoGenero))
                {
                    MessageBox.Show("Al ingresar los datos, deben ser completados");
                    return;
                }

                string query = "INSERT INTO genero (generoID, nombreGenero, estadoGenero) VALUES (@GeneroID, @NombreGenero, @EstadoGenero)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GeneroID", generoID);
                        command.Parameters.AddWithValue("@NombreGenero", nombreGenero);
                        command.Parameters.AddWithValue("@EstadoGenero", estadoGenero);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Ingresados Correctamente.");
                            CargarDatosGenero(); // Cargar los datos actualizados en el DataGridView
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
            string codigo = CmbGenero.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "DELETE FROM genero WHERE generoID = @GeneroID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GeneroID", codigo);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Eliminados Correctamente.");
                            CargarDatosGenero(); // Cargar los datos actualizados en el DataGridView
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
            string codigo = CmbGenero.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string nombreGenero = txtNom.Text.Trim();
                string estadoGenero = txtEstado.Text.Trim();

                if (string.IsNullOrEmpty(nombreGenero) || string.IsNullOrEmpty(estadoGenero))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string query = "UPDATE genero SET nombreGenero = @NombreGenero, estadoGenero = @EstadoGenero WHERE generoID = @GeneroID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GeneroID", codigo);
                        command.Parameters.AddWithValue("@NombreGenero", nombreGenero);
                        command.Parameters.AddWithValue("@EstadoGenero", estadoGenero);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Modificados Correctamente.");
                            CargarDatosGenero(); // Cargar los datos actualizados en el DataGridView
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
            string codigo = CmbGenero.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, seleccione un código.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "SELECT nombreGenero, estadoGenero FROM genero WHERE generoID = @GeneroID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GeneroID", codigo);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNom.Text = reader["nombreGenero"].ToString();
                                txtEstado.Text = reader["estadoGenero"].ToString();
                                MessageBox.Show("Datos Encontrados.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos.");
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

        private void CargarDatosGenero()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "SELECT * FROM genero";

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

        private void CmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el cambio de selección en el ComboBox
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Lógica para manejar el click en el PictureBox
        }
    }
}
