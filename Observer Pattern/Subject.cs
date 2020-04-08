using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer_Pattern
{
    class Subject:ISubject
    {
        public int GoldStock { get; set; } = 0;
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
            Console.WriteLine("Subject : New Observer Attached");
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine("Subject: Observer Dettached");
           
        }

        public void Notify(int oldSubject)
        {
            Console.WriteLine("Subject: Notifying Observer");
            foreach (var observer in this.observers)
            {
                observer.Update(this,$"{oldSubject} to {this.GoldStock}");
            }
        }

        public void BusinessLogic()
        {
            var preViousState = this.GoldStock;
            this.GoldStock = new Random().Next(0, 10);
            Thread.Sleep(3);
            Console.WriteLine($"Subject : GoldStock Changed from {preViousState} to {this.GoldStock}");
            this.Notify(preViousState);
        }

        
    }
}
