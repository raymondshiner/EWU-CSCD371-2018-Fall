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
        private bool ThisClickIsStart { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(0.1)}; //did 0.1 second for accuracy and response time
            _timer.Tick += TimerOnTick;
            _timer.Start();
            TaskRunningMessage.Content = "Press Start to Start a Task";
            ThisClickIsStart = false;

            var manager = new TimeManager();
            manager.StartStopButtonClick += StartStop_OnClick_SetCurrentClick;
            manager.StartStopButtonClick += Stop_OnClick_DisplayTaskFinished;
            manager.StartStopButtonClick += Stop_OnClick_EndTask;
            manager.StartStopButtonClick += Start_OnClick_DisplayTaskRunning;
            manager.StartStopButtonClick += Start_OnClick_StartTask;
            manager.DeleteButtonClick += Delete_OnClick_DeleteCurrentItem;


            StartStop.Click += manager.RaiseEventStartStop;

            Delete.Click += manager.RaiseEventDelete;
        }

        private void StartStop_OnClick_SetCurrentClick()
        {
            if (ThisClickIsStart)
                ThisClickIsStart = false;
            else
                ThisClickIsStart = true;
        }

        private void Delete_OnClick_DeleteCurrentItem()
        {
            ListBox.Items.Remove(ListBox.SelectedItem);
        }

        private void Stop_OnClick_DisplayTaskFinished()
        {
            if (!ThisClickIsStart)
            {
                TaskRunningMessage.Content = "Task Completed - Start Another Task";
            }
        }

        private void Start_OnClick_DisplayTaskRunning()
        {
            if (ThisClickIsStart)
            {
                TaskRunningMessage.Content = $"Task Started at {TimeManager.Now():hh:mm:ss tt} is Running";
            }
        }

        private void Start_OnClick_StartTask()
        {
            if (ThisClickIsStart)
            {
                StartTime = TimeManager.Now();
            }
        }
        private void Stop_OnClick_EndTask()
        {
            if (!ThisClickIsStart)
            {
                ListBox.Items.Add($"Task was completed at {TimeManager.Now():hh:mm:ss tt}");
            }
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            Clock.Content = $"{TimeManager.Now():hh:mm:ss tt}";
        }
        
        

    }


}
