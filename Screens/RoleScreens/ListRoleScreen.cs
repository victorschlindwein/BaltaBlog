using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.RoleScreens
{
    public class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de roles");
            Console.WriteLine("-------------");
            ListWithRoles();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void ListWithRoles()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var item in roles)
            {
                Console.Write($"Id: {item.Id} - Name: {item.Name} - Slug: {item.Slug} ");
            }
            Console.WriteLine();
        }
    }
}