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
        private string _action;
        private bool _resultReceived = false;

        public MainWindow()
        {
            InitializeComponent();
            _calculatorClient = new CalculatorClient(new Calculator());
        }

        private void buttonsNumber_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            textBoxInput.Text += button.Content;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _calculatorClient.Clear();
            textBoxInput.Text = "";
            labelResult.Content = 0;    
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

            if (textBoxInput.Text == "" && _calculatorClient.GetCountOperation() > 1)
            {
                if (_resultReceived)
                    _resultReceived = false;
                _calculatorClient.ChangeOperation(_action);
                UpdateInterface();
                return;
            }

            if (_resultReceived && textBoxInput.Text != "" &&  _calculatorClient.GetCountOperation() > 1)
            {
                _calculatorClient.Clear();
                _resultReceived = false;
            }

            _calculatorClient.AddOperation(textBoxInput.Text, _action);

            UpdateInterface();
        }

        private void UpdateInterface()
        {
            labelResult.Content = _calculatorClient.GetCurrentNumber() + _action;
            textBoxInput.Text = "";
        }

        private void buttonsResult_Click(object sender, RoutedEventArgs e)
        {
            _calculatorClient.CalcResult(textBoxInput.Text);
            _resultReceived = true;


            labelResult.Content = _calculatorClient.GetCurrentNumber();
            textBoxInput.Text = "";
            _action = "";
        }
    }
}
