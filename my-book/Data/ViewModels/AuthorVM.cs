using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book.Data.ViewModels
{
    public class AuthorVM
    {
        public string AuthorName { get; set; }

        public DateTime DOB { get; set; }

        public string NRC { get; set; }

        public string Remark { get; set; }
    }
}
