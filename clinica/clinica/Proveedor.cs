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
    public partial class Proveedor : MaterialSkin.Controls.MaterialForm
    {
        private void CargarDatosProovedor()
        {
            string query = "SELECT * FROM proveedor";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Proveedores");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoProv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de los proveedores: {ex.Message}");
                }
            }
        }
        public Proveedor()
        {
            InitializeComponent();
            CargarDatosProovedor();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buscarPaciente_Click(object sender, EventArgs e)
        {
            CargarDatosProovedor();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string expedienteID = NoID.Text.Trim();

                if (string.IsNullOrEmpty(expedienteID))
                {
                    MessageBox.Show("Por favor, ingrese un número de expediente.");
                    return;
                }

                string query = "SELECT * FROM proveedor WHERE proveedorID = @proveedorID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@proveedorID", expedienteID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Nombres.Text = reader["nombreProveedor"].ToString();
                                Apellidos.Text = reader["apellidoProveedor"].ToString();
                                Fecha_Reg.Value = reader.GetDateTime("fechaRegistroProveedor");
                                Tel.Text = reader["telefonoProveedor"].ToString();
                                Dir.Text = reader["direccionProveedor"].ToString();
                                Correo.Text = reader["emailProveedor"].ToString();
                                Des.Text = reader["descripcionProveedor"].ToString();

                                string estadoPaciente = reader["estadoProveedor"].ToString();
                                Console.WriteLine($"Estado Proveedor: {estadoPaciente}"); // Para depuración
                                if (estadoPaciente == "true")
                                {
                                    estatusActivo.Checked = true;
                                }
                                else if (estadoPaciente == "false")
                                {
                                    estadoInactivo.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in infoProv.Rows)
                                {
                                    if (row.Cells["proveedorID"].Value.ToString() == expedienteID)
                                    {
                                        row.Selected = true;
                                        infoProv.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un proveedor con ese número de expediente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el proveedor: {ex.Message}");
                }
            }
        }

        private void ingresarPaciente_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "Documento de Identificación", () => NoID.Text.Trim() },
                    { "Nombre", () => Nombres.Text.Trim() },
                    { "Apellido", () => Apellidos.Text.Trim() },
                    { "Fecha de Registro", () => Fecha_Reg.Value.ToString("yyyy-MM-dd") },
                    { "Teléfono", () => Tel.Text.Trim() },
                    { "Correo", () => Correo.Text.Trim() },
                    { "Dirección", () => Dir.Text.Trim() },
                    { "Descripción", () => Des.Text.Trim() },
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
                int documento;
                int telefono;
                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Teléfono"].Invoke(), out telefono))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Registro"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string descripcion = campos["Descripción"].Invoke();
                string estados = campos["Estado"].Invoke();
                string query = "INSERT INTO proveedor (proveedorID, nombreProveedor, apellidoProveedor, telefonoProveedor, emailProveedor, direccionProveedor, fechaRegistroProveedor, descripcionProveedor, estadoProveedor) " +
                               "VALUES (@proveedorID, @nombreProveedor, @apellidoProveedor, @telefonoProveedor, @emailProveedor, @direccionProveedor, @fechaRegistroProveedor, @descripcionProveedor, @estadoProveedor)";


                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@proveedorID", documento);
                        command.Parameters.AddWithValue("@apellidoProveedor", nombre);
                        command.Parameters.AddWithValue("@apellidoPaciente", apellido);
                        command.Parameters.AddWithValue("@fechaRegistroProveedor", fechaNac);
                        command.Parameters.AddWithValue("@telefonoProveedor", telefono);
                        command.Parameters.AddWithValue("@emailProveedor", Correo.Text.Trim());
                        command.Parameters.AddWithValue("@direccionProveedor", direccion);
                        command.Parameters.AddWithValue("@descripcionProveedor", descripcion);
                        command.Parameters.AddWithValue("@estadoProveedor", estados);

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
            CargarDatosProovedor();
        }

        private void modificarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = NoID.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del proveedor que desea modificar.");
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

                // Definir la consulta SQL de actualización
                string query = "UPDATE proveedor SET " +
                               "nombreProveedor = @nombreProveedor, " +
                               "apellidoProveedor = @apellidoProveedor, " +
                               "telefonoProveedor = @telefonoProveedor, " +
                               "emailProveedor = @emailProveedor, " +
                               "direccionProveedor = @direccionProveedor, " +
                               "fechaRegistroProveedor = @fechaRegistroProveedor, " +
                               "descripcionProveedor = @descripcionProveedor, " +
                               "estadoProveedor = @estadoProveedor " +
                               "WHERE proveedorID = @proveedorID";


                // Validar los campos
                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
                    { "Documento de Identificación", () => NoID.Text.Trim() },
                    { "Nombre", () => Nombres.Text.Trim() },
                    { "Apellido", () => Apellidos.Text.Trim() },
                    { "Fecha de Registro", () => Fecha_Reg.Value.ToString("yyyy-MM-dd") },
                    { "Teléfono", () => Tel.Text.Trim() },
                    { "Correo", () => Correo.Text.Trim() },
                    { "Dirección", () => Dir.Text.Trim() },
                    { "Descripción", () => Des.Text.Trim() },
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
                int documento;
                int telefono;
                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Teléfono"].Invoke(), out telefono))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Registro"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string descripcion = campos["Descripción"].Invoke();
                string estados = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@proveedorID", documento);
                        command.Parameters.AddWithValue("@apellidoProveedor", nombre);
                        command.Parameters.AddWithValue("@apellidoPaciente", apellido);
                        command.Parameters.AddWithValue("@fechaRegistroProveedor", fechaNac);
                        command.Parameters.AddWithValue("@telefonoProveedor", telefono);
                        command.Parameters.AddWithValue("@emailProveedor", Correo.Text.Trim());
                        command.Parameters.AddWithValue("@direccionProveedor", direccion);
                        command.Parameters.AddWithValue("@descripcionProveedor", descripcion);
                        command.Parameters.AddWithValue("@estadoProveedor", estados);

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");

                            // Opcional: Actualizar el DataGridView
                            CargarDatosProovedor();
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
        private void eliminarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = NoID.Text.Trim();

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

            string query = "UPDATE proveedor SET estadoProveedor = 0 WHERE proveedorID = @id";
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
                            MessageBox.Show("El estado del proveedor se ha actualizado a inactivo.");
                            CargarDatosProovedor();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del proveedor: {ex.Message}");
                }
            }

        }

    }
}
