using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.RoleScreens
{
    public class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Perfil");
            Console.WriteLine("----------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());


            Delete(id);
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil excluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}