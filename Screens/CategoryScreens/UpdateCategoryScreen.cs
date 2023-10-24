using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.CategoryScreens
{
    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criaçao de Categoria");
            Console.WriteLine("--------------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category { Id = id, Name = name, Slug = slug });
            Console.ReadKey();

        }
        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar uma categoria!");
                Console.WriteLine(ex.Message);

            }
        }
    }
}