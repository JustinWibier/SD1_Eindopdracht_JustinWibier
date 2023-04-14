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


        public Author SelectedAuthor { get; set; }
        public ObservableCollection<Author> Allauthors { get; set; }
        public ICommand AddNew_Author { get; set; }
        public ICommand Delete_Author { get; set; }
        public ICommand Save_Author { get; set; }
        public Author author { get; set; }
        private Author_Context _db;

        public ICommand Add_To_Book { get; set; }
        public ICommand Remove_From_Book { get; set; }

        public CRUD_Books_ViewModel()
        {

            author = new Author
            {
                Name = "new",
                Infix = "-",
                Lastname = "new",
            };



            AddNew_Author = new RelayCommand(Add_New_Author);
            Delete_Author = new RelayCommand(Delete_author);
            Save_Author = new RelayCommand(Save_author);

            _db = new Author_Context();

            _db.Authors.Load();

            Allauthors = _db.Authors.Local.ToObservableCollection();



            book = new Book
            {
                Title = "",
                Description = "",
            };
            // dit gebruikt om boeken op een mooiere manier toe te voegen dan eerst alles toeven met de value new.
            // nu kun je dit eerst zelf infullen
            AddNew_Books = new RelayCommand(Add_New_book);
            Delete_Books = new RelayCommand(Delete_book);
            Save_Book = new RelayCommand(Save_book);
            Add_To_Book = new RelayCommand(Add_To_book);

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
        private void Add_To_book()
        {
            SelectedAuthor.Books.Add(SelectedBooks);

        }
        //deze code zou correct horen te zijn maar werkt niet

        private void Delete_book()
        {

            SelectedBooks.Title = "[DELETED]";
            SelectedBooks.Description = "_";
        }

        private void Save_book()
        {
            _db.SaveChanges();
        }


        private void Add_New_Author()
        {
            Allauthors.Add(new Author
            {
                Name = author.Name,
                Infix = author.Infix,
                Lastname = author.Lastname
            });
        }

        private void Delete_author()
        {

            SelectedAuthor.Name = "[DELETED]";
            SelectedAuthor.Infix = "_";
            SelectedAuthor.Lastname = "_";
        }

        private void Save_author()
        {
            _db.SaveChanges();
        }



    }
}




