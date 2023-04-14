using CommunityToolkit.Mvvm.Input;
using SoftwareDevelopment1_Eindopdracht.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SoftwareDevelopment1_Eindopdracht.Viewmodels
{
    public class Update_Authors_ViewModel
    {
        public Author SelectedAuthor { get; set; }
        public ObservableCollection<Author> Allauthors  { get; set; }
        public ICommand AddNew_Author { get; set; }
        public ICommand Delete_Author { get; set; }
        public ICommand Save_Author { get; set; }
        public Author author { get; set; }

        private Author_Context _db;

        
        public Update_Authors_ViewModel()
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
