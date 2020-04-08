using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer_Pattern
{
    class Program
    {

        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new Observer("Maryam");
            subject.Attach(observerA);

            var observerB = new Observer("Esraa");
            subject.Attach(observerB);

            subject.BusinessLogic();
            subject.BusinessLogic();

            subject.Detach(observerB);

            subject.BusinessLogic();
           
        }
    }
}
