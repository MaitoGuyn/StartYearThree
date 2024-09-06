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
using MessageBox = System.Windows.MessageBox;

namespace StartYearThree
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private class Salesperson
        {
            public string Name { get; set; }
            public DateTime HireDate { get; set; }
        }

        private Salesperson[] salespeople = new Salesperson[]
        {
            new Salesperson { Name = "Чупашева А.И.", HireDate = new DateTime(2015, 10, 1) },
            new Salesperson { Name = "Иванов А.В.", HireDate = new DateTime(2017, 1, 10) },
            new Salesperson { Name = "Кривцов О.П.", HireDate = new DateTime(2019, 2, 5) },
            new Salesperson { Name = "Янаева Э.С.", HireDate = new DateTime(2014, 12, 15) }
        };

        public MainWindow()
        {
            InitializeComponent();

            SalespersonComboBox.ItemsSource = salespeople.Select(p => p.Name).ToList();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            if (SalespersonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите продавца.");
                return;
            }

            if (!double.TryParse(RevenueTextBox.Text, out double revenue))
            {
                MessageBox.Show("Введите корректную выручку.");
                return;
            }

            var selectedSalesperson = salespeople.FirstOrDefault(sp => sp.Name == SalespersonComboBox.SelectedItem.ToString());

            if (selectedSalesperson == null)
            {
                MessageBox.Show("Продавец не найден.");
                return;
            }

            TimeSpan timeWorked = DateTime.Now - selectedSalesperson.HireDate;
            double yearsWorked = timeWorked.TotalDays / 365;

            double commissionPercentage = revenue < 50000 ? 0.03 : 0.06;

            if (yearsWorked > 3)
            {
                commissionPercentage += 0.05;
            }

            double commission = revenue * commissionPercentage;

            ResultTextBlock.Text = $"Продавец: {selectedSalesperson.Name}\n" +
                                   $"Дневная выручка: {revenue} руб.\n" +
                                   $"Стаж работы: {Math.Floor(yearsWorked)} лет\n" +
                                   $"Комиссионные: {commission:F2} руб.";
        }

    }
}
