using System;
using System.Collections.Generic;
using System.Linq;
using crud.Models;
using crud.Enum;

namespace crud.Services
{
    public static class ClientesServices
    {
        static List<Clientes> Clientes {get; }  
        static int nexId = 4;  
        static ClientesServices()
        {
            Clientes = new List<Clientes>
            {
                new Clientes {Id = 1, Nome = "Du",  Telefone = "(11)9999-9999", Email = "abcd@gmail.com", Estado = Estados.SP,  Produto = 0, valorTotal = 100 },
                new Clientes {Id = 2, Nome = "Dudu",  Telefone = "(11)9999-9999", Email = "dfd@gmail.com", Estado = Estados.RJ,  Produto = 1, valorTotal = 200},
                new Clientes {Id = 3, Nome = "Edu",  Telefone = "(11)9999-9999", Email = "ghi@gmail.com", Estado = Estados.MG,  Produto = 1, valorTotal = 300}
            };
        }
         public static List<Clientes> GetAll() => Clientes;
         public static Clientes Get(int id) => Clientes.FirstOrDefault(p => p.Id == id);
         public static void Add(Clientes cliente)
         {
             cliente.Id = nexId++;
             Clientes.Add(cliente);
         }     
         public static void Delete(int id)
         {
             var cliente = Get(id);
             if(cliente is null)
                 return;

             Clientes.Remove(cliente);
         }
         public static void Update(Clientes cliente)
         {
             var index = Clientes.FindIndex(p => p.Id == cliente.Id);
             {
                 if(index == -1)
                    return;

                Clientes[index] = cliente;
             }
         }
    }
}