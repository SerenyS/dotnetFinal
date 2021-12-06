namespace A13MovieLibrary.Data
{
    public interface IContext
    {
        void SearchAllMovies();
        void SearchOneMovie();
        void AddOneMovie();
        void EditOneMovie();
        void DeleteOneMovie();
        void AddOneUser();
        void RatingOneMovie();
    }
}