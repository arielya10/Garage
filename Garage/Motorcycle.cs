using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;
namespace Motorcycles
{
    [Serializable()]
    internal class Motorcycle: Vehicle
    {
        private int _hp;

        public Motorcycle(string name, string manufacturer, int year, string error, int speed, int km, int wheelSize,  string gear, string color,int hp) : base(name,manufacturer, year, error, speed,km, wheelSize,gear, color)
        {
            this._hp = hp;
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        ~Motorcycle() { }
        public override int Next_visit()
        {
            return this._km + 5000;
        }
    }
}
