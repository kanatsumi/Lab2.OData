using static System.Reflection.Metadata.BlobBuilder;

namespace ODataBookStore.Models
{
    public class DataSource
    {
        private static IList<Book> _listBooks { get; set; }
        public static IList<Book> GetBooks()
        {
            if (_listBooks != null)
            {
                return _listBooks;
            }
            _listBooks = new List<Book>();
            Book book = new Book()
            {
                Id = 1,
                ISBN = "987-0-321-877548-1",
                Title = "Essential C#5.0",
                Author = "Mark Michaelis",
                Price = 59.99m,
                Location = new Address
                {
                    City = "HCM City",
                    Street = "D2, Thu Duc District"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addision-Wesley",
                    Category = Category.Book
                }
            };
            _listBooks.Add(book);

            _listBooks.Add(new Book
            {
                Id = 2,
                ISBN = "987-0-321-877548-2",
                Title = "C# in Depth",
                Author = "Jon Skeet",
                Price = 45.99m,
                Location = new Address 
                {
                    City = "New York",
                    Street = "5th Avenue" 
                },
                Press = new Press 
                { 
                    Id = 2,
                    Name = "Manning", 
                    Category = Category.Book
                }
            });
            _listBooks.Add(new Book
            {
                Id = 3,
                ISBN = "987-0-321-877548-3",
                Title = "Pro ASP.NET Core",
                Author = "Adam Freeman",
                Price = 50.99m,
                Location = new Address { City = "London", Street = "Oxford Street" },
                Press = new Press { Id = 3, Name = "Apress", Category = Category.EBook }
            });
            _listBooks.Add(new Book
            {
                Id = 4,
                ISBN = "987-0-321-877548-4",
                Title = "The Pragmatic Programmer",
                Author = "Andy Hunt",
                Price = 39.99m,
                Location = new Address { City = "Tokyo", Street = "Shibuya" },
                Press = new Press { Id = 4, Name = "Addison-Wesley", Category = Category.Book }
            });
            _listBooks.Add(new Book
            {
                Id = 5,
                ISBN = "987-0-321-877548-5",
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Price = 49.99m,
                Location = new Address { City = "Berlin", Street = "Alexanderplatz" },
                Press = new Press { Id = 5, Name = "Prentice Hall", Category = Category.Book }
            });
            _listBooks.Add(new Book
            {
                Id = 6,
                ISBN = "987-0-321-877548-6",
                Title = "Introduction to Algorithms",
                Author = "Thomas H. Cormen",
                Price = 85.99m,
                Location = new Address { City = "Paris", Street = "Champs-Élysées" },
                Press = new Press { Id = 6, Name = "MIT Press", Category = Category.Book }
            });

            _listBooks.Add(new Book
            {
                Id = 7,
                ISBN = "987-0-321-877548-7",
                Title = "The Mythical Man-Month",
                Author = "RFrederick P. Brooks",
                Price = 29.99m,
                Location = new Address { City = "Sydney", Street = "George Street" },
                Press = new Press { Id = 7, Name = "Addison-Wesley", Category = Category.Magazine }
            });

            _listBooks.Add(new Book
            {
                Id = 8,
                ISBN = "987-0-321-877548-8",
                Title = "Design Patterns",
                Author = "Erich Gamma",
                Price = 49.99m,
                Location = new Address { City = "San Francisco", Street = "Market Street" },
                Press = new Press { Id = 8, Name = "Addison-Wesley", Category = Category.Book }
            });

            _listBooks.Add(new Book
            {
                Id = 9,
                ISBN = "987-0-321-877548-9",
                Title = "Refactoring",
                Author = "Martin Fowler",
                Price = 55.99m,
                Location = new Address { City = "Rome", Street = "Via del Corso" },
                Press = new Press { Id = 9, Name = "Addison-Wesley", Category = Category.Book }
            });

            _listBooks.Add(new Book
            {
                Id = 10,
                ISBN = "987-0-321-877548-10",
                Title = "Effective Java",
                Author = "RJoshua Bloch",
                Price = 40.99m,
                Location = new Address { City = "Bangkok", Street = "Sukhumvit Road" },
                Press = new Press { Id = 10, Name = "Addison-Wesley", Category = Category.Book }
            });

            _listBooks.Add(new Book
            {
                Id = 11,
                ISBN = "987-0-321-877548-11",
                Title = "Head First Design Patterns",
                Author = "Eric Freeman",
                Price = 45.99m,
                Location = new Address { City = "Mexico City", Street = "Paseo de la Reforma" },
                Press = new Press { Id = 11, Name = "O'Reilly", Category = Category.Magazine }
            });

            _listBooks.Add(new Book
            {
                Id = 12,
                ISBN = "987-0-321-877548-12",
                Title = "Patterns of Enterprise Application Architecture",
                Author = "Martin Fowler",
                Price = 55.99m,
                Location = new Address { City = "Dubai", Street = "Sheikh Zayed Road" },
                Press = new Press { Id = 12, Name = "Addison-Wesley", Category = Category.Book }
            });

            _listBooks.Add(new Book
            {
                Id = 13,
                ISBN = "987-0-321-877548-13",
                Title = "Test-Driven Development",
                Author = "Kent Beck",
                Price = 39.99m,
                Location = new Address { City = "Toronto", Street = "Bay Street" },
                Press = new Press { Id = 13, Name = "Addison-Wesley", Category = Category.EBook }
            });
            _listBooks.Add(new Book
            {
                Id = 14,
                ISBN = "987-0-321-877548-14",
                Title = "The Art of Computer Programming",
                Author = "Donald Knuth",
                Price = 99.99m,
                Location = new Address { City = "Zurich", Street = "Bahnhofstrasse" },
                Press = new Press { Id = 14, Name = "Addison-Wesley", Category = Category.Book }
            });
            _listBooks.Add(new Book
            {
                Id = 15,
                ISBN = "987-0-321-877548-15",
                Title = "Don't Make Me Think",
                Author = "Steve Krug",
                Price = 30.99m,
                Location = new Address { City = "Los Angeles", Street = "Hollywood Boulevard" },
                Press = new Press { Id = 15, Name = "New Riders", Category = Category.Magazine }
            });
            _listBooks.Add(new Book
            {
                Id = 16,
                ISBN = "978-0-123456-47-2",
                Title = "Bangkok's Hidden Gems",
                Author = "John Doe",
                Price = 29.99m,
                Location = new Address { City = "Bangkok", Street = "Sukhumvit 21" },
                Press = new Press { Id = 16, Name = "Bangkok Press", Category = Category.EBook }
            });

            // Adding the second new book
            _listBooks.Add(new Book
            {
                Id = 17,
                ISBN = "978-0-123456-48-9",
                Title = "The Culture of Thailand",
                Author = "Jane Smith",
                Price = 39.99m,
                Location = new Address { City = "Bangkok", Street = "Rama IX" },
                Press = new Press { Id = 17, Name = "Thai Publishing", Category = Category.EBook }
            });
            return _listBooks;
        }
    }
}
