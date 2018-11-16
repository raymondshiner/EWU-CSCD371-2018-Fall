using System;
using System.Windows;

namespace Assignment8
{
    public class TimeManager
    {

        public Action StartStopButtonClick { get; set; }
        public Action DeleteButtonClick { get; set; }

        public void RaiseEventStartStop(object sender, RoutedEventArgs routedEventArgs)
        {
            StartStopButtonClick?.Invoke();
        }

        public void RaiseEventDelete(object sender, RoutedEventArgs e)
        {
            DeleteButtonClick?.Invoke();
        }
    }
}