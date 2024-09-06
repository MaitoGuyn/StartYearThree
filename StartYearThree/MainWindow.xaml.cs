using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StartYearThree
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Database database = new Database();
            var pers = database.persons;
            List<string> Names = pers.Select(p => p.FName).ToList();
            FName.ItemsSource = Names;
        }
       
        private void ConsiderBTN_Click(object sender, RoutedEventArgs e)
        {
            int input;
            int output;
            DateTime DatePerson;
            if (int.TryParse(Money.Text,out input))
            {
                output = input * 2;
                FullMoneyEnd_Copy.Text = output.ToString();
            }
            else
            {
                
            }
            //input = Convert.ToInt32(Money.Text);
            //DatePerson = Convert.ToDateTime(Money.Text);
        }
    }
}
