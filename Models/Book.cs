using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment1_Eindopdracht.Models
{
    public class Book
    {
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; } 
        // Omdat een boek meerdere authors kan hebben ga ik het niet limiten naar 1 author

    }
}
