namespace tallersimulacro.Models
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }


        public Cliente(string nombre, string apellido, int edad, string email, string telefono) : base(nombre, apellido, edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
            Telefono = telefono;
        }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(@$"
         Correo electronico : {Email}
         Telefono : {Telefono}
        ");
        }


    }
}