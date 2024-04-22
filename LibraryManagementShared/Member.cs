using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementShared
{
    public class Member
    {
        public int MemberId { get; set; }

        public string MemberName { get; set; } = string.Empty;

        public string PhoneNo { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime JoinDate { get; set; } = DateTime.Now;

        public bool IsPaid { get; set; }

        public string Address { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
