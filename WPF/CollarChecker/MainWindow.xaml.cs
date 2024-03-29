﻿using System;
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
                .Select(i => new MyColor((Color)i.GetValue(null), i.Name) { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void rgbSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color c = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush b = new SolidColorBrush(c);
            colorArea.Background = b;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (cbColor.SelectedIndex == -1) {
                string colors = string.Format("R={0} G={1} B={2}", rSlider.Value, gSlider.Value, bSlider.Value);
                stockList.Items.Add(colors);
            }
            else {
                MyColor selectColor = new MyColor(Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value), cbColor.Text);
                stockList.Items.Add(selectColor);
                cbColor.SelectedIndex = -1;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cbColor.SelectedIndex != -1) {
                var selectColor = (MyColor)((ComboBox)sender).SelectedItem;
                var color = selectColor.Color;
                var name = selectColor.Name;
                colorArea.Background = new SolidColorBrush(color);
                rSlider.Value = color.R;
                gSlider.Value = color.G;
                bSlider.Value = color.B;
            }
        }

        //private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        //    if (stockList.SelectedItem.ToString().Contains(" ")) {
        //        string[] split = stockList.SelectedItem.ToString().Split(' ', '=');
        //        rValue.Text = split[1];
        //        gValue.Text = split[3];
        //        bValue.Text = split[5];
        //    }
        //    else {
        //        MyColor selectColor = (MyColor)stockList.SelectedItem;
        //        rValue.Text = selectColor.Color.R.ToString();
        //        gValue.Text = selectColor.Color.G.ToString();
        //        bValue.Text = selectColor.Color.B.ToString();
        //    }
        //}

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (stockList.SelectedItem.ToString().Contains(" ")) {
                string[] split = stockList.SelectedItem.ToString().Split(' ', '=');
                rValue.Text = split[1];
                gValue.Text = split[3];
                bValue.Text = split[5];
            }
            else {
                MyColor selectColor = (MyColor)stockList.SelectedItem;
                rValue.Text = selectColor.Color.R.ToString();
                gValue.Text = selectColor.Color.G.ToString();
                bValue.Text = selectColor.Color.B.ToString();
            }
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public MyColor(Color value, string Name) {
            this.Color = value;
            this.Name = Name;
        }
        public override string ToString() {
            return Name;
        }
    }

}
