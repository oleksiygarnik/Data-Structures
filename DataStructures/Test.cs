using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Parking : IEnumerable<Car>
    {
        private const int MAX_CARS = 100;

        public string Name { get; set; }

        private List<Car> Cars = new List<Car>();

        public int Count => Cars.Count;

        public Car this[string number]
        {
            get
            {
                var car = Cars.FirstOrDefault(c => c.Number == number);

                return car;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < Cars.Count)
                {
                    return Cars[position];
                }

                return null;
            }
            set
            {
                if (position < Cars.Count)
                {
                    Cars[position] = value;
                }
            }
        }



        public int Add(Car car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }

            if (Cars.Count < MAX_CARS)
            {
                Cars.Add(car);
                return Cars.Count - 1;
            }

            return -1;            
        }

        public void GoOut(string number)
        {
            if(string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number of car is null");
            }

            var car = Cars.FirstOrDefault(c => c.Number == number); //Single кинет Exception

            if (car != null)
            {
                Cars.Remove(car);
            }

        }
        
        public IEnumerator<Car> GetEnumerator()
        {
            return new ParkingEnumenator(Cars);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //public IEnumerator<Car> GetEnumerator()
        //{
        //    return Cars.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return Cars.GetEnumerator();
        //}
    }


    class ParkingEnumenator : IEnumerator<Car>
    {
        private List<Car> _cars;
        private int position = -1;

        public ParkingEnumenator(List<Car> cars)
        {
            _cars = cars;
        }

        public Car Current
        {
            get
            {
                if (position == -1 || position >= _cars.Count)
                    throw new InvalidOperationException();

                return _cars[position];
            }
        }

        object IEnumerator.Current
        {
            get => Current;
        }

        public bool MoveNext()
        {
            if (position < _cars.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}
