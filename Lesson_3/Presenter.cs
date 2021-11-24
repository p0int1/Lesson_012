using System;
using System.Windows.Threading;

namespace Lesson_3
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;
        DispatcherTimer timer = new DispatcherTimer();

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
         }

        // Обработчики событий
        void ViewReset(object sender, EventArgs e)
        {
            timer.Stop();
            view.label.Content = "--";
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void ViewStart(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.label.Content = model.Tick();
        }
    }
}