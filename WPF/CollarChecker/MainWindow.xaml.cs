using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void rgbSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color c = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush b = new SolidColorBrush(c);
            colorArea.Background = b;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            string colors = string.Format("R={0} G={1} B={2}", rSlider.Value, gSlider.Value, bSlider.Value);
            stockList.Items.Add(colors);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = selectColor.Color;
            var name = selectColor.Name;
            colorArea.Background = new SolidColorBrush(color);
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] split = stockList.SelectedItem.ToString().Split(' ','=');
            rValue.Text = split[1];
            gValue.Text = split[3];
            bValue.Text = split[5];
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }

}
