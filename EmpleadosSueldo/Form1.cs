using BLL;
using Entity;

namespace EmpleadosSueldo
{
    public partial class Form1 : Form
    {
        // Lista para almacenar empleados en memoria
        private List<Empleado> empleadosEnMemoria;
        private EmpleadoBLL empleadoBLL;
        public Form1()
        {
            InitializeComponent();
            empleadosEnMemoria = new List<Empleado>();
            empleadoBLL = new EmpleadoBLL();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    ApellidoNombre = txtApellidoNombre.Text,
                    DNI = txtDni.Text,
                    SueldoBruto = decimal.Parse(txtSueldoBruto.Text)
                };

                empleadosEnMemoria.Add(empleado);

                MessageBox.Show("Empleado agregado a la lista en memoria.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleadosEnMemoria.Count > 0)
                {
                    empleadoBLL.GuardarEmpleados(empleadosEnMemoria);
                    MessageBox.Show("Cambios confirmados y empleados guardados en la base de datos.");
                    empleadosEnMemoria.Clear();
                }
                else
                {
                    MessageBox.Show("No hay empleados en la lista para guardar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empleados: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Empleado> empleados = empleadoBLL.ListarEmpleados();

                // lista temporal para agregar el sueldo neto a cada empleado
                var empleadosConSueldoNeto = new List<object>();

                foreach (var empleado in empleados)
                {
                    empleadosConSueldoNeto.Add(new
                    {
                        empleado.Id,
                        empleado.ApellidoNombre,
                        empleado.DNI,
                        empleado.SueldoBruto,
                        SueldoNeto = empleado.CalcularSueldoNeto() 
                    });
                }

                
                dgvEmpleados.DataSource = empleadosConSueldoNeto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados: " + ex.Message);
            }
        }

        
        private void LimpiarCampos()
        {
            txtApellidoNombre.Text = "";
            txtDni.Text = "";
            txtSueldoBruto.Text = "";
        }
    }
}
