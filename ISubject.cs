using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Наблюдателя
{
    public interface ISubject
    {
        void RegisterObject(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
