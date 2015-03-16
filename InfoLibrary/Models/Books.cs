using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibrary.Models
{
    public class Books
    {
        private ObservableCollection<Book> data;

        public ObservableCollection<Book> Data
        {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<Book>();
                    Book book1 = new Book()
                    {
                        Name = "Padre Rico Padre Pobre",
                        Author = "Robert",
                        Code = "a101",
                        Genre = "Economia",
                        Pages = 300
                    };

                    Book book2 = new Book()
                    {
                        Name = "Orgullo y prejuicio",
                        Author = "Jane",
                        Code = "a102",
                        Genre = "Romance",
                        Pages = 300
                    };

                    Book book3 = new Book()
                    {
                        Name = "Caperucita Roja",
                        Author = "Grimm",
                        Code = "a103",
                        Genre = "Terror",
                        Pages = 500
                    };
                    data.Add(book1);
                    data.Add(book2);
                    data.Add(book3);
                }
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
