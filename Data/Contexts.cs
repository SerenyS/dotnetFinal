namespace A13MovieLibrary.Data
{
    public class Contexts : IContext
    {
        private readonly IRepository _respository;

        public Contexts(IRepository repository)
        {
            _respository = repository;
        }

        public void AddOneMovie()
        {
            _respository.AddMovie();
        }

        public void AddOneUser()
        {
            _respository.AddUser();
        }

        public void DeleteOneMovie()
        {
            _respository.DeleteMovie();
        }

        public void EditOneMovie()
        {
            _respository.EditMovie();
        }

        public void SearchAllMovies()
        {
            _respository.SearchAll();
        }

        public void SearchOneMovie()
        {
            _respository.SearchOne();
        }
        public void RatingOneMovie()
        {
            _respository.RatingMovie();
        }
    }
}