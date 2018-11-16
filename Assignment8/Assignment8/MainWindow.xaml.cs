using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
using Assignment8.Annotations;

namespace Assignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static System.Timers.Timer timer;
        private readonly DispatcherTimer _timer;
        private DateTime StartTime { get; set; }
        private bool TaskIsRunning { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(1)};
            _timer.Tick += TimerOnTick;
            _timer.Start();
            TaskRunningMessage.Content = "Press Start to Start a Task";

           // var manager = new TimeManager();
           // manager.EntryCompleted += Start_OnClick;

            Start.Click += Start_OnClick_DisplayTaskRunning;
            Start.Click += Start_OnClick_StartTask;
            Stop.Click += Stop_OnClick_DisplayTaskFinished;
            Stop.Click += Stop_OnClick_EndTask;

            Delete.Click += Delete_OnClick_DeleteCurrentItem;
        }

        private void Delete_OnClick_DeleteCurrentItem(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Remove(ListBox.SelectedItem);
        }

        private void Stop_OnClick_DisplayTaskFinished(object sender, RoutedEventArgs e)
        {
            if (TaskIsRunning)
            {
                TaskRunningMessage.Content = "Task Completed - Start Another Task";
            }
        }

        private void Start_OnClick_DisplayTaskRunning(object sender, RoutedEventArgs e)
        {
            if (!TaskIsRunning)
            {
                TaskRunningMessage.Content = $"Task Started at {DateTime.Now:hh:mm:ss tt} is Running";
            }
        }

        private void Start_OnClick_StartTask(object sender, RoutedEventArgs e)
        {
            if (!TaskIsRunning)
            {
                TaskIsRunning = true;
                StartTime = DateTime.Now;
            }
        }
        private void Stop_OnClick_EndTask(object sender, RoutedEventArgs e)
        {
            if (TaskIsRunning)
            {
                ListBox.Items.Add($"Task was completed at {DateTime.Now:hh:mm:ss tt}");
                TaskIsRunning = false;
            }
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            Clock.Content = $"{DateTime.Now:hh:mm:ss tt}";
        }

        

        //    Dispatcher.Invoke(() => Clock.Content = $"{e.SignalTime:hh:mm:ss tt}");
        

    }


}
