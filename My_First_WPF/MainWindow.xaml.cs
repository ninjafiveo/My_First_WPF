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

namespace My_First_WPF
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

        private void the_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Clicked Me");
        }

        private void the_button_LostFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HEY LOOK AT ME. HI MR. SEKOL");
        }

        private void the_button_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Don't Resize Me Man");
        }

        private void window_SizeChange(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Don't Resize Me Man 22222222222");
        }

        private void Another_Button_Mouse_Enter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("STOP HOVERING OVER ME MAN");
        }
    }
}
