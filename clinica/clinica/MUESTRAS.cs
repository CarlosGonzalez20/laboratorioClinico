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
    public partial class MUESTRAS : MaterialSkin.Controls.MaterialForm
    {
        public MUESTRAS()
        {
            InitializeComponent();
        }

        private void MUESTRAS_Load(object sender, EventArgs e)
        {
            //CARGAMOS LA INFORMANCION EN EL DataGrid
            CargartipoMuestra();

        }



        //TIPO MUESTRA
        //CODIGO (INSTRUCCIONES) PARA CARGAR LA INFORMANCION EN EL DataGrid. **************************************
        private void CargartipoMuestra()
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                //if (connection == null) return; // Verifica si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                //string query = "SELECT citaID, horaCita, estadoCita, motivoCita FROM cita";
                string query = "SELECT tipoMuestraID, nombreTipoMuestra, descripcionTipoMuestra,estadoTipoMuestra FROM tipoMuestra";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["estadoTipoMuestra"].Value != null && Convert.ToInt32(row.Cells["estadoTipoMuestra"].Value) == 0)
                                {
                                    row.DefaultCellStyle.BackColor = Color.LightGray; // Cambiar el color para hacer la fila opaca
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }
        }


        //TIPO MUESTRA
        //CODIGO (INSTRUCCIONES) PARA EL BOTON BUSCAR LA INFORMANCION . **************************************
        private void BuscarMuestra_Click(object sender, EventArgs e)
        {
            CargartipoMuestra();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string tipoMuestraID = txtIDTmuestra.Text.Trim();

                if (string.IsNullOrEmpty(tipoMuestraID))
                {
                    MessageBox.Show("Por favor, ingrese un número del TIPO DE LA MUESTRA.");
                    return;
                }

                string query = "SELECT * FROM tipoMuestra WHERE tipoMuestraID = @tipoMuestraID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tipoMuestraID", tipoMuestraID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomMuestra.Text = reader["nombreTipoMuestra"].ToString();
                                txtDMuestra.Text = reader["descripcionTipoMuestra"].ToString();


                                string estadoTipoMuestra = reader["estadoTipoMuestra"].ToString();
                                Console.WriteLine($"Estado tipo Muestra: {estadoTipoMuestra}"); // Para depuración
                                if (estadoTipoMuestra == "true")
                                {
                                    rdAc.Checked = true;
                                }
                                else if (estadoTipoMuestra == "false")
                                {
                                    rdIc.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells["tipoMuestraID"].Value.ToString() == tipoMuestraID)
                                    {
                                        row.Selected = true;
                                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningun TIPO DE MUESTRA con ese número de ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el TIPO DE MUESTRA: {ex.Message}");
                }
            }
        }

        //TIPO MUESTRA
        //CODIGO (INSTRUCCIONES) PARA EL BOTON INGRESAR INFORMANCION. **************************************
        private void IngInfMuestra_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "NombreTMuestra", () => txtNomMuestra.Text.Trim() },
                    { "DTipoMuestra", () => txtDMuestra.Text.Trim() },
                    { "Estado", () => rdAc.Checked ? "1" : "0" },
            };
                // Validar los campos
                foreach (var campo in campos)
                {
                    string valor = campo.Value.Invoke();
                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Key}' es obligatorio.");
                        return;
                    }
                }
                string NombreTmuestra = campos["NombreTMuestra"].Invoke();
                string DtipoMuestra = campos["DTipoMuestra"].Invoke();
                string estados = campos["Estado"].Invoke();


                //INFORMACION QUE SE ENCUENTRA EN LA TABLA DE NUESTRA BASE DE DATOS
                string query = "INSERT INTO tipoMuestra (nombreTipoMuestra, descripcionTipoMuestra, estadoTipoMuestra) " +
                               "VALUES (@nombreTipoMuestra, @descripcionTipoMuestra, @estadoTipoMuestra)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@nombreTipoMuestra", NombreTmuestra);
                        command.Parameters.AddWithValue("@estadoTipoMuestra", estados);
                        command.Parameters.AddWithValue("@descripcionTipoMuestra", DtipoMuestra);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Datos ingresados correctamente.");
                    CargartipoMuestra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ingresar los datos: {ex.Message}");
                }
            }
        }


        //TIPO MUESTRA
        //CODIGO (INSTRUCCIONES) PARA EL MODIFICAR BUSCAR LA INFORMANCION . **************************************
        private void ModificarMuestra_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string query = "UPDATE tipoMuestra SET nombreTipoMuestra = @nombreTipoMuestra, descripcionTipoMuestra = @descripcionTipoMuestra, estadoTipoMuestra = @estadoTipoMuestra WHERE tipoMuestraID = @tipoMuestraID";
                string tmuestraID = txtIDTmuestra.Text.Trim(); // txtSearch es el campo para ingresar el ID de la cita a modificar
                string nombreTmuestra = txtNomMuestra.Text.Trim();
                string estado = rdAc.Checked ? "1" : "0";
                string descripcionTmuestra = txtDMuestra.Text.Trim();

                // Validar los campos
                if (string.IsNullOrEmpty(tmuestraID) || string.IsNullOrEmpty(nombreTmuestra) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(descripcionTmuestra))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tipoMuestraID", tmuestraID);
                        command.Parameters.AddWithValue("@nombreTipoMuestra", nombreTmuestra);
                        command.Parameters.AddWithValue("@estadoTipoMuestra", estado);
                        command.Parameters.AddWithValue("@descripcionTipoMuestra", descripcionTmuestra);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("tipoMuestra modificada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna cita con el ID especificado.");
                        }
                        CargartipoMuestra(); // INSTRUCCION PARA Refrescar los datos del DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
            }
        }


        //TIPO MUESTRA
        //CODIGO (INSTRUCCIONES) PARA EL BOTON ELIMINAR LA INFORMANCION . **************************************
        private void EliminarMuestra_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                //if (connection == null) return; // Verifica si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                //string query = "DELETE FROM tipoMuestra WHERE tipoMuestraID = @tipoMuestraID";
                string query = "UPDATE tipoMuestra SET estadoTipoMuestra = 0 WHERE tipoMuestraID = @tipoMuestraID";
                string tipoMuestraID = txtIDTmuestra.Text.Trim(); // txtSearch es el campo para ingresar el ID de la muestra a eliminar
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tipoMuestraID", tipoMuestraID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El estado de la muestra se ha actualizado a inactivo.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna muestra con el ID especificado.");
                        }

                        CargartipoMuestra(); // Refresca los datos del DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar los datos: {ex.Message}");
                }
            }
        }


    }
}
