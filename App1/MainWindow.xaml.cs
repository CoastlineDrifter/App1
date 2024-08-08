using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class MainWindow : Window
    {
        public string value;
        public string calc = "";
        public string calc2 = "";
        public bool reset = false;
        public char operation = ' ';
        public int total = 0;
        public char prevOperation = ' ';
        List<int> values = new List<int>();
        public string length;
        public bool clickedCL = false;
        public bool editingCalc = false;
        public bool editingCalc2 = false;
        public bool editingTotal = false;
        public string len;

        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "Calculator";
            this.AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(700, 250, 400, 600));
        }
        static int Calc(int num1, int num2, int finalVal, char operation)
        {
            if (operation == '+')
            {
                finalVal = num1 + num2;
            }
            if (operation == '-')
            {
                finalVal = num1 - num2;
            }
            if (operation == 'x')
            {
                finalVal = num1 * num2;
            }
            if (operation == '/')
            {
                finalVal = num1 / num2;
            }
            return finalVal;
        }

        void Buttonp(object sender, RoutedEventArgs e)
        {
            operation = '+';
            reset = true;
            calc2 = "";

            editingCalc = false;
            editingCalc2 = false;
            editingTotal = false;
        }

        void Buttonm(object sender, RoutedEventArgs e)
        {
            operation = '-';
            reset = true;
            calc2 = "";
        }

        void Buttonx(object sender, RoutedEventArgs e)
        {
            operation = 'x';
            reset = true;
            calc2 = "";
        }

        void Buttond(object sender, RoutedEventArgs e)
        {
            operation = '/';
            reset = true;
            calc2 = "";
        }

        void Button1(object sender, RoutedEventArgs e)
        {
            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "1";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "1";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "1";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }


        }
        void Button2(object sender, RoutedEventArgs e)
        {
            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "2";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "2";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "2";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }
        void Button3(object sender, RoutedEventArgs e)
        {
            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "3";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "3";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "3";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button4(object sender, RoutedEventArgs e)
        {
            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "4";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "4";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "4";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button5(object sender, RoutedEventArgs e)
        {

            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "5";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "5";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "5";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button6(object sender, RoutedEventArgs e)
        {

            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "6";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "6";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "6";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button7(object sender, RoutedEventArgs e)
        {

            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "7";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "7";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "7";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button8(object sender, RoutedEventArgs e)
        {

            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "8";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "8";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "8";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }
        void Button9(object sender, RoutedEventArgs e)
        {

            if (total == 0)
            {
                if (reset == false)
                {
                    calc = calc + "9";
                    Calculate.Text = calc;
                    editingCalc = true;
                    editingCalc2 = false;
                    editingTotal = false;
                }
                else
                {
                    calc2 = calc2 + "9";
                    Calculate.Text = calc2;
                    editingCalc2 = true;
                    editingCalc = false;
                    editingTotal = false;
                }
            }
            else
            {
                total = 0;
                calc = "9";
                calc2 = "";
                editingCalc = true;
                editingCalc2 = false;
                editingTotal = false;
                Calculate.Text = calc;
                reset = false;
                clickedCL = true;
            }
        }

        void Button10(object sender, RoutedEventArgs e)
        {
            if (total == 0)
            {
                if (reset == false)
                {

                    if (total == 0 || Int32.Parse(calc) > 0 || Int32.Parse(calc2) > 0)
                    {
                        calc = calc + "0";
                        Calculate.Text = calc;

                        editingCalc2 = false;
                        editingCalc = true;
                        editingTotal = false;
                    }
                    if (total > 0)
                    {
                        var total2 = total.ToString() + "0";
                        total = Int32.Parse(total2);
                        calc = total.ToString();
                        Calculate.Text = total.ToString();

                        editingCalc2 = false;
                        editingCalc = false;
                        editingTotal = true;
                    }
                }
                else
                {
                    if (total == 0 || Int32.Parse(calc) > 0 || Int32.Parse(calc2) > 0)
                    {
                        calc2 = calc2 + "0";
                        Calculate.Text = calc2;

                        editingCalc2 = true;
                        editingCalc = false;
                        editingTotal = false;
                    }
                    if (total > 0)
                    {
                        var total2 = total.ToString() + "0";
                        total = Int32.Parse(total2);
                        calc = total.ToString();
                        Calculate.Text = total.ToString();

                        editingCalc2 = false;
                        editingCalc = false;
                        editingTotal = true;
                    }
                }
            }
        }


        void Button11(object sender, RoutedEventArgs e)
        {
            if(calc2 != "" && calc != "")
            {
                total = Calc(Int32.Parse(calc), Int32.Parse(calc2), 0, operation);
                calc = total.ToString();
                Calculate.Text = total.ToString();

                editingCalc2 = false;
                editingCalc = false;
                editingTotal = true;
            } 
        }

        

        void Button12(object sender, RoutedEventArgs e)
        {
            if (calc2 == "")
            {
                Calculate.Text = "aa";
            }
        }
        void Button13(object sender, RoutedEventArgs e)
        {
            calc = "";
            calc2 = "";
            total = 0;
            Calculate.Text = "";
            reset = false;
            clickedCL = true;

            editingCalc2 = false;
            editingCalc = false;
            editingTotal = false;
        }

        void Button14(object sender, RoutedEventArgs e)
        {

        }

        void Button15(object sender, RoutedEventArgs e)
        {

        }

        void Button16(object sender, RoutedEventArgs e)
        {
            if (editingCalc == true && calc.Length > 0) 
            {
                calc = calc.Remove(calc.Length - 1);
                Calculate.Text = calc;
            }

            if (editingCalc2 == true && calc2.Length > 0)
            {
                calc2 = calc2.Remove(calc2.Length - 1);
                Calculate.Text = calc2;
            }

            if (editingTotal == true && total.ToString().Length > 0)
            {
                len = total.ToString();
                len = len.Remove(total.ToString().Length - 1);
                if (len != "")
                {
                    total = Int32.Parse(len.ToString());
                } else
                {
                    calc = "";
                    calc2 = "";
                    total = 0;
                    Calculate.Text = "";
                    reset = false;
                    clickedCL = true;

                    editingCalc2 = false;
                    editingCalc = false;
                    editingTotal = false;
                }
                Calculate.Text = total.ToString();
            }
        }
    }
}
