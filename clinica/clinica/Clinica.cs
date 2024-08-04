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
    public partial class Clinica : MaterialSkin.Controls.MaterialForm
    {
        public Clinica()
        {
            InitializeComponent();
            cmbClinica.SelectedIndexChanged += CmbClinica_SelectedIndexChanged;
        }

        private void Clinica_Load(object sender, EventArgs e)
        {

        }

        private void MBIng_Click(object sender, EventArgs e)
        {
            string clinicaID = cmbClinica.SelectedItem?.ToString().Trim();
            if (string.IsNullOrEmpty(clinicaID))
            {
                MessageBox.Show("Por favor, seleccione un número de clínica.");
                return;
            }

            string nombreClinica = txtNomCl.Text.Trim();
            string areaEspecialidadID = txtArea.Text.Trim();
            string direccionClinica = txtDir.Text.Trim();
            string horarioActividadClinica = txtHorario.Text.Trim();
            string telefonoClinica = txtTelefono.Text.Trim();
            string emailClinica = txtCorreo.Text.Trim();
            string estadoClinica = txtEstado.Text.Trim();



            if (string.IsNullOrEmpty(nombreClinica) || string.IsNullOrEmpty(areaEspecialidadID) ||
                string.IsNullOrEmpty(direccionClinica) || string.IsNullOrEmpty(horarioActividadClinica) ||
                string.IsNullOrEmpty(telefonoClinica) || string.IsNullOrEmpty(emailClinica) || string.IsNullOrEmpty(estadoClinica))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "INSERT INTO clinica (nombreClinica, areaEspecialidadID, direccionClinica, horarioActividadClinica, telefonoClinica, emailClinica, estadoClinica) " +
                        "VALUES (@NombreClinica, @AreaEspecialidadID, @DireccionClinica, @HorarioActividadClinica, @TelefonoClinica, @EmailClinica, @EstadoClinica)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumeroClinica", clinicaID);
                        command.Parameters.AddWithValue("@NombreClinica", nombreClinica);
                        command.Parameters.AddWithValue("@NumeroAreaEspecialidad", areaEspecialidadID);
                        command.Parameters.AddWithValue("@Direccion", direccionClinica);
                        command.Parameters.AddWithValue("@Horario", horarioActividadClinica);
                        command.Parameters.AddWithValue("@Telefono", telefonoClinica);
                        command.Parameters.AddWithValue("@CorreoElectronico", emailClinica);
                        command.Parameters.AddWithValue("@Estado", estadoClinica);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Ingresados Correctamente.");
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
        private void CmbClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeroClinica = cmbClinica.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(numeroClinica))
            {
                MessageBox.Show("Por favor, seleccione un número de clínica.");
                return;
            }

            switch (numeroClinica)
            {
                case "1":
                    txtNomCl.Text = "Clínica 1";
                    txtArea.Text = "100";
                    txtDir.Text = "Dirección 1";
                    txtHorario.Text = "8:00 - 17:00";
                    txtTelefono.Text = "123456789";
                    txtCorreo.Text = "contacto@clinica1.com";
                    txtEstado.Text = "1";
                    break;

                case "2":
                    txtNomCl.Text = "Clínica 2";
                    txtArea.Text = "200";
                    txtDir.Text = "Dirección 2";
                    txtHorario.Text = "9:00 - 18:00";
                    txtTelefono.Text = "987654321";
                    txtCorreo.Text = "contacto@clinica2.com";
                    txtEstado.Text = "0";
                    break;

                case "3":
                    txtNomCl.Text = "Clínica 3";
                    txtArea.Text = "300";
                    txtDir.Text = "Dirección 3";
                    txtHorario.Text = "7:00 - 16:00";
                    txtTelefono.Text = "555666777";
                    txtCorreo.Text = "contacto@clinica3.com";
                    txtEstado.Text = "1";
                    break;

                default:
                    txtNomCl.Clear();
                    txtArea.Clear();
                    txtDir.Clear();
                    txtHorario.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtEstado.Clear();
                    break;
            }
        }

        private void LlenarComboBox()
        {

        }

        private void MTElim_Click(object sender, EventArgs e)
        {
            {
                string clinicaID = cmbClinica.SelectedItem?.ToString().Trim();

                if (string.IsNullOrEmpty(clinicaID))
                {
                    MessageBox.Show("Por favor, seleccione un número de clínica.");
                    return;
                }

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    if (connection == null) return;

                    string query = "DELETE FROM clinica WHERE clinicaID = @ClinicaID";

                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClinicaID", clinicaID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datos Eliminados Correctamente.");
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
        }
        private void MBmod_Click(object sender, EventArgs e)
        {
            string clinicaID = cmbClinica.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(clinicaID))
            {
                MessageBox.Show("Por favor, seleccione un número de clínica.");
                return;
            }

            string nombreClinica = txtNomCl.Text.Trim();
            string areaEspecialidadID = txtArea.Text.Trim();
            string direccionClinica = txtDir.Text.Trim();
            string horarioActividadClinica = txtHorario.Text.Trim();
            string telefonoClinica = txtTelefono.Text.Trim();
            string emailClinica = txtCorreo.Text.Trim();
            string estadoClinica = txtEstado.Text.Trim();

            if (string.IsNullOrEmpty(nombreClinica) || string.IsNullOrEmpty(areaEspecialidadID) ||
                string.IsNullOrEmpty(direccionClinica) || string.IsNullOrEmpty(horarioActividadClinica) ||
                string.IsNullOrEmpty(telefonoClinica) || string.IsNullOrEmpty(emailClinica) || string.IsNullOrEmpty(estadoClinica))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "UPDATE clinica SET nombreClinica = @NombreClinica, areaEspecialidadID = @AreaEspecialidadID, direccionClinica = @DireccionClinica, " +
                               "horarioActividadClinica = @HorarioActividadClinica, telefonoClinica = @TelefonoClinica, emailClinica = @EmailClinica, estadoClinica = @EstadoClinica " +
                               "WHERE clinicaID = @ClinicaID";

                try
                {

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClinicaID", clinicaID);
                        command.Parameters.AddWithValue("@NombreClinica", nombreClinica);
                        command.Parameters.AddWithValue("@AreaEspecialidadID", areaEspecialidadID);
                        command.Parameters.AddWithValue("@DireccionClinica", direccionClinica);
                        command.Parameters.AddWithValue("@HorarioActividadClinica", horarioActividadClinica);
                        command.Parameters.AddWithValue("@TelefonoClinica", telefonoClinica);
                        command.Parameters.AddWithValue("@EmailClinica", emailClinica);
                        command.Parameters.AddWithValue("@EstadoClinica", estadoClinica);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Modificados Correctamente.");
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


        private void MBBus_Click(object sender, EventArgs e)
        {
            string clinicaID = cmbClinica.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(clinicaID))
            {
                MessageBox.Show("Por favor, seleccione un número de clínica.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                string query = "SELECT * FROM clinica WHERE clinicaID = @ClinicaID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClinicaID", clinicaID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomCl.Text = reader["nombreClinica"].ToString();
                                txtArea.Text = reader["areaEspecialidadID"].ToString();
                                txtDir.Text = reader["direccionClinica"].ToString();
                                txtHorario.Text = reader["horarioActividadClinica"].ToString();
                                txtTelefono.Text = reader["telefonoClinica"].ToString();
                                txtCorreo.Text = reader["emailClinica"].ToString();
                                txtEstado.Text = reader["estadoClinica"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos para la clínica seleccionada.");
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

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomCl_TextChanged(object sender, EventArgs e)
        {

        }

        private void MLNum_Clinic_Click(object sender, EventArgs e)
        {

        }
    }
}

