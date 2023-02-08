using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book.Data.Models
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book() 
                    {
                         Title = "First Book Title",
                         Description = "First Book Description",
                         IsRead = true,
                         DateRead = DateTime.Now.AddDays(-10),
                         Rate = 4,
                         Genre = "Biography",
                         Author = "Ye Wunt Naung",
                         CoverUrl = "https://www.ywn.com.mm",
                         DateAdded = DateTime.Now.AddDays(-30)
                    },
                    new Book()
                    {
                        Title = "Second Book Title",
                        Description = "Second Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "History",
                        Author = "Ye Wunt Naung",
                        CoverUrl = "https://www.ywn.com.mm",
                        DateAdded = DateTime.Now.AddDays(-30)
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
