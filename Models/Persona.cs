namespace tallersimulacro.Models
{
    public class Persona
    {
        public string Nombre {get; set; }
        public string Apellido {get; set; }
        public int Edad {get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;

        }

        public virtual void MostrarInformacion(){

        Console.WriteLine(@$"
        Informacion
        Nombre completo : {Nombre} {Apellido}. 
        Edad: {Edad} 
        
        ");
    }




    }
}