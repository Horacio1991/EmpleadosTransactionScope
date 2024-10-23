namespace Entity
{
    public class Empleado
    {
       
        public int Id { get; set; }
        public string ApellidoNombre { get; set; }
        public string DNI { get; set; }
        public decimal SueldoBruto { get; set; }

      
        public decimal CalcularSueldoNeto()
        {
            // Descontamos el 17% en concepto de impuestos
            return SueldoBruto * 0.83m;
        }
    }
}
