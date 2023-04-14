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

namespace SoftwareDevelopment1_Eindopdracht.Views
{
    /// <summary>
    /// Interaction logic for Combine.xaml
    /// </summary>
    public partial class Combine : Window
    {
        public Combine()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Index index = new Index();
            index.Show();

            this.Close();
        }
    }
}
