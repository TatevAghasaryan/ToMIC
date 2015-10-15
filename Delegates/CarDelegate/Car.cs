using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string  PetName { get; set; }

        public bool _carIsDead;

        public Car()
        {
            MaxSpeed = 100;
        }
        public Car(string name, int maxSp, int crSpeed)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = crSpeed;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;

        public void RegWithCarEngine(CarEngineHandler carEngHandler)
        {
            listOfHandlers = carEngHandler;
        }
    }
}
