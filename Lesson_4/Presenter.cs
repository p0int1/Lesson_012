using System;

namespace Lesson_4
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddEvent += MainWindowAdd;
            this.mainWindow.SubEvent += MainWindowSub;
            this.mainWindow.MulEvent += MainWindowMul;
            this.mainWindow.DivEvent += MainWindowDiv;
        }

        // обработчики событий
        void MainWindowAdd(object sender, EventArgs e)
        {
            string result = model.Add(Convert.ToInt32(mainWindow.aValue.Text), Convert.ToInt32(mainWindow.bValue.Text));
            mainWindow.resValue.Text = result;
        }
        void MainWindowSub(object sender, EventArgs e)
        {
            string result = model.Sub(Convert.ToInt32(mainWindow.aValue.Text), Convert.ToInt32(mainWindow.bValue.Text));
            mainWindow.resValue.Text = result;
        }
        void MainWindowMul(object sender, EventArgs e)
        {
            string result = model.Mul(Convert.ToInt32(mainWindow.aValue.Text), Convert.ToInt32(mainWindow.bValue.Text));
            mainWindow.resValue.Text = result;
        }
        void MainWindowDiv(object sender, EventArgs e)
        {
            string result = model.Div(Convert.ToInt32(mainWindow.aValue.Text), Convert.ToInt32(mainWindow.bValue.Text));
            mainWindow.resValue.Text = result;
        }
    }
}
