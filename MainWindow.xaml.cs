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

namespace Wpf_StasIvan_Pr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.myFrame = myFrame;
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            this.Background = brush;
        }

        private void r2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Green);
            this.Background = brush1;
        }

        private void r3_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush2 = new SolidColorBrush(Colors.Blue);
            this.Background = brush2;
        }

        private void r4_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush3 = new SolidColorBrush(Colors.Yellow);
            this.Background = brush3;
        }

        private void r5_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush4 = new SolidColorBrush(Colors.White);
            this.Background = brush4;
        }

        private void r6_Checked(object sender, RoutedEventArgs e)
        {
            if (r6.IsChecked == true)
            {
                AppFrame.myFrame.Navigate(new Information());
            }
        }

        private void r7_Checked(object sender, RoutedEventArgs e)
        {
            if (r7.IsChecked == true)
            {
                AppFrame.myFrame.CanGoBack.CompareTo(r7.IsChecked);
            }
        }

        private void r8_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush5 = new SolidColorBrush(Colors.Red);
            this.Background = brush5;
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush6 = new SolidColorBrush(Colors.Green);
            this.Background = brush6;
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush7 = new SolidColorBrush(Colors.Blue);
            this.Background = brush7;
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush8 = new SolidColorBrush(Colors.Yellow);
            this.Background = brush8;
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush9 = new SolidColorBrush(Colors.White);
            this.Background = brush9;
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            i1.Visibility = Visibility.Visible;
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            i1.Visibility = Visibility.Hidden;
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }
    }
}
