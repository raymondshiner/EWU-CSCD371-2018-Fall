using System;

namespace Assignment8
{
    public class TimeManager
    {
        public Action EntryCompleted { get; set; }

        public void RaiseEvent()
        {
            EntryCompleted?.Invoke();
        }
    }
}