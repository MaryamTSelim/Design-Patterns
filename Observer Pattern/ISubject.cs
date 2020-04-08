using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(int subject);

    }
}
