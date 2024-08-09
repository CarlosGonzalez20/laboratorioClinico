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
    public partial class Cambio_de_Contraseña : MaterialSkin.Controls.MaterialForm
    {

        private string ContraAleatoria(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            StringBuilder passbuild = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                passbuild.Append(validChars[index]);
            }

            return passbuild.ToString();
        }

        public Cambio_de_Contraseña()
        {
            InitializeComponent();
        }

        private void Cambio_de_Contraseña_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Define el tamaño de la contraseña
            int contratamaño = 15;

            // Genera contraseña aleatoria
            string Nuevacontras = ContraAleatoria(contratamaño);

            // La muestra en el texbox
            nuevacontra.Text = Nuevacontras;
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string correo = usuario.Text.Trim();
            string contrasenaActual = anterior.Text.Trim();
            string nuevaContrasena = nuevacontra.Text.Trim();
            string confirmarContrasena = confirmarcontra.Text.Trim();

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasenaActual) ||
                string.IsNullOrEmpty(nuevaContrasena) || string.IsNullOrEmpty(confirmarContrasena))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que las contraseñas nuevas coincidan
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conectar a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                // Verificar si el correo y la contraseña actual son correctos
                string verificarQuery = "SELECT COUNT(*) FROM login WHERE correo = @correo AND contrasena = @contrasenaActual";
                using (MySqlCommand verificarCommand = new MySqlCommand(verificarQuery, connection))
                {
                    verificarCommand.Parameters.AddWithValue("@correo", correo);
                    verificarCommand.Parameters.AddWithValue("@contrasenaActual", contrasenaActual);

                    int usuarioExistente = Convert.ToInt32(verificarCommand.ExecuteScalar());

                    if (usuarioExistente == 0)
                    {
                        MessageBox.Show("Correo o contraseña actual incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Definir la consulta SQL para actualizar la contraseña
                string actualizarQuery = "UPDATE login SET contrasena = @nuevaContrasena WHERE correo = @correo AND contrasena = @contrasenaActual";

                try
                {
                    using (MySqlCommand actualizarCommand = new MySqlCommand(actualizarQuery, connection))
                    {
                        // Agregar los parámetros de la consulta
                        actualizarCommand.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                        actualizarCommand.Parameters.AddWithValue("@correo", correo);
                        actualizarCommand.Parameters.AddWithValue("@contrasenaActual", contrasenaActual);

                        // Ejecutar la consulta
                        int filasAfectadas = actualizarCommand.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
