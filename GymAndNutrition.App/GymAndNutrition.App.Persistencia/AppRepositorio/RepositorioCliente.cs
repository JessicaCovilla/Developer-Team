using GymAndNutrition.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymAndNutrition.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente 
    {
        private readonly AppContext conexion;

        public RepositorioCliente(AppContext appContext)
        {
            this.conexion=appContext; 
        }

        public Cliente CrearCliente(Cliente cliente)
        {
            var clienteAdicionado=conexion.Clientes.Add(cliente);
            conexion.SaveChanges();
            return clienteAdicionado.Entity;
        }
        public  Cliente ConsultarCliente(int idCliente)
        {
            var clienteEncontrado = conexion.Clientes.FirstOrDefault(p=>p.Id==idCliente);
            if(clienteEncontrado!=null){
                return clienteEncontrado;
            }
            return null;
        }
        public IEnumerable<Cliente> ConsultarClientes()
        {
            return conexion.Clientes;
        }
        
        public Cliente ActualizarCliente(Cliente cliente)
        {
            var clienteEncontrado=conexion.Clientes.FirstOrDefault(p=>p.Id==cliente.Id);
            if(clienteEncontrado!=null){
                clienteEncontrado.Nombre=cliente.Nombre;
                clienteEncontrado.Apellido=cliente.Apellido;
                clienteEncontrado.Correo=cliente.Correo;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Contraseña=cliente.Contraseña;

                conexion.SaveChanges();
                
            }
            return clienteEncontrado;
        }
        public void EliminarCliente(int idCliente)
        {
            var clienteEncontrado=conexion.Clientes.FirstOrDefault(p=>p.Id==idCliente);
            if(clienteEncontrado==null)
            return;
            conexion.Clientes.Remove(clienteEncontrado);
            conexion.SaveChanges();

        }
            
    }
}