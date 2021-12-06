namespace A13MovieLibrary.DataModels
{
    public class MovieGenre
    {
        public long Id { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Genre Genre { get; set; }
    }
}