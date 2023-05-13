using _1670_ASM2.Models;
using System;

namespace _1670_ASM2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Book
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Last Hope",
                            BookCoverURL = "https://imgv3.fotor.com/images/gallery/Fiction-Book-Covers.jpg",
                            Description = "This is the description of the book cinema",
                            Genre = BookGenre.Fantasy,
                            Price = 40.01,
                            PublisherId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Author 1",
                            Bio = "This is the Bio of the first actor",

                        }
                    });
                    context.SaveChanges();
                }
                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            Name = "Publisher 1",
                            Bio = "This is the Bio of the first actor",
                            
                        }
                    });
                    context.SaveChanges();
                }
                
                //Authors & Movies
                if (!context.Books_Authors.Any())
                {
                    context.Books_Authors.AddRange(new List<Book_Author>()
                    {
                        new Book_Author()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Book_Author()
                        {
                            AuthorId = 3,
                            BookId = 1
                        },

                         new Book_Author()
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                         new Book_Author()
                        {
                            AuthorId = 4,
                            BookId = 2
                        },

                        new Book_Author()
                        {
                            AuthorId = 1,
                            BookId = 3
                        },
                        new Book_Author()
                        {
                            AuthorId = 2,
                            BookId = 3
                        },
                        new Book_Author()
                        {
                            AuthorId = 5,
                            BookId = 3
                        },
                        new Book_Author()
                        {
                            AuthorId = 2,
                            BookId = 4
                        },
                        new Book_Author()
                        {
                            AuthorId = 3,
                            BookId = 4
                        },
                        new Book_Author()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },


                        new Book_Author()
                        {
                            AuthorId = 2,
                            BookId = 5
                        },
                        new Book_Author()
                        {
                            AuthorId = 3,
                            BookId = 5
                        },
                        new Book_Author()
                        {
                            AuthorId = 4,
                            BookId = 5
                        },
                        new Book_Author()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },
                        new Book_Author()
                        {
                            AuthorId = 3,
                            BookId = 6
                        },
                        new Book_Author()
                        {
                            AuthorId = 4,
                            BookId = 6
                        },
                        new Book_Author()
                        {
                            AuthorId = 5,
                            BookId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
