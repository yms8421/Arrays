using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.CarPark
{
    class ParkManager
    {
        Car[] park = new Car[10];
        public void SaveCar(string plateCode)
        {
            var newCar = new Car();
            newCar.plate = plateCode;
            newCar.entrance = DateTime.Now;
            var index = GetEmptySlot();
            park[index] = newCar; //ilk boş buluğu yer olsun
        }

        public Car[] GetCars()
        {
            return park;
        }

        private int GetEmptySlot()
        {
            for (var i = 0; i < park.Length; i++)
            {
                if (park[i] == null)
                {
                    return i;
                }
            }
            return -1; // Neden -1.... Dizinin -1. index'i vardır. O da hiçbiri demektir
        }
    }
}


/*
 
    private aslında default olarak access modifer anlamında kullanılmıştır
     
     */
