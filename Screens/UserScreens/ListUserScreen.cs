using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaltaBlog_Desafio.Screens.UserScreens;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            ListWithRoles();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void ListWithRoles()
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.ReadWithRole();
            foreach (var item in users)
            {
                Console.Write($"Id: {item.Id} - Name: {item.Name} - Email: {item.Email} - Bio: {item.Bio} - Slug: {item.Slug} ");

                foreach (var role in item.Roles)
                    Console.WriteLine($"Role: {role?.Name}");
            }
            Console.WriteLine();
        }
    }
}