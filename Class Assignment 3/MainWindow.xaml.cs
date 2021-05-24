using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab_Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private bool _equalCheck;
        private bool _backspaceCheck;
        public MainWindow()
        {
            InitializeComponent();
            Equation.Content = "";
            Calculation.Content = "";
        }

        private void Digit_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button) || _equalCheck) return;
            switch (button.Content)
            {
                case "0":
                    Calculation.Content += "0";
                    break;
                case "1":
                    Calculation.Content += "1";
                    break;
                case "2":
                    Calculation.Content += "2";
                    break;
                case "3":
                    Calculation.Content += "3";
                    break;
                case "4":
                    Calculation.Content += "4";
                    break;
                case "5":
                    Calculation.Content += "5";
                    break;
                case "6":
                    Calculation.Content += "6";
                    break;
                case "7":
                    Calculation.Content += "7";
                    break;
                case "8":
                    Calculation.Content += "8";
                    break;
                case "9":
                    Calculation.Content += "9";
                    break;
                case ".":
                    var dotCheck = Calculation.Content.ToString();
                    if (dotCheck.Length == 0) { return; }
                    if (!dotCheck.Contains("."))
                    {
                        Calculation.Content += ".";
                    }
                    break;
            }
        }

        private void Operator_OnClick(object sender, RoutedEventArgs e)
        {
            _backspaceCheck = false;
            if (!(sender is Button button)) return;
            switch (button.Content)
            {
                case "+/-":
                    if (Calculation.Content.ToString() == "") {}
                    else
                    {
                        var calculation = Calculation.Content.ToString();
                        if (calculation[0] == '-')
                        {
                            calculation = calculation.Substring(1, calculation.Length - 1);
                            Calculation.Content = calculation;
                        }
                        else
                        {
                            Calculation.Content = "-" + calculation;
                        }
                    }
                    break;
                case "+":
                    _equalCheck = false;
                    if (Equation.Content.ToString() == "")
                    {
                        if (Calculation.Content.ToString() == "") {}
                        else
                        {
                            Equation.Content = Calculation.Content + " + ";
                            Calculation.Content = "";
                        }
                        
                    }
                    else
                    {
                        if (Calculation.Content.ToString() == "")
                        {
                            var equation = Equation.Content.ToString().Split();
                            Equation.Content = equation[0] + " + ";
                            return;
                        }
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString());
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }
                        Equation.Content += " + ";
                        Calculation.Content = "";
                    }
                    break;
                case "-":
                    _equalCheck = false;
                    if (Equation.Content.ToString() == "")
                    {
                        if (Calculation.Content.ToString() == "") {}
                        else
                        {
                            Equation.Content = Calculation.Content + " - ";
                            Calculation.Content = "";
                        }
                    }
                    else
                    {
                        if (Calculation.Content.ToString() == "")
                        {
                            var equation = Equation.Content.ToString().Split();
                            Equation.Content = equation[0] + " - ";
                            return;
                        }
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString()); 
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }
                        Equation.Content += " - ";
                        Calculation.Content = "";
                    }
                    break;
                case "X":
                    _equalCheck = false;
                    if (Equation.Content.ToString() == "")
                    {
                        if (Calculation.Content.ToString() == "") {}
                        else
                        {
                            Equation.Content = Calculation.Content + " * ";
                            Calculation.Content = "";
                        }
                    }
                    else
                    {
                        if (Calculation.Content.ToString() == "")
                        {
                            var equation = Equation.Content.ToString().Split();
                            Equation.Content = equation[0] + " * ";
                            return;
                        }
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString()); 
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }
                        Equation.Content += " * ";
                        Calculation.Content = "";
                    }
                    break;
                case "÷":
                    _equalCheck = false;
                    if (Equation.Content.ToString() == "")
                    {
                        if (Calculation.Content.ToString() == "") {}
                        else
                        {
                            Equation.Content = Calculation.Content + " ÷ ";
                            Calculation.Content = "";
                        }
                    }
                    else
                    {
                        if (Calculation.Content.ToString() == "")
                        {
                            var equation = Equation.Content.ToString().Split();
                            Equation.Content = equation[0] + " ÷ ";
                            return;
                        }
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString()); 
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }
                        Equation.Content += " ÷ ";
                        Calculation.Content = "";
                    }
                    break;
                case "%":
                    _equalCheck = false;
                    if (Equation.Content.ToString() == "")
                    {
                        if (Calculation.Content.ToString() == "") {}
                        else
                        {
                            Equation.Content = Calculation.Content + " ÷ ";
                            Calculation.Content = "";
                        }
                    }
                    else
                    {
                        if (Calculation.Content.ToString() == "")
                        {
                            var equation = Equation.Content.ToString().Split();
                            Equation.Content = equation[0] + " % ";
                            return;
                        }
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString()); 
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }
                        Equation.Content += " % ";
                        Calculation.Content = "";
                    }
                    break;
                case "=":
                    if (Equation.Content.ToString() == "" || Calculation.Content.ToString() == "" ){}
                    else
                    {
                        var strNumber1 = Equation.Content.ToString().Split();
                        var operatorUsed = strNumber1[1];
                        var number1 = double.Parse(strNumber1[0]);
                        var number2 = double.Parse(Calculation.Content.ToString()); 
                        switch (operatorUsed)
                        {
                            case "+":
                                Equation.Content = number1 + number2;
                                break;
                            case "-":
                                Equation.Content = number1 - number2;
                                break;
                            case "÷":
                                Equation.Content = number1 / number2;
                                break;
                            case "*":
                                Equation.Content = number1 * number2;
                                break;
                            case "%":
                                Equation.Content = number1 % number2;
                                break;
                        }

                        Calculation.Content = Equation.Content;
                        Equation.Content = "";
                        _equalCheck = true;
                        _backspaceCheck = true;
                    }
                    break;
                case "C":
                    Equation.Content = "";
                    Calculation.Content = "";
                    break;
                case "CE":
                    Calculation.Content = "";
                    break;
                case "1/x":
                    if (Calculation.Content.ToString() == "" ){}
                    else
                    {
                        Equation.Content = "";
                        Calculation.Content = 1 / double.Parse(Calculation.Content.ToString());
                    }
                    break;
                case "x^2":
                    if (Calculation.Content.ToString() == "" ){}
                    else
                    {
                        Equation.Content = "";
                        Calculation.Content = Math.Pow(double.Parse(Calculation.Content.ToString()), 2);
                    }
                    break;
                case "2√x":
                    if (Calculation.Content.ToString() == "" ){}
                    else
                    {
                        Equation.Content = "";
                        Calculation.Content = Math.Sqrt(double.Parse(Calculation.Content.ToString()));
                    }
                    break;
            }
        }

        private void Backspace(object sender, RoutedEventArgs e)
        {
            if (_backspaceCheck) { return; }
            if (Calculation.Content.ToString().Length >= 1 )
            {
                Calculation.Content = Calculation.Content.ToString()
                    .Substring(0, Calculation.Content.ToString().Length - 1);
            }
        }
    }
}