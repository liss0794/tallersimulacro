namespace tallersimulacro.Models
{
    public class Empleado : Persona
    {
        public Guid Id { get; set;}
        public string Documento {get; set;}
        public string Posicion { get; set; }
        public double Salario { get; set; }


        public Empleado(string nombre, string apellido, int edad, string documento, string posicion, double salario) : base(nombre, apellido, edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Documento = documento;
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificacion(double bonificacion)
        {

            return bonificacion * 0.1;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(@$"
         Salario : {Salario}
         Posicion : {Posicion}
         La bonificacion del 10% es de: {CalcularBonificacion(Salario)}
        Y el total es de : {Salario + CalcularBonificacion(Salario)}");

            // Console.WriteLine(@$"
            // Informacion
            // Nombre completo : {Nombre} {Apellido}.
            // Numero de documento : {NumeroIdentificacion} 
            // El salario mensual es de: {Salario} 
            // La bonificacion del 10% es de: {CalcularBonificacion(Salario)}
            // Y el total es de : {Salario + CalcularBonificacion(Salario)}
            // ");
        }








    }
}