using System;
using System.Collections.Generic;
using CapaDatos;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionCliente
    {
        public GestionCliente()
        {
            PersistenciaClientes.ListaClientes = new List<Cliente>();
        }

        public void GuardarCliente(string cedula, string nombres, string apellidos, int edad, string usuario, string contrasenia)
        {
            PersistenciaClientes.GuardarCliente(new Cliente(cedula, nombres, apellidos,edad, usuario, contrasenia));
        }

        public string ListarUsuarios()
        {
            return "CEDULA\t\t\tNOMBRES\t\tAPELLIDOS\t\tEDAD\n" + PersistenciaClientes.RetornarClientesEnString();
        }

        public string ClientesOrdenados()
        {
            return PersistenciaClientes.OrdenarAlfabeticamente();
        }
        public string MayoresClientes()
        {
            return PersistenciaClientes.ClientesMayoresEdad();
        }
        public string ClientesIngresados(string buscar)
        {
            return PersistenciaClientes.IngresarApellido(buscar);
        }
        public string ClienteMayor()
        {
            return PersistenciaClientes.ClienteMayorEdad();
        }
        public string PromedioCliente()
        {
            return PersistenciaClientes.PromedioEdad();
        }
    }
}