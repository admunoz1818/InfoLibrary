using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibrary.Models
{
    public class Book : System.ComponentModel.INotifyPropertyChanged
    {
        //Atributes
        private String name;        
        private String code;        
        private String author;       
        private String genre;        
        private int pages;
        
        //Properties
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this,
                        new System.ComponentModel
                        .PropertyChangedEventArgs("Name"));
            }
        }
        public String Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
                if (PropertyChanged != null)
                    PropertyChanged(this,
                        new System.ComponentModel
                        .PropertyChangedEventArgs("Code"));
            }
        }
        public String Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
                if (PropertyChanged != null)
                    PropertyChanged(this,
                        new System.ComponentModel
                            .PropertyChangedEventArgs("Author"));
            }
        }
        public String Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
                if (PropertyChanged != null)
                    PropertyChanged(this,
                        new System.ComponentModel.PropertyChangedEventArgs("Genre"));

            }

        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;

                if (PropertyChanged != null)
                    PropertyChanged(this,
                        new System.ComponentModel
                        .PropertyChangedEventArgs("Pages"));

            }
        }

        //Events
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
