using System;

namespace Addition
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;
            view.myEvent += new EventHandler(mainWindow_myEvent);
            view.clearEvent += new EventHandler(textboxClear_Event);
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            var data = view.textBox1.Text;

            string variable = model.Logic(data);

            view.textBox1.Text = variable;
        }

        public void textboxClear_Event(object sender, System.EventArgs e)
        {
            view.textBox1.Clear();
        }
    }
}
