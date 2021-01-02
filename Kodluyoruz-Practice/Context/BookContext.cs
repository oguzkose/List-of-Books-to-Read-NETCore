using Kodluyoruz_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodluyoruz_Practice.Context
{
    public class BookContext
    {
        public List<BookEntity> Books { get; set; }
        
        public BookContext()
        {
            Books = new List<BookEntity>
            {
                new BookEntity
                {
                    Id=1,
                    Author="Robert C. Martin",
                    Name ="Clean Code: A Handbook of Agile Software Craftsmanship",
                    Publisher="Pearson"
                },
                new BookEntity
                {
                    Id=2,
                    Author="Martin Fowler - Kent Beck",
                    Name ="Refactoring – Improving The Design Of Existing Code",
                    Publisher="Addison-Wesley"
                },
                new BookEntity
                {
                    Id=3,
                    Author=" Erich Gamma - John Vlissides - Richard Helm - Ralph Johnson",
                    Name ="Design Patterns – Elements of Reusable Object-Oriented Software",
                    Publisher="Addison-Wesley"
                },
                new BookEntity
                {
                    Id=4,
                    Author="Steve McConnell",
                    Name="Code Complete – A practical handbook of software construction",
                    Publisher="Microsoft Press"
                },
                new BookEntity
                {
                    Id=5,
                    Author=" Andy Hunt, Dave Thomas",
                    Name="The Pragmatic Programmer",
                    Publisher="Addison Wesley"
                }
            };
        }
    }
}
