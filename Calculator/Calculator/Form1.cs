using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            Clear,
            Plus,
            Minus,
            Multiply,
            Divide,
            Percent
        }


        private Operators CurrentOperator = Operators.Clear;
        private Boolean OperatorChangeFlag = false;
        private Boolean ResultSecound = true;
        private double FirstOperand = 0;
        private double SecondOperand = 0;
        private double Result = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNumberClick(object sender, EventArgs e)
        {
            if (OperatorChangeFlag)
            {
                displayResult.Text = "";
                OperatorChangeFlag = false;
            }

            Button button = (Button)sender;
            displayResult.Text += button.Text;

            //3자리씩 ,표시
            if (long.TryParse(displayResult.Text.Replace(",", ""), out long number))
            {
                displayResult.Text = number.ToString("N0");
            }
        }//ButtonNumberClick end

        private void ButtonReverseClick(object sender, EventArgs e)
        {
            ResultSecound = true;
            FirstOperand = double.Parse(displayResult.Text);
            if (FirstOperand == 0)
            {
                return;
            }
            else
            {
                FirstOperand *= -1;
                displayResult.Text = FirstOperand.ToString();
            }
            if (display.Text.Contains("="))
            {


                display.Text = $"negate({FirstOperand})";
            }
        }//ButtonReverseClick end

        private void ButtonPointClick(object sender, EventArgs e)
        {
            ResultSecound = true;
            FirstOperand = double.Parse(displayResult.Text);
            if (displayResult.Text.Contains("."))
            {
                return;
            }
            else
            {
                displayResult.Text += ".";
            }
        }//ButtonPointClick end

        private void ButtonPlusClick(object sender, EventArgs e)
        {
            ResultSecound = true;
            if (OperatorChangeFlag && CurrentOperator == Operators.Plus)
            {
                return;
            }

            FirstOperand = double.Parse(displayResult.Text);
            Result = display.Text.Length == 0 || display.Text.Contains("=") || CurrentOperator == Operators.Clear ? FirstOperand : Calculate(Result, CurrentOperator, FirstOperand);

            displayResult.Text = Result.ToString();
            display.Text = Result.ToString() + " + ";
            CurrentOperator = Operators.Plus;
            OperatorChangeFlag = true;
        }//ButtonPlusClick end


        private void ButtonMinusClick(object sender, EventArgs e)
        {
            ResultSecound = true;
            if (OperatorChangeFlag && CurrentOperator == Operators.Minus)
            {
                return;
            }

            FirstOperand = double.Parse(displayResult.Text);
            Result = display.Text.Length == 0 || display.Text.Contains("=") || CurrentOperator == Operators.Clear ? FirstOperand : Calculate(Result, CurrentOperator, FirstOperand);

            displayResult.Text = Result.ToString();
            display.Text = Result.ToString() + " - ";
            CurrentOperator = Operators.Minus;
            OperatorChangeFlag = true;
        }//ButtonMinusClick end

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            ResultSecound = true;
            if (display.Text.Contains("=") || display.Text.Contains("negate"))
            {
                display.Text = "";
            }

            else
            {
                if (displayResult.Text.Length == 1)
                {
                    displayResult.Text = "0";
                }
                displayResult.Text = displayResult.Text.Substring(0, displayResult.Text.Length - 1);
            }
        }//ButtonDeleteClick end

        private void ButtonClearClick(object sender, EventArgs e)
        {
            CurrentOperator = Operators.Clear;
            FirstOperand = 0;
            SecondOperand = 0;
            Result = 0;
            displayResult.Text = "0";
            display.Text = "";
            ResultSecound = true;
        }//ButtonClearClick end

        private void ButtonClearEntryClcik(object sender, EventArgs e)
        {
            ResultSecound = true;
            if (display.Text.Contains("=") || display.Text.Contains("negate"))
            {
                Result = 0;
                display.Text = "";
                displayResult.Text = "0";
            }
            else
            {
                displayResult.Text = "0";
            }
        }//ButtonClearEntryClcik end

        private void ButtonPercentClick(object sender, EventArgs e)
        {
            if (OperatorChangeFlag && CurrentOperator == Operators.Minus)
            {
                return;
            }

            FirstOperand = double.Parse(displayResult.Text);

            Result = display.Text.Length == 0 || display.Text.Contains("=") || CurrentOperator == Operators.Clear ? FirstOperand : Calculate(Result, CurrentOperator, FirstOperand);

            displayResult.Text = Result.ToString();
            display.Text = Result.ToString() + " % ";
            CurrentOperator = Operators.Percent;
            OperatorChangeFlag = true;
            ResultSecound = true;
        }//ButtonPercentClick end
        private void ButtonmultiplyClick(object sender, EventArgs e)
        {
            if (OperatorChangeFlag && CurrentOperator == Operators.Minus)
            {
                return;
            }

            FirstOperand = double.Parse(displayResult.Text);
            Result = display.Text.Length == 0 || display.Text.Contains("=") || CurrentOperator == Operators.Clear ? FirstOperand : Calculate(Result, CurrentOperator, FirstOperand);

            displayResult.Text = Result.ToString();
            display.Text = Result.ToString() + " X ";
            CurrentOperator = Operators.Multiply;
            OperatorChangeFlag = true;
            ResultSecound = true;
        }//ButtonmultiplyClick end

        private void ButtonDivideClick(object sender, EventArgs e)
        {
            if (OperatorChangeFlag && CurrentOperator == Operators.Minus)
            {
                return;
            }

            FirstOperand = double.Parse(displayResult.Text);
            Result = display.Text.Length == 0 || display.Text.Contains("=") || CurrentOperator == Operators.Clear ? FirstOperand : Calculate(Result, CurrentOperator, FirstOperand);
            displayResult.Text = Result.ToString();
            display.Text = Result.ToString() + " / ";
            CurrentOperator = Operators.Divide;
            OperatorChangeFlag = true;
            ResultSecound = true;
        }//ButtonDivideClick end

        private void ButtonResultClick(object sender, EventArgs e)
        {
            double num = double.Parse(displayResult.Text);

            if (ResultSecound)
            {
                SecondOperand = num;
                ResultSecound = false;
            }
            Result = Calculate(Result, CurrentOperator, SecondOperand);
            displayResult.Text = Result.ToString("#,0.############");

            switch (CurrentOperator)
            {
                case Operators.Plus:
                    display.Text = (Result - SecondOperand).ToString() + " + " + SecondOperand.ToString() + " =";
                    return;
                case Operators.Minus:
                    display.Text = (Result + SecondOperand).ToString() + " - " + SecondOperand.ToString() + " =";
                    return;
                case Operators.Multiply:
                    display.Text = (Result / SecondOperand).ToString() + " X " + SecondOperand.ToString() + " =";
                    return;
                case Operators.Divide:
                    display.Text = (Result * SecondOperand).ToString() + " / " + SecondOperand.ToString() + " =";
                    return;
                case Operators.Percent:
                    display.Text = Result.ToString() + " % " + SecondOperand.ToString() + " =";
                    return;
            }

        }//ButtonResultClick end

        private double Calculate(double result, Operators operatorType, double firstOperand)
        {
            switch (operatorType)
            {
                case Operators.Plus:
                    return result + firstOperand;

                case Operators.Minus:
                    return result - firstOperand;

                case Operators.Multiply:
                    return result * firstOperand;

                case Operators.Divide:
                    if (firstOperand == 0)
                    {
                        display.Text = "0으로 나눌 수 없습니다";
                        return 0;
                    }
                    return result / firstOperand;

                case Operators.Percent:
                    if (firstOperand == 0)
                    {
                        display.Text = "0으로 나눌 수 없습니다";
                        return 0;
                    }
                    return result % firstOperand;

                default:
                    return 0;
            }
        }//claculate end

        private void Form1Load(object sender, EventArgs e)
        {

        }//Form1_Load end
    }//class Form1 end
}//Calculator end

