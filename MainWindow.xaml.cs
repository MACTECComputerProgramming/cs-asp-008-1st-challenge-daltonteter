﻿using System;
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

namespace CS_ASP_008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 + number2;

            label.Content = total;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 + number2;

            label.Content = total;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 * number2;

            label.Content = total;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 / number2;

            label.Content = total;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 % number2;

            label.Content = total;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            label.Content = "";

            textBox1.Text = "";

            textBox2.Text = "";
        }
    }
}
