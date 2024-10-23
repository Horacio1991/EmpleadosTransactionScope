using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class EmpleadoDAL
    {
        private readonly ConnectionDAL connectionDAL;

        public EmpleadoDAL()
        {
            connectionDAL = new ConnectionDAL();
        }

 
        public void AgregarEmpleado(Empleado empleado)
        {
            using (SqlConnection conn = connectionDAL.GetConnection())
            {
                string query = "INSERT INTO Empleados (ApellidoNombre, DNI, SueldoBruto) VALUES (@ApellidoNombre, @DNI, @SueldoBruto)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection conn = connectionDAL.GetConnection())
            {
                string query = "SELECT Id, ApellidoNombre, DNI, SueldoBruto FROM Empleados";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado
                    {
                        Id = (int)reader["Id"],
                        ApellidoNombre = reader["ApellidoNombre"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        SueldoBruto = (decimal)reader["SueldoBruto"]
                    };

                    empleados.Add(empleado);
                }
            }

            return empleados;
        }

        
        public void GuardarEmpleados(List<Empleado> empleados)
        {
            using (SqlConnection conn = connectionDAL.GetConnection())
            {
                conn.Open();

                foreach (Empleado empleado in empleados)
                {
                    string query = "INSERT INTO Empleados (ApellidoNombre, DNI, SueldoBruto) VALUES (@ApellidoNombre, @DNI, @SueldoBruto)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                    cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                    cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
