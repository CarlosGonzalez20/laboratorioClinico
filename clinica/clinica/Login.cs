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
            List<string> items = new List<string> { "Pacientes", "Médicos", "Clínicas","Solicitud Cita", "Empleados","Tipo Empleado","Cargo Per. Lab.","Detalle Factura","Equipo Laboratorio","Area Especialidad","Género","Laboratorio","Medicina","Muestras","Personal Lab.","Proveedores"};
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
                        datosPaciente paciente = new datosPaciente();
                        paciente.Show();
                        break;
                    case "Médicos":
                        Medico medico = new Medico();
                        medico.Show();
                        break;
                    case "Clínicas":
                        Clinica clinica = new Clinica();
                        clinica.Show();
                        break;
                    case "Solicitud Cita":
                        SOLICITUD_DE_CITAS solicitudCita = new SOLICITUD_DE_CITAS();
                        solicitudCita.Show();
                        break;
                    case "Empleados":
                        Empleado empleado = new Empleado();
                        empleado.Show();
                        break;
                    case "Tipo Empleado":
                        tipoEmpleado tipoEmpleado = new tipoEmpleado();
                        tipoEmpleado.Show();
                        break;
                    case "Cargo Per. Lab.":
                        Cargo cargoPerLab = new Cargo();
                        cargoPerLab.Show();
                        break;
                    case "Detalle Factura":
                        DetalleFactura detalleFactura = new DetalleFactura();
                        detalleFactura.Show();
                        break;
                    case "Equipo Laboratorio":
                        equipoLaboratorio equipoLab = new equipoLaboratorio();
                        equipoLab.Show();
                        break;
                    case "Area Especialidad":
                        Especialidad areaEspecialidad = new Especialidad();
                        areaEspecialidad.Show();
                        break;
                    case "Género":
                        Genero genero = new Genero();
                        genero.Show();
                        break;
                    case "Laboratorio":
                        Laboratorio laboratorio = new Laboratorio();
                        laboratorio.Show();
                        break;
                    case "Medicina":
                        Medicina medicina = new Medicina();
                        medicina.Show();
                        break;
                    case "Muestras":
                        MUESTRAS muestras = new MUESTRAS();
                        muestras.Show();
                        break;
                    case "Personal Lab.":
                        Personal personalLab = new Personal();
                        personalLab.Show();
                        break;
                    case "Proveedores":
                        Proveedor proveedores = new Proveedor();
                        proveedores.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambiarContraseña_Click(object sender, EventArgs e)
        {
            Cambio_de_Contraseña cambio = new Cambio_de_Contraseña();
            cambio.Show();
        }
    }
}
