using System;
using System.Linq;
using CapaNegocios;

namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tLista de Clientes\t");
            GestionCliente cliente = new GestionCliente();
            cliente.GuardarCliente("1112223334", "Michael Jackson", "Zambrano Zambrano", 19,"michael@email.ec", "123\t");
            cliente.GuardarCliente("2223334445", "Juana Maria", "      Pueblo Zambrano\t",          17, "juana@mail.com", " 123\t");
            cliente.GuardarCliente("7631715533", "Ana Lucia", "      Mendoza Loor\t",          25, "ana@mail.com", "   113\t");
            cliente.GuardarCliente("1052583264", "Ester Luz", "      Cedeño Macias\t",         14, "ester@mail.com", " 123\t");
            cliente.GuardarCliente("3456277848", "Maria Jose", "      Pincay Mendoza\t",         29, "maria@mail.com", " 193\t");
            cliente.GuardarCliente("2555917700", "Juan Gustavo", "      Alcivar Solorzano", 16, "juan@mail.com", "  333\t");
            cliente.GuardarCliente("7167431542", "Erick Junior", "      Meza Macias\t",         30, "erickj@mail.com", " 443\t");
            cliente.GuardarCliente("3454456056", "Angel Alexander", "Perez Delgado\t",         26, "angel@mail.com", " 143\t");
            cliente.GuardarCliente("3786346056", "Miguel Angel", "      Barcia Calle\t",         36, "miguel@mail.com", " 153\t");
            cliente.GuardarCliente("1316645892", "Rogelio Steven", "Vera Mero\t", 24, "rogelio@mail.com", " 163\t");
            Console.WriteLine(cliente.ListarUsuarios());
            Console.ReadLine();
            Console.Clear();

            //GestionProductos producto = new GestionProductos();
            //Console.WriteLine(producto.ListarProductos());
            //GRUPO 1
            //Utilizando expresiones lambda o linq cree los métodos en las capas respectivas que permitan mostrar por pantalla:
            //1) Los clientes ordenados alfabeticamente de A a Z. (1 Puntos)
            Console.WriteLine("*Clientes Ordenados Alfabeticamente*");
            Console.WriteLine(cliente.ClientesOrdenados());
            Console.ReadLine();
            Console.Clear();
            //2) Los clientes mayores de 18 años ordenados alfabeticamente de Z a A. (2 Puntos)
            Console.WriteLine("*Los Cliente mayores de 18 ordenados alfabeticamentes son*");
            // Console.WriteLine(cliente.MayoresClientes());
            Console.WriteLine(cliente.MayoresClientes());
            Console.ReadLine();
            Console.Clear();
            //3) El cliente cuyo apellido sea un parametro ingresado por el usuario a traves del teclado. (2 Puntos)
            Console.WriteLine("*Cliente ingresado por el usuario*");
            Console.WriteLine("INGRESE LOS DOS APELLIDO DEL CLIENTE A BUSCAR: ");
            string buscar = Console.ReadLine();
            Console.WriteLine("Cliente que Ingreso segun el apellido: "+cliente.ClientesIngresados(buscar));
            Console.ReadLine();
            Console.Clear();
            //4) El cliente de mayor edad. (2 Puntos)
            Console.WriteLine("*El Cliente con mayor Edad es*");
            Console.WriteLine(cliente.ClienteMayor());
            Console.ReadLine();
            Console.Clear();
            //5) El promedio de edad de los clientes. (1 Puntos)
            Console.WriteLine("*El Promedio de edad de los Clientes es de*");
            Console.WriteLine("El Promedio total es: " + cliente.PromedioCliente());
            Console.ReadLine();
        }


    }
}
