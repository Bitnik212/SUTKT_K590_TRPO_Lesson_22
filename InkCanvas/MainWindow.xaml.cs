using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;

namespace InkCanvas
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
            gestureName.Text = gestures;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Выборка всех режимов редактирования InkCanvas.
            foreach (InkCanvasEditingMode mode in
                Enum.GetValues(typeof(InkCanvasEditingMode)))
                lstEditingMode.Items.Add(mode);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
            
        }
    }
}