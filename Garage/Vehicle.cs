using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_V1;
namespace Vehicles
{
    [Serializable()]
    internal class Vehicle : Garage
    {
        protected string _gear;
        protected string _color;
        public Vehicle(string name, string manufacturer, int year, string error, int speed, int km,int wheelSize,string gear,string color) : base(name,manufacturer, year, error, speed, km, wheelSize)
        {
            this._gear = gear;
            this._color = color;
        }
        public string Gear
        {
            get { return _gear; }
            set { _gear = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        ~Vehicle() { }
        public override int Next_visit()
        {
            return this._km + 10000;
        }
    }
}
