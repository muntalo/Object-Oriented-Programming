using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTest
{
    public class Clock
    {
        Counter _hour, _minute, _second;
        string _name;

        public Clock(string name)
        {
            _name = name;
            _hour = new Counter("Hour");
            _minute = new Counter("Minute");
            _second = new Counter("Second");
        }

        public void Increment()
        {
            if (_second.Ticks < 59)
            {
                _second.Increment();
            } else if (_minute.Ticks < 59)
            {
                _second.Reset();
                _minute.Increment();
            } else if (_hour.Ticks < 23)
            {
                _second.Reset();
                _minute.Reset();
                _hour.Increment();
            } else
            {
                _hour.Reset();
                _minute.Reset();
                _second.Reset();
            }
        }

        public void Reset()
        {
            _hour.Reset();
            _minute.Reset();
            _second.Reset();
        }

        public string Time
        {
            get { return _hour.Ticks.ToString("00") + ":" + _minute.Ticks.ToString("00") + ":" + _second.Ticks.ToString("00"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
