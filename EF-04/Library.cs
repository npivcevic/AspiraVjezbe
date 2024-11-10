namespace EF_04
{
    internal class Library
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}

