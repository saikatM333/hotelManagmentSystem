using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagment
{
    public  class HotelCollections
    {
        public static Dictionary<string , Dictionary<string , int >> hotels  = new Dictionary<string, Dictionary<string, int>>();


        public void AddHotel()
        {
            


                Console.WriteLine("add the hotel name in the hotel reservation system to add the hotel");
                string HotelName = Console.ReadLine();

            Console.WriteLine("provide the regular WeekDay rates for the hotel ");
            int regularWeekDayRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("provide the regular week end rate for the hotel ");
            int regularWeekEndRate = Convert.ToInt32(Console.ReadLine());



            hotels.Add(HotelName, new  Hotel( HotelName,  regularWeekDayRate, regularWeekEndRate).hotelDetails);
               
                
        }

        public void findtheCheapestRates(DateTime startDate, DateTime endDate)

        {
            TimeSpan difference = endDate - startDate;
            int daysDifference = difference.Days;

            int countWeekend = 0;
            List<string> hotelname = new List<string>();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1)) // Fixed loop
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    countWeekend++;
                }
            }

            int countWeekDay = daysDifference - countWeekend;

            int min = int.MaxValue;
            string cheapestHotel = "";

            foreach (KeyValuePair<string, Dictionary<string, int>> hotel in hotels)
            {
                int value = 0;
                foreach (KeyValuePair<string, int> pair in hotel.Value)
                {
                    if (pair.Key.Equals("regularWeekDayRate"))
                    {
                        value += pair.Value * countWeekDay;
                    }

                    if (pair.Key.Equals("regularWeekEndRate"))
                    {
                        value += pair.Value * countWeekend;
                    }
                }

                if (min >= value)
                {
                    min = value;
                    //cheapestHotel = hotel.Key;
                    hotelname.Add(hotel.Key);
                }
            }
            foreach (var hotel in hotelname)
            {
                Console.Write(hotel+", ");
            }

            Console.WriteLine("the minimum rate is {0}", min);
        }


    }
}
