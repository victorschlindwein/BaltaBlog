using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaltaBlog_Desafio.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Menu Categoria");
            Console.WriteLine("--------------");
            Console.WriteLine("1 - Listar Categoria: ");
            Console.WriteLine("2 - Criar uma Categoria: ");
            Console.WriteLine("3 - Atualizar uma Categoria: ");
            Console.WriteLine("4 - Deleter uma Categoria: ");
            Console.WriteLine("5 - Voltar ao menu principal: ");
            var option = short.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;

                default: Load(); break;
            }
        }
    }
}