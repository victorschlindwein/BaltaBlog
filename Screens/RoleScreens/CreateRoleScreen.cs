using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.RoleScreens
{
    public class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar Perfil");
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Create(new Role { Name = name, Slug = slug });
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Perfil criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}