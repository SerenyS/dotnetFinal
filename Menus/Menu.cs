using System;
using A13MovieLibrary.Data;

namespace A13MovieLibrary.Menus
{
    public class Menu : IMenu
    {
        private IContext _context;

        public Menu(IContext context)
        {
            _context = context;
        }

        public void DisplayMenu()
        {
            string menuSelection;
            var repo = new Repository();

            do
            {
                ActionMenu();
                menuSelection = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1": // Add movie
                    _context.AddOneMovie();
                    break;
                    case "2": // Edit movie
                    _context.EditOneMovie();
                    break;
                    case "3": // Search all movies
                    _context.SearchAllMovies();
                    break;
                    case "4": // Serach specfic movie
                    _context.SearchOneMovie();
                    break;
                    case "5": // Add User
                    _context.AddOneUser();
                    break;
                    case "6": // Delete movie
                    _context.DeleteOneMovie();
                    break;
                    case "7": // Delete movie
                    _context.RatingOneMovie();
                    break;
                }
            } while (menuSelection != "8");
        }
        
        public void ActionMenu()
        {
          
            Console.WriteLine("1. Add New Movie");
            Console.WriteLine("2. Update a Movie");
            Console.WriteLine("3. View all Movies");
            Console.WriteLine("4. Search for a Movie");
            Console.WriteLine("5. Add new User");
            Console.WriteLine("6. Delete Movie");
            Console.WriteLine("7. Rate Movie");
            Console.WriteLine("8. Exit\n");
        }

    }
}

