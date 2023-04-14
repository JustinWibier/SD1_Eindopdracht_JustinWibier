using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment1_Eindopdracht.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SoftwareDevelopment1_Eindopdracht.Viewmodels
{
    public class CRUD_Books_ViewModel
    {
        public Book SelectedBooks { get; set; }
        public ObservableCollection<Book> Allbooks { get; set; }
        public ICommand AddNew_Books { get; set; }
        public ICommand Delete_Books { get; set; }
        public ICommand Save_Book { get; set; }
        public Book book { get; set; }
        private Author_Context _db;
        public CRUD_Books_ViewModel()
        {
            book = new Book
            {
                Title = "new",
                Description = "new",
            };
            AddNew_Books = new RelayCommand(Add_New_book);
            Delete_Books = new RelayCommand(Delete_book);
            Save_Book = new RelayCommand(Save_book);

            _db = new Author_Context();

            _db.Books.Load();

            Allbooks = _db.Books.Local.ToObservableCollection();

        }

        private void Add_New_book()
        {
            Allbooks.Add(new Book
            {
                Title = book.Title,
                Description = book.Description,
            });
        }

        private void Delete_book()
        {

            SelectedBooks.Title = "[DELETED]";
            SelectedBooks.Description = "_";
        }

        private void Save_book()
        {
            _db.SaveChanges();
        }


    }
}

