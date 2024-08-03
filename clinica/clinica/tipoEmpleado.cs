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
    public partial class tipoEmpleado : MaterialSkin.Controls.MaterialForm
    {
        public tipoEmpleado()
        {
            InitializeComponent();
        }

        private void tipoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void ingresarTipo_Click(object sender, EventArgs e)
        {

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string tipo = tipoEmpleados.Text.Trim();
                string descripcion = Descripcion.Text.Trim();
                string salarios = salario.Text.Trim();
                string estados = radioActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(salarios) ||  string.IsNullOrEmpty(estados))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string query = "INSERT INTO tipoEmpleado (nombreTipoEmpleado, descripcionTipoEmpleado, salarioTipoEmpleado, estadoTipoEmpleado) VALUES (@cargo, @descripcion,@salarios, @estados)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        command.Parameters.AddWithValue("@cargo", tipo);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@salarios", salarios);
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










    }
}

