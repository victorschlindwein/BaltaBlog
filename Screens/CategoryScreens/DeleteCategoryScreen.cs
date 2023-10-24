using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace BaltaBlog_Desafio.Screens.CategoryScreens
{
    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Exclusao de Categoria");
            Console.WriteLine("--------------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());


            Delete(id);
            Console.ReadKey();

        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar uma categoria!");
                Console.WriteLine(ex.Message);

            }
        }
    }
}