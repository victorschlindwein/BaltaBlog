using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.CategoryScreens
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criaçao de Categoria");
            Console.WriteLine("--------------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category { Name = name, Slug = slug });
            Console.ReadKey();

        }
        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar uma categoria!");
                Console.WriteLine(ex.Message);

            }
        }
    }
}