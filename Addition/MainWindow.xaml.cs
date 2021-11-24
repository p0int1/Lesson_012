using System;
using System.Windows;

//Измените существующий проект данного урока 003_MVP, расширив его добавлением методов доступа 
//add и remove к событию.

namespace Addition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter p = null;
        public MainWindow()
        {
            InitializeComponent();
            p = new Presenter(this);
        }

        EventHandler _myEvent = null;
        EventHandler _clearEvent = null;

        public event EventHandler myEvent
        {
            add { _myEvent += value; MessageBox.Show("Подписались на событие нажатия Button"); }
            remove { _myEvent -= value; MessageBox.Show("Отписались от Button"); }
        }
        public event EventHandler clearEvent
        {
            add { _clearEvent += value; MessageBox.Show("Подписались на событие нажатия Clear"); }
            remove { _clearEvent -= value; MessageBox.Show("Отписались от Clear"); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _myEvent?.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _clearEvent?.Invoke(sender, e);
            clearEvent -= new EventHandler(p.textboxClear_Event);
        }
    }
}
