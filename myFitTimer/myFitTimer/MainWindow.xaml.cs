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
using System.Diagnostics;

namespace myFitTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

		MyFitTimerTracker watch;
		DispatcherTimer timer = new DispatcherTimer();
	
		
        public MainWindow()
        {
			
			
            InitializeComponent();
			watch = new MyFitTimerTracker();
			timer.Tick += new EventHandler(timer_Tick);
			timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
		}
		void timer_Tick(object sender, EventArgs e)
		{
			if (watch.isRunning())
			{
				this.timerLabel.Content = watch.Elapsed();
			}
		}

		private void startTimer_Click(object sender, RoutedEventArgs e)
		{
			timer.Start();
			watch.start();
			
	
		}

		private void stopTimer_Click(object sender, RoutedEventArgs e)
		{
			if(watch.isRunning())
			{
				watch.stop();
				timer.Stop();
				this.elaspedTimeList.Items.Add(watch.Elapsed());
			}
			watch.clear();
			this.timerLabel.Content = "00:00:00";




		}
	

	
	}
}
