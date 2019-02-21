using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double screenvalue1;
        private double screenvalue2;
        private double sum;
        private double product;
        private double dividend;
        private double modulus;
        private double difference;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text+"0";


        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text+"1";
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "2";
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "3";
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "4";
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "5";
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "6";
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "7";
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "8";
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "9";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            //screenvalue2 = Convert.ToDouble(screencontent.Text);
            //var sum = screenvalue1+screenvalue2;
           // screencontent.Text = Convert.ToString(sum);
           screenvalue2 = Convert.ToDouble(screencontent.Text);
           screencontent.Text = Convert.ToString(screenvalue2);

        }

        private void CLS_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = "";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            screenvalue1 = Convert.ToDouble(screencontent.Text);
           // screencontent.Text = screencontent.Text + "+";
           screencontent.Text = screencontent.Text + "+";
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "-";
        }

        private void Greaterthan_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + ">";
        }

        private void Lessthan_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "<";
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text.TrimEnd();
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "%";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "/";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            screencontent.Text = screencontent.Text + "*";
        }
    }
}
