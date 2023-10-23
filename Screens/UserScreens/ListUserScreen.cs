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
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} ({item.Bio}) - ({item.Slug})");
        }
    }
}