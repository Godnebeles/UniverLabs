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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1_SimpleCalculator
{

    public partial class MainWindow : Window
    {
        private CalculatorClient _calculatorClient;
        private string _action = "";

        public MainWindow()
        {
            InitializeComponent();
            _calculatorClient = new CalculatorClient(new Calculator());
        }

        private void buttonsNumber_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Content.ToString() == "." && textBoxInput.Text.IndexOf(".") > 0)
                return;

            textBoxInput.Text += button.Content;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            _action = "";          
            textBoxInput.Text = "";
            labelResult.Content = 0;

            _calculatorClient.Clear();
        }

        private void buttonBackOperation_Click(object sender, RoutedEventArgs e)
        {
            _calculatorClient.UndoCommand();

            labelResult.Content = _calculatorClient.GetCurrentNumber();
        }

        private void buttonsClearOneNumber_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
                return;

            textBoxInput.Text = textBoxInput.Text.Substring(0, textBoxInput.Text.Length - 1);
        }


        private void buttonsOperation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _action = (string)button.Content;

            _calculatorClient.AddOperation(textBoxInput.Text, _action);

            UpdateInterface();
        }

        private void UpdateInterface()
        {
            labelResult.Content = _calculatorClient.GetCurrentNumber() + " " + _action;
            textBoxInput.Text = "";
        }

        private void ButtonsResult_Click(object sender, RoutedEventArgs e)
        {
            _calculatorClient.CalcResult(textBoxInput.Text);
            _action = "";
            
            UpdateInterface();         
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ButtonsResult_Click(sender, e);
            }
            int a = 0;
        }
    }
}
