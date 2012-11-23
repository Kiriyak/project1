using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
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

        private void ShowScheduleOKButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduleBorder.Opacity = 1;
            ScheduleBorder.Visibility = Visibility.Visible;
        }

        private void ScheduleNAZAD_label(object sender, MouseButtonEventArgs e)
        {
            ScheduleBorder.Opacity = 0;
            ScheduleBorder.Visibility = Visibility.Hidden;
        }

        private void ShowTeacherScheduleOKButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherScheduleBorder.Opacity = 1;
            TeacherScheduleBorder.Visibility = Visibility.Visible;
        }

        private void TeacherScheduleNAZAD_label(object sender, MouseButtonEventArgs e)
        {
            TeacherScheduleBorder.Opacity = 0;
            TeacherScheduleBorder.Visibility = Visibility.Hidden;
        }
        
        private void ShowTeacherList_label(object sender, MouseButtonEventArgs e)
        {
            TeacherListBorder.Opacity = 1;
            TeacherListBorder.Visibility = Visibility.Visible;
        }

        private void TeacherListNAZAD_label(object sender, MouseButtonEventArgs e)
        {
            TeacherListBorder.Opacity = 0;
            TeacherListBorder.Visibility = Visibility.Hidden;
        }
    }
}
