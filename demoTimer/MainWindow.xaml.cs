using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace demoTimer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer;
        Timer timer1;
        int sec, h, m, s;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        //倒數計時
        void timer_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                TimerText.Text = sec + "  seconds";
                sec--;
            }
            else
            {
                timer.Stop();
                TimerText.Text = "Time's up!";
            }
        }

        //開始計時
        void timer1_Tick(object sender, EventArgs e)
        {
            TimerText1.Text=h + " :" + m + " :" + s ;

            s++;

            if (s > 60)
            {
                s = 0;
                m++;

                if (m > 60)
                {
                    m = 0;
                    h++;

                    if (h > 23)
                    {
                        h = 0;
                    }
                }

            }

        }

        private void TimerBt_Click(object sender, RoutedEventArgs e)
        {
            //sender判斷進入的按鈕
            if (sender == TimerBt)
            {
                //倒數的秒數
                sec = 10;
                timer = new Timer();
                //設定計時器的速度
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            else if (sender == TimerBt1)
            {
                timer1 = new Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
            }
        }
    }
}
