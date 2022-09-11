using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_V1;
namespace Airplanes
{
    [Serializable()]
    internal class Airplane : Garage
    {
        private double _wings_size;
        private int _max_people;
        public Airplane(string name, string manufacturer, int year, string error, int speed, int km,int wheelSize, int max_people, double wings_size) : base(name, manufacturer, year, error, speed, km,wheelSize)
        {
            this._wings_size = wings_size;
            this._max_people = max_people;
        }
        public double Wings_Size
        {
            get { return _wings_size; }
            set { _wings_size = value; }
        }
        public int Max_People
        {
            get { return _max_people; }
            set { _max_people = value; }
        }

        ~Airplane() { }
        public override int Next_visit()
        {
            return this._km + 30000;
        }
    }
}