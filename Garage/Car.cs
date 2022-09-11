using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;
namespace Cars
{
    [Serializable()]
    internal class Car : Vehicle
    {
        private int safe_level;
        public Car(string name ,string manufacturer, int year, string error, int speed, int km,int wheelSize, string gear, string color,int safe_level) : base(name, manufacturer, year, error, speed, km, wheelSize, gear, color)
        {
            this.safe_level = safe_level;
        }
        public int Safe_level
        {
            get { return safe_level; }
            set { safe_level = value; }
        }
        public override int Next_visit()
        {
            return this._km + 10000;
        }
        ~Car() { }
    }
}
