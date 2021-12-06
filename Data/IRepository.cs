namespace A13MovieLibrary.Data
{
    public interface IRepository
    {
        void SearchAll();
        void SearchOne();
        void AddMovie();
        void EditMovie();
        void DeleteMovie();
        void AddUser();
        void RatingMovie();
    }
}