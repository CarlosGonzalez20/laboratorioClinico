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
            // Actualiza los datos del proveedor
            CargarDatosProovedor();

            // Crear la conexión a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                // Verificar si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                // Obtener el ID del proveedor desde el campo de texto
                string expedienteID = NoID.Text.Trim();

                // Validar que el ID no esté vacío
                if (string.IsNullOrEmpty(expedienteID))
                {
                    MessageBox.Show("Por favor, ingrese un número de expediente.");
                    return;
                }

                // Definir la consulta SQL para obtener los datos del proveedor
                string query = "SELECT * FROM proveedor WHERE proveedorID = @proveedorID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Asignar el parámetro de la consulta
                        command.Parameters.AddWithValue("@proveedorID", expedienteID);

                        // Ejecutar la consulta y leer los resultados
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificar si se encontró el proveedor
                            if (reader.Read())
                            {
                                // Asignar los valores a los campos correspondientes
                                Nombres.Text = reader["nombreProveedor"].ToString();
                                Fecha_Reg.Value = reader.GetDateTime("fechaRegistroProveedor");
                                Tel.Text = reader["telefonoProveedor"].ToString();
                                Dir.Text = reader["direccionProveedor"].ToString();
                                Correo.Text = reader["emailProveedor"].ToString();
                                Des.Text = reader["descripcionProveedor"].ToString();

                                // Verificar el estado del proveedor
                                string estadoProveedor = reader["estadoProveedor"].ToString();
                                Console.WriteLine($"Estado Proveedor: {estadoProveedor}"); // Para depuración

                                // Actualizar el estado del checkbox según el valor en la base de datos
                                if (estadoProveedor == "1")
                                {
                                    estatusActivo.Checked = true;
                                    estadoInactivo.Checked = false;
                                }
                                else
                                {
                                    estatusActivo.Checked = false;
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
                                // Mostrar mensaje si no se encontró el proveedor
                                MessageBox.Show("No se encontró un proveedor con ese número de expediente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores y mostrar mensaje al usuario
                    MessageBox.Show($"Error al buscar el proveedor: {ex.Message}");
                }
            }

        }

        private void ingresarPaciente_Click(object sender, EventArgs e)
        {
            // Initialize the database connection
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Check if the connection was successful

                // Create a dictionary of fields to validate and fetch values
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

                // Validate required fields
                foreach (var campo in campos)
                {
                    string valor = campo.Value.Invoke();
                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Key}' es obligatorio.");
                        return;
                    }
                }

                // Convert and validate necessary fields
                int documento;
                string telefono = campos["Teléfono"].Invoke();

                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento))
                {
                    MessageBox.Show("El campo 'Documento de Identificación' no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Registro"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string descripcion = campos["Descripción"].Invoke();
                string estados = campos["Estado"].Invoke();

                string query = "INSERT INTO proveedor (nombreProveedor, telefonoProveedor, emailProveedor, direccionProveedor, fechaRegistroProveedor, descripcionProveedor, estadoProveedor) " +
                               "VALUES (@nombreProveedor, @telefonoProveedor, @emailProveedor, @direccionProveedor, @fechaRegistroProveedor, @descripcionProveedor, @estadoProveedor)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // parametros
                        command.Parameters.AddWithValue("@nombreProveedor", nombre);
                        command.Parameters.AddWithValue("@telefonoProveedor", telefono);
                        command.Parameters.AddWithValue("@emailProveedor", Correo.Text.Trim());
                        command.Parameters.AddWithValue("@direccionProveedor", direccion);
                        command.Parameters.AddWithValue("@fechaRegistroProveedor", fechaNac);
                        command.Parameters.AddWithValue("@descripcionProveedor", descripcion);
                        command.Parameters.AddWithValue("@estadoProveedor", estados);

                       
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos ingresados correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                    MessageBox.Show($"Error al ingresar los datos: {ex.Message}");
                }
            }

            CargarDatosProovedor(); 

        }

        private void modificarPaciente_Click(object sender, EventArgs e)
        {
            // Obtener el ID del proveedor desde el campo de texto
            string idIngresado = NoID.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del proveedor que desea modificar.");
                return;
            }

            // Convertir el ID a entero
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            // Crear la conexión a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                // Verificar si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                // Definir la consulta SQL de actualización
                string query = "UPDATE proveedor SET " +
                               "nombreProveedor = @nombreProveedor, " +
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
                int telefono;
                if (!int.TryParse(campos["Teléfono"].Invoke(), out telefono))
                {
                    MessageBox.Show("El campo 'Teléfono' no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaRegistro = DateTime.Parse(campos["Fecha de Registro"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string descripcion = campos["Descripción"].Invoke();
                string estado = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@proveedorID", id);
                        command.Parameters.AddWithValue("@nombreProveedor", nombre);
                        command.Parameters.AddWithValue("@telefonoProveedor", telefono);
                        command.Parameters.AddWithValue("@emailProveedor", Correo.Text.Trim());
                        command.Parameters.AddWithValue("@direccionProveedor", direccion);
                        command.Parameters.AddWithValue("@fechaRegistroProveedor", fechaRegistro);
                        command.Parameters.AddWithValue("@descripcionProveedor", descripcion);
                        command.Parameters.AddWithValue("@estadoProveedor", estado);

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
            // Obtener el ID del proveedor desde el campo de texto
            string idIngresado = NoID.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            // Convertir el ID a entero
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            // Crear la conexión a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                // Verificar si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                // Definir la consulta SQL de actualización
                string query = "UPDATE proveedor SET estadoProveedor = 0 WHERE proveedorID = @proveedorID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro de la consulta
                        command.Parameters.AddWithValue("@proveedorID", id);

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado del proveedor se ha actualizado a inactivo.");
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
                    MessageBox.Show($"Error al actualizar el estado del proveedor: {ex.Message}");
                }
            }


        }

    }
}
