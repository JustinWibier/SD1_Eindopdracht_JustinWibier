using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment1_Eindopdracht.Models
{
    public class Author : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _name;
        private string _lastname;
        private string _infix;

        public string Name { get => _name;set { _name = value; Notify("Name"); }}
        public string Lastname { get => _lastname; set { _lastname = value; Notify("Lastname"); } }
        public string? Infix { get => _infix; set { _infix = value; Notify("Infix"); } }
        public int Id { get; set; }
        public virtual ObservableCollection<Book> Books { get; set; }

        public Author()
        {
            Books = new ObservableCollection<Book>();
        }
        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }

        public static implicit operator Author(Book v)
        {
            throw new NotImplementedException();
        }
    }

}
