using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShar極客學園.事件event.語法
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new EventTest(5);
            e.SetNum(100);
            e.ChangeNum += new EventTest.NumManipulationHandler(EventTest.EventFired);
            e.SetNum(200);
        }
    }

    class EventTest
    {
        private int value;
        // 委託 delegate
        public delegate void NumManipulationHandler();
        // 事件 event，型別為所對應委派的型別
        public event NumManipulationHandler ChangeNum;

        public EventTest(int n)
        {
            SetNum(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event Fired");
        }
        protected virtual void OnNumChanged()
        {
            // 檢查 event 是否有委派

            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }

        public void SetNum(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }
}
