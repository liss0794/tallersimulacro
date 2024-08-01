namespace tallersimulacro.Models
{
    public class Empresa
    { 
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Empleado> ListaEmpleados = new List<Empleado>();
        public List<Cliente> ListaClientes = new List<Cliente>();

        public Empresa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;

        }


        public void AgregarCliente(){
            Console.WriteLine($"Por favor ingrese el nombre");
            string? nombre = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el apellido");
            string? apellido = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el numero de identificacion");
            int edad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Por favor ingrese el correo electronico");
            string? email = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el telefono");
            string? telefono = Console.ReadLine();

            Cliente cliente = new Cliente(nombre, apellido, edad, email, telefono);
            ListaClientes.Add(cliente);
        }


        public void EliminarCliente()
        {
            Console.WriteLine(@$"
            Ingrese el nombre del cliente que desea eliminar
            ");
            string nombreeliminar = Console.ReadLine();

            Console.WriteLine(@$"
            Ahora ingrese el apellido del cliente que desea eliminar
            ");
            string apellidoeliminar = Console.ReadLine();

            if (nombreeliminar == null || apellidoeliminar == null)
            {
                Console.WriteLine(@$"
            Por favor llene los campos
            ");
            }

            foreach (var cliente in this.ListaClientes)
            {
                if (cliente.Nombre == nombreeliminar && cliente.Apellido == apellidoeliminar)
                {
                    ListaClientes.Remove(cliente);
                    Console.WriteLine($"El cliente  {nombreeliminar } {apellidoeliminar} ha sido eliminado");
                    return;
                }
            }

            Console.WriteLine($"No se encontro el cliente  {nombreeliminar } {apellidoeliminar}.");
        }

        public void MostrarTodosLosClientes()
        {

            Console.WriteLine(@$"
            A continuacion podra encontrar la lista completa de clientes
            *************************************************************
            ");
            foreach (var cliente in ListaClientes)
            {
                Console.WriteLine(cliente.Nombre);
            }
        }



        public void AgregarEmpleado()
        {
            Console.WriteLine($"Por favor ingrese el nombre");
            string? nombre = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el apellido");
            string? apellido = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el numero de identificacion");
            string? documento = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese la edad");
            byte edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Por favor ingrese la posicion del empleado en la empresa");
            string? posicion = Console.ReadLine();

            Console.WriteLine($"Por favor ingrese el salario mensual del empleado");
            double salario = Convert.ToDouble(Console.ReadLine());


            Empleado empleado = new Empleado(nombre, apellido, edad, documento, posicion, salario);
            ListaEmpleados.Add(empleado);
        }

        public void EliminarEmpleado()
        {
            Console.WriteLine(@$"
            Ingrese el numero de identificacion del empleado que desea eliminar
            ");
            string eliminar = Console.ReadLine();
            if (eliminar == null)
            {
                Console.WriteLine(@$"
            Por favor llene el campo
            ");
            }

            foreach (var empleado in this.ListaEmpleados)
            {
                if (eliminar == empleado.Documento)
                {
                   
                   ListaEmpleados.Remove(empleado);
                }
            }
        }


        public void MostrarTodosLosEmpleados()
        {

            Console.WriteLine(@$"
            A continuacion podra encontrar la lista completa de empleados
            *************************************************************
            ");
            foreach (var item in ListaEmpleados)
            {
                Console.WriteLine(item.Nombre);
            }
        }

         public void ActualizarEmpleado()
        {
            Console.WriteLine(@$"
            Actualizacion de la lista
            *****************************************************
            Ingrese el numero de identificacion del empleado que desea actualizar
            ");
            string actualizar = Console.ReadLine();
            if (actualizar == null)
            {
                Console.WriteLine(@$"Por favor llene el campo");
                }
                foreach (var empleado in this.ListaEmpleados)
                {
                    if (actualizar == empleado.Documento)
                    {
                        Console.WriteLine(@$"Ingrese el nuevo nombre del empleado");
                        string nombre = Console.ReadLine();
                        Console.WriteLine(@$"Ingrese el nuevo salario del empleado");
                        string salario = Console.ReadLine();
                        Console.WriteLine(@$"Ingrese el nuevo cargo del empleado");
                        string cargo = Console.ReadLine();
                        empleado.Nombre = nombre;
                        empleado.Salario = Convert.ToDouble(salario);
                        empleado.Posicion = cargo;
                        }
                        }

        }


        public void BuscarEmpleado()
        {
            Console.WriteLine(@$"
            Ingrese el numero de documento del empleado que busca
            *****************************************************
            ");
            string buscar = Console.ReadLine();
            if (buscar == null)
             { Console.WriteLine(@$"Por favor llene el campo"); }
             else
             {
                foreach (var item in ListaEmpleados)
                {
                    if (buscar == item.Documento)
                    { Console.WriteLine(item.Nombre); }
                    }
                    }

        }


        public void MostrarEmpleadoPorCargo()
        {
            Console.WriteLine(@$"
            Ingrese el cargo que busca
            ***************************
            ");
            string cargo = Console.ReadLine();
            foreach (var item in ListaEmpleados)
            {
                if (item.Posicion == cargo) 
                
                Console.WriteLine(item.Nombre);
                }
        }

    }
}