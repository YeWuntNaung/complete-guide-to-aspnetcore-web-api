using my_book.Data.Models;
using my_book.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                AuthorName = author.AuthorName,
                DOB = author.DOB,
                NRC = author.NRC,
                Remark = author.Remark,
            };
            _context.Add(_author);
            _context.SaveChanges();
        }
    }
}
