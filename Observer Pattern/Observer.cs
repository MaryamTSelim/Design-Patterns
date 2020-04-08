using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    class Observer : IObserver
    {
        private string name;
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        private int id;
        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public static int counter = 0;
        //Constructor
        public Observer(string name)
        {
            counter++;
            this.Name = name;
            this.Id = counter;
        }
        public void Update(ISubject subject,string message)
        {
            Console.WriteLine($"<{this.Id}> <{this.Name}> : Observer has been notified of change");
            Console.WriteLine($"\t< Gold Stock > : Gold Stock changed from {message}");
        }
    }
}
