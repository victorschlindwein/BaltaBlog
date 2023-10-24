using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.RoleScreens
{
    public class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Perfil");
            Console.WriteLine("----------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Update(new Role { Id = id, Name = name, Slug = slug });
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}