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

namespace clinica
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llenarComboArea()
        {
            List<string> items = new List<string> { "Pacientes", "Médicos", "Clínicas", "Agregar más", "Médicos 2"};
            areaUsuario.Items.Clear();
            foreach (var item in items)
            {
                areaUsuario.Items.Add(item);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            llenarComboArea();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (areaUsuario.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona un elemento del combo box.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItem = areaUsuario.SelectedItem.ToString();

                switch (selectedItem)
                {
                    case "Pacientes":
                        datosPaciente formA = new datosPaciente();
                        formA.Show();
                        break;
                    case "Médicos":
                        facturacion formB = new facturacion();
                        formB.Show();
                        break;
                    case "Médicos 2":
                        Medicos formC = new Medicos();
                        formC.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
