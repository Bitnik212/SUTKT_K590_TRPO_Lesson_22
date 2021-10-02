using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;

namespace Variant_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void inkCanvas_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            String gestures = "";
            // Выборка "предпологаемых" гестур.
            foreach (GestureRecognitionResult res in
                e.GetGestureRecognitionResults())
                gestures += res.ApplicationGesture.ToString() + "; ";
            // Отображаем название гестуры.
            // gestureName.Text = gestures;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Выборка нужных режимов редактирования InkCanvas.
            lstEditingMode.Items.Add(InkCanvasEditingMode.Ink);
            lstEditingMode.Items.Add(InkCanvasEditingMode.EraseByPoint);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }
    }
}