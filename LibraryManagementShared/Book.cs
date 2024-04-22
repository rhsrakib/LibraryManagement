using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementShared
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; } = string.Empty;

        public string AuthorName { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
    }
}