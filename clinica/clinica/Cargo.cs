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

            string connectionString = "server=localhost;user=root;database=laboratorioclinico;password=12345;";

            // Suponiendo que tienes TextBoxes llamados nombres y Tipo, y un ComboBox llamado Estado
            string Cargo = cargos.Text;
            string Descripcion = descripcion.Text;

            string Estados = "";
            if (radioActivo.Checked)
            {
                Estados = "1";
            }
            else if (radioInactivo.Checked)
            {
                Estados = "0";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estado.");
                return;
            }

            if (string.IsNullOrEmpty(Cargo) || string.IsNullOrEmpty(Descripcion) || string.IsNullOrEmpty(Estados))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            string query = "INSERT INTO cargoPersonalLaboratorio (nombrePosicionPersonalLab, descripcionPosicionPersonalLab, estadoPosicionPersonalLab) VALUES (@cargo, @Descripcion, @Estados)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cargo", Cargo);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@Estados", Estados);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Datos insertados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
