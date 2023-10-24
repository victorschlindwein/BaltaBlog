using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.CategoryScreens
{
    public class ListCategoryScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Lista de Categoria");
            Console.WriteLine("------------------");
            List();
            Console.ReadKey();
        }
        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var lists = repository.Get();

            foreach (var item in lists)
            {

                Console.WriteLine($"{item.Id} - {item.Name} , {item.Slug} ");
            }

        }
    }
}