using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_V1;

namespace Boats
{
    [Serializable()]
    internal class Boat : Garage
    {
        private int _propelor_size;
        private bool _has_kitchen;
        public Boat(string name,string manufacturer, int year, string error, int speed, int km, int wheelSize,int propeler_size,bool kitchen) : base(name,manufacturer, year, error, speed, km, wheelSize=0)
        {
            this._propelor_size = propeler_size;
            this._has_kitchen = kitchen;
        }
        public int PropelorSize
        {
            get { return _propelor_size; }
            set { _propelor_size = value; }
        }
        public bool HasKitchen
        {
            get { return _has_kitchen; }
            set { _has_kitchen = value; }
        }
        public override int Next_visit()
        {
            return this._km + 1000;
        }
        ~Boat() { }
    }
}
