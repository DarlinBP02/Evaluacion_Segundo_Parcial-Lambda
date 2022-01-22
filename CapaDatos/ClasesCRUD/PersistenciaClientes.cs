using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaClientes
    {
        public static List<Cliente> ListaClientes { get; set; }
        //CRUD
        //CREATE
        public static void GuardarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        //UPDATE
        public static void ModificarCliente(string cedula, string nombres, string apellidos, int edad)
        {
            Cliente cliente = ListaClientes.Find(x => x.Cedula == cedula);
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
            cliente.Edad = edad;

        }

        //DELETE
        public static void EliminarCliente(string cedula)
        {
            ListaClientes.RemoveAll(cliente => cliente.Cedula == cedula);
        }

        //READ
        //UN OBJETO
        public static Cliente BuscarCliente(string cedula)
        {

            return ListaClientes.Find(cliente => cliente.Cedula == cedula);
        }


        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
        public static string RetornarClientesEnString()
        {
            return ListaClientes.Aggregate("", (acumulador, cliente) => acumulador += $"{cliente.Cedula} \t {cliente.Nombres} \t {cliente.Apellidos} \t {cliente.Edad}\n");
        }

        public static string Apellido(decimal valor)
        {

            return string.Join(" ", ListaClientes.Select(ver => $"{ ver.Apellidos}\t {ver.Nombres}\n"));
        }
        public static string OrdenarAlfabeticamente()
        {
            List<string> orden = (from dato in ListaClientes
                                        orderby dato.Nombres ascending
                                        select  dato.Nombres+" "+dato.Apellidos ).ToList();

            return string.Join("\n", orden);

        }
        public static string ClientesMayoresEdad()
        {

            var rango = ListaClientes.Where(x => x.Edad >= 18).Select(ver => $"{ ver.Nombres}\t {ver.Apellidos}\n").OrderBy(x=>x).ToList();
            return string.Join("", rango);
        }
        public static string IngresarApellido(string buscar)
        {
            var ingresar = ListaClientes.Where(a => a.Apellidos == buscar).Select(ver => ver.Nombres + ver.Apellidos).ToList();
            return string.Join("", ingresar);
        }
        public static string ClienteMayorEdad()
        {
            var mayor = ListaClientes.OrderByDescending(cliente => cliente.Edad).Select(ver => $" {ver.Nombres+ver.Apellidos} con la edad de: {ver.Edad} ").First();
            return string.Join("", mayor);
        }
        public static string PromedioEdad()
        {
            return string.Join(" ", ListaClientes.Average(promed => promed.Edad));
        }


    }
}
