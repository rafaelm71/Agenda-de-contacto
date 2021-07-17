using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AgendaTelefonica
{
    class Class1
    {
#region declarasion de variables
        public static StreamReader LeerArchivo;
        public static StreamWriter EscribirArchivo;
        public string linea = "";
        public string Opcion;
        public string Dui;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Estado;
        public string Pais;
        public string CorreoElectronico;
        public string Nacionalidad;
        public string Sexo="";
        //public int Dui2;
        public String DATOS;
        //public int MENU;
        public bool re = false,ree=false;
        int Edad, Bandera, Telefono, CodigoPostal;
#endregion
        public void Ingresar()
        {

            do
            {
                 //limpia la consola
                Console.Clear();
                 //Abre el archivo Agenda.txt para agregar nuevos datos
                EscribirArchivo = new StreamWriter("Agenda.txt", true);
                 //Pedir que digite los datos para almacenarlos en el archivo Agenda.txt
                #region PedirDatos
                 //Validacion del dui para que asecte solo 8 digitos
                do {

                    Console.WriteLine("Digite número de cedula sin guiones:");
                    Dui = Console.ReadLine();
                    int Digitos = Dui.Length;
                    ree = (Digitos == 9);
                    if (ree == false)
                    {
                        Console.WriteLine("Nesesita solo 9 Digitos");
                    }


                } while (ree == false);
                //Validacion del nombre para que no queda en blanco
                do{
                    
                    Console.WriteLine("Digite el nombre:");
                    Nombre = Console.ReadLine();
                    if (Nombre == "")
                    {
                       
                    Console.WriteLine("El nombre es obligatorio");
                    }
                } while (Nombre == "");
                //Validacion del apellido para que no queda en blanco
                do
                {
                    Console.WriteLine("Digite el apellido:");
                    Apellido = Console.ReadLine();
                    if (Apellido == "")
                    {

                        Console.WriteLine("El apellido es obligatorio");
                    }

                } while (Apellido == "");
                //validacion de la edad solo numeros
                do
                {
                    try
                    {

                        Console.WriteLine("Digite la edad:");
                         Edad = int.Parse(Console.ReadLine());
                        Bandera = 1;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Dato no valido, vuelva a ingresar la edad del contacto");
                     
                        Bandera = 0;

                    }

                } while (Bandera == 0);


                //Validando la direccion para que no quede en blanco
                do
                {

                    Console.WriteLine("Digite la direccion:");
                    Direccion = Console.ReadLine();
                    if (Direccion == "")
                    {
                        Console.WriteLine("La dirección es obligatoria");
                    }

                } while (Direccion == "");
                //Validando el estado para que no queden en blanco
                do
                {
                    Console.WriteLine("Digite el estado:");
                    Estado = Console.ReadLine();
                    if (Estado == "")
                    {

                        Console.WriteLine("El estado es obligatorio");
                    }

                } while (Estado == "");
                //validando el pais para que no quede en blanco
                do
                {
                    Console.WriteLine("Digite su pais:");
                    Pais = Console.ReadLine();
                    if (Pais == "")
                    {

                        Console.WriteLine("El país es obligatorio");
                    }

                } while (Pais == "");

                //Validandando el ingreso del teléfono
                do
                {
                    try
                    {

                        Console.WriteLine("Digite número de Telefono:");
                      Telefono = int.Parse(Console.ReadLine());
                        Bandera = 1;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Dato no válido, vuelva a ingresar el teléfono del contacto");
                    
                        Bandera = 0;

                    }

                } while (Bandera == 0);


                //Validando el ingreso del codigo postal

                do
                {
                    try
                    {

                        Console.WriteLine("Digite código postal:");
                    CodigoPostal = int.Parse(Console.ReadLine());
                        Bandera = 1;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Dato no válido, vuelva a ingresar el código postal del contacto");

                        Bandera = 0;

                    }

                } while (Bandera == 0);

                //Validando el ingreso del correo electronico para que no quede en blanco
                do
                {
                    Console.WriteLine("Digite su Correo Electronico:");
                    CorreoElectronico = Console.ReadLine();

                    if (CorreoElectronico == "")
                    {

                        Console.WriteLine("El correo electronico es obligatorio, si no posee escriba sc");
                    }
                } while (CorreoElectronico == "");

                //Valindando el ingreso del sexo del contacto
                do
                {
                    Console.WriteLine("Digite su  Sexo (M o F):");
                   Sexo = Console.ReadLine();
                    re = (Sexo == "M" || Sexo == "F" );

                    if (re == false)
                    {

                        Console.WriteLine("Opcion no valida");
                    }
                } while (re == false);

                //validando nacionalidad para que no quede en blanco
                do
                {
                    Console.WriteLine("Digite nacionalidad:");
                    Nacionalidad = Console.ReadLine();
                    if (Nacionalidad == "")
                    {

                        Console.WriteLine("La nacionalidad es obligatoria");
                    }
                } while (Nacionalidad == "");
#endregion

                //Guardando cada uno de los datos ingresados en el archivo de texto
                #region Guaedar
                EscribirArchivo.WriteLine("Dui: " + Dui);
               

                EscribirArchivo.WriteLine("Nombre: " + Nombre);
               

                EscribirArchivo.WriteLine("Apellido: " + Apellido);
              

                EscribirArchivo.WriteLine("Edad: " + Edad);
               

                EscribirArchivo.WriteLine("Direccion: " + Direccion);
              

                EscribirArchivo.WriteLine("Estado: " + Estado);
            

                EscribirArchivo.WriteLine("Pais: " + Pais);
             

                EscribirArchivo.WriteLine("Telefono: " + Telefono);
           

                EscribirArchivo.WriteLine("Codigo Postal: " + CodigoPostal);
             

                EscribirArchivo.WriteLine("Correo Electronico: " + CorreoElectronico);
           

                EscribirArchivo.WriteLine("Sexo: " + Sexo);
               

                EscribirArchivo.WriteLine("Nacionalidad: " + Nacionalidad);
               

#endregion

                #region espacios
                EscribirArchivo.WriteLine("          ");
                Console.WriteLine();
                EscribirArchivo.WriteLine("------------------------------------------------");
                Console.WriteLine();
                EscribirArchivo.WriteLine("          ");
                Console.WriteLine();

 #endregion 
//Cerrar el Archivo Agenda.txt
                Console.WriteLine("DATOS REGISTRADOS");
                EscribirArchivo.Close();

//Preguntar si ingresara otro registro
                #region Ingresar Otro Registro
                do
                {
                    Console.WriteLine("Desea ingresar otro registro? (S/N)");
                    Opcion = Console.ReadLine();
                    re = (Opcion == "S" || Opcion == "s" || Opcion == "N" || Opcion == "n");

                    if (re == false)
                    {

                        Console.WriteLine("Opcion no valida");
                    }
                } while (re == false);
 #endregion 
            } while (Opcion == "S" || Opcion == "s");
//Mostrar los datos registrados

            Dui = "Dui: " + Dui;
            #region Mostrar Datos Ingresados
            if (Opcion == "N" || Opcion == "n") { 
                LeerArchivo = new StreamReader("Agenda.txt", true);
            while (LeerArchivo.EndOfStream == false)
            {
                linea = LeerArchivo.ReadLine();

                if (Dui == linea)
                {
                    Console.WriteLine("DATOS PERSONALES");
                    Console.WriteLine(Dui);

                    for (int i = 1; i <= 12; i++)

                    {

                        Console.WriteLine(LeerArchivo.ReadLine());

                    }


                }


            }
            LeerArchivo.Close();
            }
            #endregion

        }
    }
}
