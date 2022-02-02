using System;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double result;
        double x1, x2;
        char symbol;
        public MainWindow()
        {
            InitializeComponent();
            Model.tb = Result;
            Model.tbCombo = ComboChange;
            Model.tbxF = ChangeXFirst;
            Model.tbxS = ChangeXSecond;
            ComboChange.ItemsSource = Model.dataList;

        }

        private void controller_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '+')
            {
                result = x1 + x2;
            }
            if (symbol == '-')
            {
                result = x1 - x2;
            }
            if (symbol == '*')
            {
                result = x1 * x2;
            }
            if (symbol == '/')
            {
                result = x1 / x2;
            }

            Model.tb.Text = result.ToString();
        }

        private void ChangeXFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            x1 = Convert.ToDouble(Model.tbxF.Text);
        }

        private void ChangeXSecond_TextChanged(object sender, TextChangedEventArgs e)
        {
            x2 = Convert.ToDouble(Model.tbxS.Text);
        }

        private void ComboChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            symbol = Model.dataList[ComboChange.SelectedIndex];
            Model.Combo = ComboChange.SelectedIndex;
        }
    }
}
