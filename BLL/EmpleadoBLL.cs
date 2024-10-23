using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class EmpleadoBLL
    {
        private readonly EmpleadoDAL empleadoDAL;

        public EmpleadoBLL()
        {
            empleadoDAL = new EmpleadoDAL();
        }

        private void ValidarEmpleado(Empleado empleado)
        {
            if (empleado.ApellidoNombre.Length < 5)
                throw new Exception("El Apellido y Nombre debe tener más de 5 caracteres.");

            if (empleado.DNI.Length != 8) // Suponiendo que el DNI debe ser de 8 caracteres
                throw new Exception("El DNI debe tener exactamente 8 caracteres."); // Ajustado a 8 caracteres.

            if (empleado.SueldoBruto < 100000)
                throw new Exception("El sueldo bruto no puede ser menor al salario mínimo vital y móvil ($100,000).");
        }

        // No uso bloque transaccional porque no es necesario ya que solo se agrega un empleado
        // de forma local en la memoria (en este caso en particular que no va a modficarse el codigo a futuro)
        public void AgregarEmpleado(Empleado empleado)
        {
            try
            {
                ValidarEmpleado(empleado);
                empleadoDAL.AgregarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el empleado: " + ex.Message);
            }
        }

        // Método para listar empleados desde la base de datos
        // aca si uso bloque transaccional porque se listan empleados en la base de datos
        public List<Empleado> ListarEmpleados()
        {
            try
            {
                return empleadoDAL.ListarEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar empleados: " + ex.Message);
            }
        }

        // Método para guardar la lista de empleados usando transacciones
        public void GuardarEmpleados(List<Empleado> empleados)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    foreach (var empleado in empleados)
                    {
                        ValidarEmpleado(empleado);
                    }

                    empleadoDAL.GuardarEmpleados(empleados);

                    // Si todo va bien, confirmar la transacción
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    // Si hay una excepcion, la transaccipn se revierte automáticamente
                    throw new Exception("Error al guardar los empleados: " + ex.Message);
                }
            }
        }
    }
}
