using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment1_Eindopdracht.Models
{
    public class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _title;
        private string _description;

        public int Id { get; set; }
        
        public string Title { get => _title; set { _title = value; Notify("Title"); } }
        public string Description { get => _description; set { _description = value; Notify("Description"); } }
        public virtual ObservableCollection<Author> Authors { get; set; }


        public Book()
        {
            Authors= new ObservableCollection<Author>();
        }

        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }
        // een boek kan meer dan 1 author hebben.


    }
}
