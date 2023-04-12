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
    /// Interaction logic for Update_Authors.xaml
    /// </summary>
    public partial class Update_Authors : Window
    {
        public Update_Authors()
        {
            InitializeComponent();
        }
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Index index = new();
            index.Show();
            this.Close();
        }
    }
}
