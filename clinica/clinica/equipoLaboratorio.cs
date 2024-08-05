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
    public partial class equipoLaboratorio : MaterialSkin.Controls.MaterialForm
    {

        private void CargarDatosEquipoLab()
        {
            string query = "SELECT * FROM equipoLaboratorio";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Equipo de Laboratorio");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoEquipo.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }

        private void CargarDatosProveedor_Clinica()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para proveedor
                string proveedorQuery = "SELECT proveedorID FROM proveedor";
                MySqlCommand proveedorCommand = new MySqlCommand(proveedorQuery, connection);
                try
                {
                    MySqlDataReader proveedorReader = proveedorCommand.ExecuteReader();
                    proveedorEquipo.Items.Clear();
                    while (proveedorReader.Read())
                    {
                        int proveedorID = proveedorReader.GetInt32("proveedorID");
                        proveedorEquipo.Items.Add(proveedorID);
                    }
                    if (proveedorEquipo.Items.Count > 0)
                    {
                        proveedorEquipo.SelectedIndex = 0;
                    }
                    proveedorReader.Close();

                    // Llenar el ComboBox para clinica
                    string clinicaQuery = "SELECT clinicaID FROM clinica";
                    MySqlCommand clinicaCommand = new MySqlCommand(clinicaQuery, connection);

                    MySqlDataReader clinicaReader = clinicaCommand.ExecuteReader();
                    clinica.Items.Clear();
                    while (clinicaReader.Read())
                    {
                        int clinicaID = clinicaReader.GetInt32("clinicaID");
                        clinica.Items.Add(clinicaID);
                    }
                    if (clinica.Items.Count > 0)
                    {
                        clinica.SelectedIndex = 0;
                    }
                    clinicaReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }

        public equipoLaboratorio()
        {
            InitializeComponent();
            CargarDatosEquipoLab();
            CargarDatosProveedor_Clinica();
        }

        private void equipoLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buscarEquipo_Click(object sender, EventArgs e)
        {
            CargarDatosEquipoLab();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string equipoID = equipoNo.Text.Trim();

                if (string.IsNullOrEmpty(equipoID))
                {
                    MessageBox.Show("Por favor, ingrese un ID del equipo.");
                    return;
                }

                string query = "SELECT * FROM equipoLaboratorio WHERE equipoID = @equipoID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@equipoID", equipoID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                proveedorEquipo.SelectedItem = reader["proveedorID"].ToString();
                                clinica.SelectedItem = reader["clinicaID"].ToString();
                                nombreEquipo.Text = reader["nombreEquipo"].ToString();
                                descripcionEquipo.Text = reader["descripcionEquipo"].ToString();
                                fechaAdquisicion.Value = reader.GetDateTime("fechaAdquisicion");
                                fechaActualizacion.Value = reader.GetDateTime("fechaActualizacion");

                                // Ajuste del estado
                                int estadoEquipo = reader.GetInt32("estadoEquipo");
                                if (estadoEquipo == 1)
                                {
                                    estadoExcelente.Checked = true;
                                }
                                else if (estadoEquipo == 2)
                                {
                                    estadoBueno.Checked = true;
                                }
                                else if (estadoEquipo == 3)
                                {
                                    estadoCambiar.Checked = true;
                                }

                                cantidadEquipo.Text = reader.GetInt32("cantidad").ToString();

                                // Ajuste del estatus
                                int estatusEquipo = reader.GetInt32("estatusEquipo");
                                if (estatusEquipo == 1)
                                {
                                    estatusActivo.Checked = true;
                                }
                                else
                                {
                                    estatusInactivo.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in infoEquipo.Rows)
                                {
                                    if (row.Cells["equipoID"].Value.ToString() == equipoID)
                                    {
                                        row.Selected = true;
                                        infoEquipo.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un equipo con ese ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el equipo: {ex.Message}");
                }
            }
        }

        private void ingresarEquipo_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
            { "Proveedor", () => proveedorEquipo.SelectedItem?.ToString() },
            { "Clinica", () => clinica.SelectedItem?.ToString() },
            { "Nombre", () => nombreEquipo.Text.Trim() },
            { "Descripcion", () => descripcionEquipo.Text.Trim() },
            { "Fecha de Adquisición", () => fechaAdquisicion.Value.ToString("yyyy-MM-dd") },
            { "Fecha de Actualizacion", () => fechaActualizacion.Value.ToString("yyyy-MM-dd") },
            { "Estado del Equipo", () =>
                estadoExcelente.Checked ? "1" :
                estadoBueno.Checked ? "2" :
                estadoCambiar.Checked ? "3" :
                throw new InvalidOperationException("Debe seleccionar un estado válido.") // Lanzar una excepción si ningún estado está seleccionado
            },
            { "Cantidad", () => cantidadEquipo.Text.Trim() },
            { "Estado", () => estatusActivo.Checked ? "1" : "0" }
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

                // Convertir los valores necesarios a sus tipos correspondientes
                int proveedorID;
                int clinicaID;
                int estadoEquipo;
                int estatusEquipo;
                int cantidad;

                if (!int.TryParse(campos["Proveedor"].Invoke(), out proveedorID) ||
                    !int.TryParse(campos["Clinica"].Invoke(), out clinicaID) ||
                    !int.TryParse(campos["Estado del Equipo"].Invoke(), out estadoEquipo) ||
                    !int.TryParse(campos["Estatus"].Invoke(), out estatusEquipo) ||
                    !int.TryParse(campos["Cantidad"].Invoke(), out cantidad))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string descripcion = campos["Descripcion"].Invoke();
                DateTime fechaAd = DateTime.Parse(campos["Fecha de Adquisición"].Invoke());
                DateTime fechaAct = DateTime.Parse(campos["Fecha de Actualizacion"].Invoke());

                string query = "INSERT INTO equipoLaboratorio (proveedorID, clinicaID, nombreEquipo, descripcionEquipo, fechaAdquision, fechaActualizacion, estadoEquipo, cantidad, estatusEquipo) " +
                               "VALUES (@proveedorID, @clinicaID, @nombreEquipo, @descripcionEquipo, @fechaAdquision, @fechaActualizacion, @estadoEquipo, @cantidad, @estatusEquipo)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@proveedorID", proveedorID);
                        command.Parameters.AddWithValue("@clinicaID", clinicaID);
                        command.Parameters.AddWithValue("@nombreEquipo", nombre);
                        command.Parameters.AddWithValue("@descripcionEquipo", descripcion);
                        command.Parameters.AddWithValue("@fechaAdquisicion", fechaAd);
                        command.Parameters.AddWithValue("@fechaActualizacion", fechaAct);
                        command.Parameters.AddWithValue("@estadoEquipo", estadoEquipo);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@estatusEquipo", estatusEquipo);

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
            CargarDatosEquipoLab();

        }

        private void modificarEquipo_Click(object sender, EventArgs e)
        {
            string idIngresado = equipoNo.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del equipo que desea modificar.");
                return;
            }

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

                string query = "UPDATE equipoLaboratorio SET " +
                               "proveedorID = @proveedorID, " +
                               "clinicaID = @clinicaID, " +
                               "nombreEquipo = @nombreEquipo, " +
                               "descripcionEquipo = @descripcionEquipo, " +
                               "fechaAdquision = @fechaAdquision, " +
                               "fechaActualizacion = @fechaActualizacion, " +
                               "estadoEquipo = @estadoEquipo, " +
                               "cantidad = @cantidad, " +
                               "estatusEquipo = @estatusEquipo " +
                               "WHERE equipoID = @id";

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
    {
        { "Proveedor", () => proveedorEquipo.SelectedItem?.ToString() },
        { "Clinica", () => clinica.SelectedItem?.ToString() },
        { "Nombre", () => nombreEquipo.Text.Trim() },
        { "Descripcion", () => descripcionEquipo.Text.Trim() },
        { "Fecha de Adquisición", () => fechaAdquisicion.Value.ToString("yyyy-MM-dd") },
        { "Fecha de Actualizacion", () => fechaActualizacion.Value.ToString("yyyy-MM-dd") },
        { "Estado del Equipo", () =>
            estadoExcelente.Checked ? "1" :
            estadoBueno.Checked ? "2" :
            estadoCambiar.Checked ? "3" :
            throw new InvalidOperationException("Debe seleccionar un estado válido.")
        },
        { "Cantidad", () => cantidadEquipo.Text.Trim() },
        { "Estatus", () => estatusActivo.Checked ? "1" : "0" }
    };

                foreach (var campo in campos)
                {
                    string valor = campo.Value.Invoke();
                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Key}' es obligatorio.");
                        return;
                    }
                }

                // Convertir los valores necesarios a sus tipos correspondientes
                int proveedorID, clinicaID, estadoEquipo, estatusEquipo, cantidad;

                if (!int.TryParse(campos["Proveedor"].Invoke(), out proveedorID) ||
                    !int.TryParse(campos["Clinica"].Invoke(), out clinicaID) ||
                    !int.TryParse(campos["Estado del Equipo"].Invoke(), out estadoEquipo) ||
                    !int.TryParse(campos["Estatus"].Invoke(), out estatusEquipo) ||
                    !int.TryParse(campos["Cantidad"].Invoke(), out cantidad))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string descripcion = campos["Descripcion"].Invoke();
                DateTime fechaAd = DateTime.Parse(campos["Fecha de Adquisición"].Invoke());
                DateTime fechaAct = DateTime.Parse(campos["Fecha de Actualizacion"].Invoke());

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@proveedorID", proveedorID);
                        command.Parameters.AddWithValue("@clinicaID", clinicaID);
                        command.Parameters.AddWithValue("@nombreEquipo", nombre);
                        command.Parameters.AddWithValue("@descripcionEquipo", descripcion);
                        command.Parameters.AddWithValue("@fechaAdquision", fechaAd);
                        command.Parameters.AddWithValue("@fechaActualizacion", fechaAct);
                        command.Parameters.AddWithValue("@estadoEquipo", estadoEquipo);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@estatusEquipo", estatusEquipo);
                        command.Parameters.AddWithValue("@id", id);

                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");
                            // Opcional: Actualizar el DataGridView o cualquier otro control
                            CargarDatosEquipoLab(); // Asegúrate de definir este método para actualizar los datos
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

        private void eliminarEquipo_Click(object sender, EventArgs e)
        {
            string idIngresado = equipoNo.Text.Trim();

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

            string query = "UPDATE equipoLaboratorio SET estadoEspecialidad = @estado WHERE equipoID = @id";
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
                        // Se establece el estado a 0, puedes cambiar este valor si es necesario
                        command.Parameters.AddWithValue("@estado", 0);
                        command.Parameters.AddWithValue("@id", id);

                        int filasAfectadas = command.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado de la especialidad se ha actualizado a inactivo.");
                            CargarDatosEquipoLab(); // Asegúrate de definir este método para actualizar los datos
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado de la especialidad: {ex.Message}");
                }
            }
        }
    }
}
