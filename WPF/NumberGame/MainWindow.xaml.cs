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
using System.Windows.Threading;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int ans;
        DispatcherTimer timer;
        TimeSpan time;
        //private const int Rows = 5;
        //private const int Columns = 5;

        public MainWindow()
        {
            InitializeComponent();
            ans = new Random().Next(1, 25);
            time = TimeSpan.FromSeconds(1);
            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTimer.Text = time.ToString("c");
                if (time == TimeSpan.Zero) timer.Stop();
                time = time.Add(TimeSpan.FromSeconds(1));
            }, Application.Current.Dispatcher);
            timer.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var num = int.Parse(((Button)sender).Content.ToString());            

            if (num == ans)
            {
                tbNumber.Text = "正解です！！";
                timer.Stop();
            }
            else if(ans > num){
                tbNumber.Text = "選んだ数字より大きいです。";
            }else{
                tbNumber.Text = "選んだ数字より小さいです。";
            }
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    int ans = new Random().Next(Rows * Columns) + 1;

        //    for (int i = 0; i < Rows; i++)
        //    {
        //        grid.RowDefinitions.Add(new ColumnDefinition());
        //    }

        //    for (int j = 0; j < Columns; j++)
        //    {
        //        grid.ColumnDefinitions.Add(new ColumnDefinition());
        //    }

        //    for (int i = 0; i < Rows; i++)
        //    {
        //        for (int j = 0; j < Columns; j++)
        //        {
        //            var bt new Button();
        //            bt.Width = 50;
        //            bt.Height = 50;
        //            bt.Content = 1
        //            Grid.SetRow(bt,i);
        //            Grid.SetColumn(bt,j);
        //            grid.Children.Add(bt);
        //        }
        //    }
    }
}
