using System;
using System.Collections.Generic;
using System.Linq;
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

namespace nolikikrestiki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml о победе
    /// </summary>
    public partial class MainWindow : Window

    {
        public static int y = 0;
        public static int x;
        public static int dd = 1;
        static Button[] buttons = new Button[9];

        public static int[] poops = new int[9];
        public MainWindow()


        {
            InitializeComponent();
            x = 1;
            buttons[0] = _1;
            buttons[1] = _2;
            buttons[2] = _3;
            buttons[3] = _4;
            buttons[4] = _5;
            buttons[5] = _6;
            buttons[6] = _7;
            buttons[7] = _8;
            buttons[8] = _9;
            for (int i = 0; i < buttons.Length; i++)
            {

                buttons[i].IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (x == 1)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "x");
                info.Content = "Нолики";
                y += 1;

                x = 0;
            }
            else if (x == 0)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "0");
                info.Content = "Крестики";
                y += 1;
                x = 1;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            zapobedu();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Content = "";
                buttons[i].IsEnabled = true;

            }
            if (dd == 1)
            {
                x = 1; info.Content = "Крестики";
            }
            else if (dd == 0)
            {
                x = 0; info.Content = "Нолики";
            }
            y = 0;
        }
        public void zapobedu()
        {
            if ((buttons[0].Content == "x" && buttons[1].Content == "x" && buttons[2].Content == "x") || (buttons[3].Content == "x" && buttons[4].Content == "x" && buttons[5].Content == "x") || (buttons[6].Content == "x" && buttons[7].Content == "x" && buttons[8].Content == "x"))
            {
                info.Content = "Победа крестиков";
                dd = 0;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if ((buttons[0].Content == "x" && buttons[3].Content == "x" && buttons[6].Content == "x") || (buttons[1].Content == "x" && buttons[4].Content == "x" && buttons[7].Content == "x") || (buttons[2].Content == "x" && buttons[5].Content == "x" && buttons[8].Content == "x"))
            {
                info.Content = "Победа крестиков";
                dd = 0;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if ((buttons[0].Content == "x" && buttons[4].Content == "x" && buttons[8].Content == "x") || (buttons[2].Content == "x" && buttons[4].Content == "x" && buttons[6].Content == "x"))
            {
                info.Content = "Победа крестиков";
                dd = 0;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if ((buttons[0].Content == "0" && buttons[1].Content == "0" && buttons[2].Content == "0") || (buttons[3].Content == "0" && buttons[4].Content == "0" && buttons[5].Content == "0") || (buttons[6].Content == "0" && buttons[7].Content == "0" && buttons[8].Content == "0"))
            {
                info.Content = "Победа ноликов";
                dd = 1;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if ((buttons[0].Content == "0" && buttons[3].Content == "0" && buttons[6].Content == "0") || (buttons[1].Content == "0" && buttons[4].Content == "0" && buttons[7].Content == "0") || (buttons[2].Content == "0" && buttons[5].Content == "0" && buttons[8].Content == "0"))
            {
                info.Content = "Победа ноликов";
                dd = 1;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if ((buttons[0].Content == "0" && buttons[4].Content == "0" && buttons[8].Content == "0") || (buttons[2].Content == "0" && buttons[4].Content == "0" && buttons[6].Content == "0"))
            {
                info.Content = "Победа ноликов";
                dd = 1;
                for (int i = 0; i < buttons.Length; i++)
                {

                    buttons[i].IsEnabled = false;

                }
            }
            else if (y == 9)
            {
                if ((buttons[0].Content == "x" && buttons[1].Content == "x" && buttons[2].Content == "x") || (buttons[3].Content == "x" && buttons[4].Content == "x" && buttons[5].Content == "x") || (buttons[6].Content == "x" && buttons[7].Content == "x" && buttons[8].Content == "x"))
                {
                    info.Content = "Победа крестиков";
                    dd = 0;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else if ((buttons[0].Content == "x" && buttons[3].Content == "x" && buttons[6].Content == "x") || (buttons[1].Content == "x" && buttons[4].Content == "x" && buttons[7].Content == "x") || (buttons[2].Content == "x" && buttons[5].Content == "x" && buttons[8].Content == "x"))
                {
                    info.Content = "pobeda krestov";
                    dd = 0;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else if ((buttons[0].Content == "x" && buttons[4].Content == "x" && buttons[8].Content == "x") || (buttons[2].Content == "x" && buttons[4].Content == "x" && buttons[6].Content == "x"))
                {
                    info.Content = "Победа крестиков";
                    dd = 0;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else if ((buttons[0].Content == "0" && buttons[1].Content == "0" && buttons[2].Content == "0") || (buttons[3].Content == "0" && buttons[4].Content == "0" && buttons[5].Content == "0") || (buttons[6].Content == "0" && buttons[7].Content == "0" && buttons[8].Content == "0"))
                {
                    info.Content = "Победа ноликов";
                    dd = 1;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else if ((buttons[0].Content == "0" && buttons[3].Content == "0" && buttons[6].Content == "0") || (buttons[1].Content == "0" && buttons[4].Content == "0" && buttons[7].Content == "0") || (buttons[2].Content == "0" && buttons[5].Content == "0" && buttons[8].Content == "0"))
                {
                    info.Content = "Победа ноликов";
                    dd = 1;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else if ((buttons[0].Content == "0" && buttons[4].Content == "0" && buttons[8].Content == "0") || (buttons[2].Content == "0" && buttons[4].Content == "0" && buttons[6].Content == "0"))
                {
                    info.Content = "Победа ноликов";
                    dd = 1;
                    for (int i = 0; i < buttons.Length; i++)
                    {

                        buttons[i].IsEnabled = false;

                    }
                }
                else
                {
                    info.Content = "Ничья";
                }

            }


        }

    }

}