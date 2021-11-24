using System;
using System.Windows;

//Используя Visual Studio, создайте проект по шаблону WPF Application. 
//Создайте программу секундомер. Требуется выводить показания секундомера в окне. Окно имеет 
//кнопки запуска, остановки и сброса секундомера. Для реализации секундомера используйте паттерн MVP.

namespace Lesson_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        // Делегаты
        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;

        // События
        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        // Вызов событий
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            start?.Invoke(sender, e);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            stop?.Invoke(sender, e);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            reset?.Invoke(sender, e);
        }
    }
}
