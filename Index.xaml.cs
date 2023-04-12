using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SoftwareDevelopment1_Eindopdracht
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Btn_Update_Click(object sender, RoutedEventArgs e)
        {
            Update update = new();
            update.Show();

            this.Close();
        }

        private void Btn_List_Click(object sender, RoutedEventArgs e)
        {
            Read read = new();
            read.Show();

            this.Close();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Add add = new();
            add.Show();

            this.Close();
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new();
            delete.Show();

            this.Close();
        }

        private void Btn_Update_Authors_Click(object sender, RoutedEventArgs e)
        {
           Update_Authors update_authors = new();
            update_authors.Show();

            this.Close();
        }

        private void Btn_List_Authors_Click(object sender, RoutedEventArgs e)
        {
            Read_Authors read_authors = new();
            read_authors.Show(); 
            
            this.Close();
        }

        private void Btn_Delete_Authors_Click(object sender, RoutedEventArgs e)
        {
            Delete_Authors delete_authors = new();
            delete_authors.Show();

            this.Close();
        }

        private void Btn_Add_Authors_Click(object sender, RoutedEventArgs e)
        {
            Add_Authors add_authors = new();
            add_authors.Show();
                
            this.Close();
        }
    }
}
