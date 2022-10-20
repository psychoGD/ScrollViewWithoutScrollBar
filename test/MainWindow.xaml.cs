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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                var label = new Label();
                label.Content = $"Column {i} Hello";
                sp.Children.Add(label);
            }
        }
        public Point oldMousePosition { get; set; }
        private void sp_MouseMove(object sender, MouseEventArgs e)
        {
            Point newMousePosition = Mouse.GetPosition((StackPanel)sender);

            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (newMousePosition.Y < oldMousePosition.Y)
                    sv.ScrollToVerticalOffset(sv.VerticalOffset + 1);
                if (newMousePosition.Y > oldMousePosition.Y)
                    sv.ScrollToVerticalOffset(sv.VerticalOffset - 1);

                if (newMousePosition.X < oldMousePosition.X)
                    sv.ScrollToHorizontalOffset(sv.HorizontalOffset + 1);
                if (newMousePosition.X > oldMousePosition.X)
                    sv.ScrollToHorizontalOffset(sv.HorizontalOffset - 1);
            }
            else
            {
                oldMousePosition = newMousePosition;
            }
        }
    }
}
