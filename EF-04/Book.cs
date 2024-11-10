namespace EF_04
{
    internal class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int LibraryId { get; set; }
        public Library? Library { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}


