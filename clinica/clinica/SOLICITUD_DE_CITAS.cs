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
    public partial class SOLICITUD_DE_CITAS : MaterialSkin.Controls.MaterialForm
    {
        public SOLICITUD_DE_CITAS()
        {
            InitializeComponent();
        }

        private void SOLICITUD_DE_CITAS_Load(object sender, EventArgs e)
        {
            //CON ESTA INSTRUCCION ES PARA QUE VEAMOS DESDE EL NINICIO LA INFORMACION DEL DataGrid. **************************************
            CargarDatosIDS();
            CargarDatosCita();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        //INSTRUCCIONES PARA CARGAR INFORMACION DE IDS
        private void CargarDatosIDS()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para MEDICO
                string medicoQuery = "SELECT medicoID FROM medico";
                MySqlCommand medicoCommand = new MySqlCommand(medicoQuery, connection);
                try
                {
                    MySqlDataReader medicoReader = medicoCommand.ExecuteReader();
                    IDMedicos.Items.Clear();
                    while (medicoReader.Read())
                    {
                        int medicoID = medicoReader.GetInt32("medicoID");
                        IDMedicos.Items.Add(medicoID);
                    }
                    if (IDMedicos.Items.Count > 0)
                    {
                        IDMedicos.SelectedIndex = 0;
                    }
                    medicoReader.Close();

                    // Llenar el ComboBox para PACIENTE
                    string pacienteQuery = "SELECT pacienteID FROM paciente";
                    MySqlCommand pacienteCommand = new MySqlCommand(pacienteQuery, connection);
                    MySqlDataReader pacienteReader = pacienteCommand.ExecuteReader();
                    IDPaciente.Items.Clear();
                    while (pacienteReader.Read())
                    {
                        int pacienteID = pacienteReader.GetInt32("pacienteID");
                        IDPaciente.Items.Add(pacienteID);
                    }
                    if (IDPaciente.Items.Count > 0)
                    {
                        IDPaciente.SelectedIndex = 0;
                    }
                    pacienteReader.Close();

                    // Llenar el ComboBox para EXAMEN MÉDICO
                    string examenMQuery = "SELECT examenMedicoID FROM examenMedico";
                    MySqlCommand examenMCommand = new MySqlCommand(examenMQuery, connection);
                    MySqlDataReader examenMReader = examenMCommand.ExecuteReader();
                    IDExamenes.Items.Clear();
                    while (examenMReader.Read())
                    {
                        int examenMedicoID = examenMReader.GetInt32("examenMedicoID");
                        IDExamenes.Items.Add(examenMedicoID);
                    }
                    if (IDExamenes.Items.Count > 0)
                    {
                        IDExamenes.SelectedIndex = 0;
                    }
                    examenMReader.Close();


                    // Llenar el ComboBox para CLINICA
                    string clinicaQuery = "SELECT clinicaID FROM clinica";
                    MySqlCommand clinicaCommand = new MySqlCommand(clinicaQuery, connection);
                    MySqlDataReader clinicaReader = clinicaCommand.ExecuteReader();
                    IDClinica.Items.Clear();
                    while (clinicaReader.Read())
                    {
                        int clinicaID = clinicaReader.GetInt32("clinicaID");
                        IDClinica.Items.Add(clinicaID);
                    }
                    if (IDClinica.Items.Count > 0)
                    {
                        IDClinica.SelectedIndex = 0;
                    }
                    clinicaReader.Close();

                    // Llenar el ComboBox para MUESTRA
                    string muestraQuery = "SELECT muestraID FROM muestra";
                    MySqlCommand muestraCommand = new MySqlCommand(muestraQuery, connection);
                    MySqlDataReader muestraReader = muestraCommand.ExecuteReader();
                    IDMuestra.Items.Clear();
                    while (muestraReader.Read())
                    {
                        int muestraID = muestraReader.GetInt32("muestraID");
                        IDMuestra.Items.Add(muestraID);
                    }
                    if (IDMuestra.Items.Count > 0)
                    {
                        IDMuestra.SelectedIndex = 0;
                    }
                    muestraReader.Close();

                    // Llenar el ComboBox para RESULTADO
                    string resultadoQuery = "SELECT resultadoID FROM resultado";
                    MySqlCommand resultadoCommand = new MySqlCommand(resultadoQuery, connection);
                    MySqlDataReader resultadoReader = resultadoCommand.ExecuteReader();
                    IDResultado.Items.Clear();
                    while (resultadoReader.Read())
                    {
                        int resultadoID = resultadoReader.GetInt32("resultadoID");
                        IDResultado.Items.Add(resultadoID);
                    }
                    if (IDResultado.Items.Count > 0)
                    {
                        IDResultado.SelectedIndex = 0;
                    }
                    resultadoReader.Close();
                    //ASTA AQUI TERMINAS LOS IDS
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }



        //INSTRUCCION PARA VISUALIZAR LA INFORMACION EN EL DATAGRI
        private void CargarDatosCita()
        {
            // Modificar la consulta SQL para incluir la columna 'descripcion' de la tabla 'resultados'
            string query = @"
                            SELECT c.citaID, c.medicoID, m.nombreMedico, c.pacienteID, p.nombrePaciente, c.examenMedicoID, c.clinicaID, cl.nombreClinica, c.muestraID, r.resultadoID, c.fechaCita, c.horaCita, c.estadoCita, c.motivoCita
                            FROM cita c
                            INNER JOIN resultado r ON c.resultadoID = r.resultadoID 
                            INNER JOIN medico m ON c.medicoID = m.medicoID
                            INNER JOIN paciente p ON c.pacienteID = p.pacienteID
                            INNER JOIN clinica cl ON c.clinicaID = cl.clinicaID
                            ORDER BY c.citaID ASC"; // Ordenar por 'citaID'


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
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Aplicar el color opaco a las filas eliminadas
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["estadoCita"].Value != null && Convert.ToInt32(row.Cells["estadoCita"].Value) == 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia el color para hacer la fila opaca
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de CITA: {ex.Message}");
                }
            }
        }




        //CODIGO (INSTRUCCIONES) PARA EL BOTON BUSCAR LA INFORMANCION . **********************1111****************
        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatosCita();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string citaID = txtIDcita.Text.Trim();

                if (string.IsNullOrEmpty(citaID))
                {
                    MessageBox.Show("Por favor, ingrese un número de CITA.");
                    return;
                }

                string query = "SELECT * FROM cita WHERE citaID = @citaID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@citaID", citaID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IDMedicos.SelectedItem = reader["medicoID"].ToString();
                                IDPaciente.SelectedItem = reader["pacienteID"].ToString();
                                IDExamenes.SelectedItem = reader["examenMedicoID"].ToString();
                                IDClinica.SelectedItem = reader["clinicaID"].ToString();
                                IDMuestra.SelectedItem = reader["muestraID"].ToString();
                                IDResultado.SelectedItem = reader["resultadoID"].ToString();
                                fechaCitaMedica.Value = reader.GetDateTime("fechaCita");
                                txtHor.Text = reader["horaCita"].ToString();
                                txtMot.Text = reader["motivoCita"].ToString();


                                string estadoCita = reader["estadoCita"].ToString();
                                Console.WriteLine($"Estado Cita: {estadoCita}"); // Para depuración
                                if (estadoCita == "true")
                                {
                                    rdAc.Checked = true;
                                }
                                else if (estadoCita == "false")
                                {
                                    rdIc.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells["citaID"].Value.ToString() == citaID)
                                    {
                                        row.Selected = true;
                                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna CITA con ese número de ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el CITA: {ex.Message}");
                }
            }
        }

        //CODIGO (INSTRUCCIONES) PARA EL BOTON INGRESAR INFORMANCION. **************************************
        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "medico", () => IDMedicos.SelectedItem?.ToString() },
                    { "paciente", () => IDPaciente.SelectedItem?.ToString() },
                    { "examenMe", () => IDExamenes.SelectedItem?.ToString() },
                    { "clinicas", () => IDClinica.SelectedItem?.ToString() },
                    { "muestra", () => IDMuestra.SelectedItem?.ToString() },
                    { "resultados", () => IDResultado.SelectedItem?.ToString() },
                    { "FechaDeCita", () => fechaCitaMedica.Value.ToString("yyyy-MM-dd") },
                    { "horaCita", () => txtHor.Text.Trim() },
                    { "MotivoCita", () => txtMot.Text.Trim() },
                    { "Estado", () => rdAc.Checked ? "1" : "0" }
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



                string medico = campos["medico"].Invoke();
                string pacientes = campos["paciente"].Invoke();
                string examenMedicos = campos["examenMe"].Invoke();
                string clinica = campos["clinicas"].Invoke();
                string muestra = campos["muestra"].Invoke();
                string resultado = campos["resultados"].Invoke();

                string hora = campos["horaCita"].Invoke();
                string motivoCita = campos["MotivoCita"].Invoke();
                DateTime fechaCita = DateTime.Parse(campos["FechaDeCita"].Invoke());
                string estados = campos["Estado"].Invoke();


                string query = "INSERT INTO cita (medicoID, pacienteID, examenMedicoID, clinicaID, muestraID, resultadoID, fechaCita, horaCita, estadoCita, motivoCita) " +
                               "VALUES (@medicoID, @pacienteID, @examenMedicoID, @clinicaID, @muestraID, @resultadoID, @fechaCita, @horaCita, @estadoCita, @motivoCita)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@medicoID", medico);
                        command.Parameters.AddWithValue("@pacienteID", pacientes);
                        command.Parameters.AddWithValue("@examenMedicoID", examenMedicos);
                        command.Parameters.AddWithValue("@clinicaID", clinica);
                        command.Parameters.AddWithValue("@muestraID", muestra);
                        command.Parameters.AddWithValue("@resultadoID", resultado);
                        command.Parameters.AddWithValue("@fechaCita", fechaCita);
                        command.Parameters.AddWithValue("@horaCita", hora);
                        command.Parameters.AddWithValue("@estadoCita", estados);
                        command.Parameters.AddWithValue("@motivoCita", motivoCita);


                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos ingresados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ingresar los datos: {ex.Message}");
                }
            }
            CargarDatosCita();
        }


        //CODIGO (INSTRUCCIONES) PARA EL MODIFICAR LA INFORMANCION . *************************************
        private void button3_Click(object sender, EventArgs e)
        {
            string idIngresado = txtIDcita.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID de la cita que desea modificar.");
                return;
            }

            // Convertir el ID a entero (ajusta si tu ID es de otro tipo de dato)
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
            { "medico", () => IDMedicos.SelectedItem?.ToString() },
            { "paciente", () => IDPaciente.SelectedItem?.ToString() },
            { "examenMe", () => IDExamenes.SelectedItem?.ToString() },
            { "clinicas", () => IDClinica.SelectedItem?.ToString() },
            { "muestra", () => IDMuestra.SelectedItem?.ToString() },
            { "resultados", () => IDResultado.SelectedItem?.ToString() },
            { "FechaDeCita", () => fechaCitaMedica.Value.ToString("yyyy-MM-dd") },
            { "horaCita", () => txtHor.Text.Trim() },
            { "MotivoCita", () => txtMot.Text.Trim() },
            { "Estado", () => rdAc.Checked ? "1" : "0" }
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

                string medico = campos["medico"].Invoke();
                string pacientes = campos["paciente"].Invoke();
                string examenMedicos = campos["examenMe"].Invoke();
                string clinica = campos["clinicas"].Invoke();
                string muestra = campos["muestra"].Invoke();
                string resultado = campos["resultados"].Invoke();
                string hora = campos["horaCita"].Invoke();
                string motivoCita = campos["MotivoCita"].Invoke();
                DateTime fechaCita = DateTime.Parse(campos["FechaDeCita"].Invoke());
                string estados = campos["Estado"].Invoke();

                // Definir la consulta SQL de actualización
                string query = "UPDATE cita SET " +
                               "medicoID = @medicoID, " +
                               "pacienteID = @pacienteID, " +
                               "examenMedicoID = @examenMedicoID, " +
                               "clinicaID = @clinicaID, " +
                               "muestraID = @muestraID, " +
                               "resultadoID = @resultadoID, " +
                               "fechaCita = @fechaCita, " +
                               "horaCita = @horaCita, " +
                               "estadoCita = @estadoCita, " +
                               "motivoCita = @motivoCita " +
                               "WHERE citaID = @citaID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@medicoID", medico);
                        command.Parameters.AddWithValue("@pacienteID", pacientes);
                        command.Parameters.AddWithValue("@examenMedicoID", examenMedicos);
                        command.Parameters.AddWithValue("@clinicaID", clinica);
                        command.Parameters.AddWithValue("@muestraID", muestra);
                        command.Parameters.AddWithValue("@resultadoID", resultado);
                        command.Parameters.AddWithValue("@fechaCita", fechaCita);
                        command.Parameters.AddWithValue("@horaCita", hora);
                        command.Parameters.AddWithValue("@estadoCita", estados);
                        command.Parameters.AddWithValue("@motivoCita", motivoCita);
                        command.Parameters.AddWithValue("@citaID", id);  // ID de la cita que se va a modificar

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");

                            // Opcional: Actualizar el DataGridView
                            CargarDatosCita();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
            }

        }


        //CODIGO (INSTRUCCIONES) PARA EL BOTON ELIMINAR LA INFORMANCION . **************************************
        private void button4_Click(object sender, EventArgs e)
        {
            string idIngresado = txtIDcita.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string query = "UPDATE cita SET estadoCita = 0 WHERE citaID = @id";
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
                            MessageBox.Show("El estado de la CITA se ha actualizado a inactivo.");
                            CargarDatosCita();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del CITA: {ex.Message}");
                }
            }
        }



    }
}
