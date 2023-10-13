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
using System.Windows.Shapes;

namespace Wpf_StasIvan_Pr1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void MIBlue_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void MIRed_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void MIGreen_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void MIYellow_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void MIBlack_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void MIDraw_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void MIEdit_Click(object sender, RoutedEventArgs e)
        {
            MainInk.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void MIDelete_Click(object sender, RoutedEventArgs e)
        {
            this.MainInk.Strokes.Clear();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение создано: Студент 402гр-ИСП АПТ Стасюк Иван", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MainSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //MainInk.DefaultDrawingAttributes.Width = ((Slider)sender).Value;
            //MainInk.DefaultDrawingAttributes.Height = ((Slider)sender).Value;
        }
    }
}
