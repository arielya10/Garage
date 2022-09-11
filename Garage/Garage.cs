using Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Garage_V1
{
    [Serializable()]
    abstract internal class Garage
    {
        protected string _mame;
        protected string _manufacturer;
        protected int _year;
        protected int _max_speed;
        protected string _error;
        protected int _km;
        protected int _wheelSize;

        public Garage(string name, string manufacturer, int year, string error, int speed,int km,int wheelSize)
        {
            this._mame = name;
            this._manufacturer = manufacturer;
            this._year = year;
            this._max_speed = speed;
            this._error = error;
            this._km = km;
            this._wheelSize = wheelSize;
        }
        public int KM
        {
            get { return _km; }
            set { _km = value; }
        }
        public int Max_speed
        {
            get { return _max_speed; }
            set { _max_speed = value; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
        public string Name
        {
            get { return _mame; }
            set { _mame = value; }
        }
        public int wheelSize
        {
            get { return _wheelSize; }
            set { _wheelSize = value; }
        }

        public abstract int Next_visit();
        ~Garage() { }


    }
    

}
