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
    public partial class Personal : MaterialSkin.Controls.MaterialForm
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void cargarInformacion()
        {
            string query = "SELECT * FROM personalLab";
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
                    infoPersonal.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }



        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ingresarPersonal_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string no_ident = numeroIdentificacion.Text.Trim();
                string nombres = nombre.Text.Trim();
                string apellidos = apellido.Text.Trim(); // Corregido para que use el control correcto
                string fecha_naci = nacimiento.Value.ToString("yyyy-MM-dd");
                string fecha_cont = fechaContratacion.Value.ToString("yyyy-MM-dd");
                string horarios = horarioPersonal.Text.Trim();
                string puesto = puestoPersonal.Text.Trim();
                string estados = estatusActivo.Checked ? "1" : "0";
                string telefonos = telefono.Text.Trim();
                string email = correoElectronico.Text.Trim(); // Añadido el campo para el email

                string dias = "";
                if (lunes.Checked) dias += "lunes, ";
                if (martes.Checked) dias += "martes, ";
                if (miercoles.Checked) dias += "miércoles, ";
                if (jueves.Checked) dias += "jueves, ";
                if (viernes.Checked) dias += "viernes, ";
                if (sabado.Checked) dias += "sábado, ";
                if (domingo.Checked) dias += "domingo, ";

                // Elimina la última coma y espacio si hay días seleccionados
                if (dias.EndsWith(", ")) dias = dias.Substring(0, dias.Length - 2);

                // Verificación de campos vacíos
                if (string.IsNullOrEmpty(no_ident) ||
                    string.IsNullOrEmpty(nombres) ||
                    string.IsNullOrEmpty(apellidos) ||
                    string.IsNullOrEmpty(fecha_naci) ||
                    string.IsNullOrEmpty(fecha_cont) ||
                    string.IsNullOrEmpty(horarios) ||
                    string.IsNullOrEmpty(puesto) ||
                    string.IsNullOrEmpty(estados) ||
                    string.IsNullOrEmpty(telefonos) ||
                    string.IsNullOrEmpty(dias))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                // Consulta SQL para insertar en la base de datos
                string query = "INSERT INTO personalLab ( numeroIdentificacion, nombrePersonalLab, apellidoPersonalLab, fechaNacimientoPersonalLab, fechaContratacionPersonalLab, horarioPersonalLab, diasTrabajoPersonalLab, posicionPersonalLab, telefonoPersonalLab, emailPersonalLab, estadoPersonalLab)  VALUES ( @no_ident, @nombres, @apellidos, @fecha_naci, @fecha_cont, @horarios, @dias, @puesto, @telefonos, @email, @estados)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa AddWithValue para agregar los parámetros
                        command.Parameters.AddWithValue("@no_ident", no_ident);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@fecha_naci", fecha_naci);
                        command.Parameters.AddWithValue("@fecha_cont", fecha_cont);
                        command.Parameters.AddWithValue("@horarios", horarios);
                        command.Parameters.AddWithValue("@dias", dias);
                        command.Parameters.AddWithValue("@puesto", puesto);
                        command.Parameters.AddWithValue("@telefonos", telefonos);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@estados", estados == "1" ? 1 : 0); // Ajusta según tu lógica de estados

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
    }

}
