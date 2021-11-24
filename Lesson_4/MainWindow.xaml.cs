using System;
using System.Windows;

//Используя Visual Studio, создайте проект по шаблону WPF Application. 
//Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и 
//деление). Для реализации калькулятора используйте паттерн MVP.

namespace Lesson_4
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

        // События
        private EventHandler addEvent = null;
        private EventHandler subEvent = null;
        private EventHandler mulEvent = null;
        private EventHandler divEvent = null;

        public event EventHandler AddEvent
        {
            add { addEvent += value; }
            remove { addEvent -= value; }
        }

        public event EventHandler SubEvent
        {
            add { subEvent += value; }
            remove { subEvent -= value; }
        }

        public event EventHandler MulEvent
        {
            add { mulEvent += value; }
            remove { mulEvent -= value; }
        }

        public event EventHandler DivEvent
        {
            add { divEvent += value; }
            remove { divEvent -= value; }
        }

        //Вызов методов подписаных на события
        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            op.Content = "+";
            addEvent?.Invoke(sender, e);
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            op.Content = "-";
            subEvent?.Invoke(sender, e);
        }

        private void mulBtn_Click(object sender, RoutedEventArgs e)
        {
            op.Content = "*";
            mulEvent?.Invoke(sender, e);
        }

        private void devBtn_Click(object sender, RoutedEventArgs e)
        {
            op.Content = "/";
            divEvent?.Invoke(sender, e);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            aValue.Clear();
            bValue.Clear();
            op.Content = "?";
            resValue.Clear();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
