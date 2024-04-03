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
    public class HotelCollections
    {
        public static Dictionary<string, Dictionary<string, int>> hotels = new Dictionary<string, Dictionary<string, int>>();


        public void AddHotel()
        {



            Console.WriteLine("add the hotel name in the hotel reservation system to add the hotel");
            string HotelName = Console.ReadLine();

            Console.WriteLine("provide the regular WeekDay rates for the hotel ");
            int regularWeekDayRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("provide the regular week end rate for the hotel ");
            int regularWeekEndRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("provide the rating for hotel");
            int ratings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("provide the rewarded weekday rate for the hotel ");
            int rewardedWeekDayRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("provide the rewarded weekend  rate for the hotel ");
            int rewardedWeekEndRate = Convert.ToInt32(Console.ReadLine());






            hotels.Add(HotelName, new Hotel(HotelName, ratings, regularWeekDayRate, regularWeekEndRate, rewardedWeekDayRate, rewardedWeekEndRate).hotelDetails);


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
                Console.Write(hotel + ", ");
            }

            Console.WriteLine("the minimum rate is {0}", min);
        } 

        public void findtheCheapestBestRatedHotel(DateTime bookingDate , DateTime checkoutDate)
        {    Dictionary<string , ArrayList >listofHotel = new Dictionary<string, ArrayList> ();
            ArrayList hotelratingAndCost = new ArrayList ();
            TimeSpan difference = checkoutDate - bookingDate;
            int daysDifference = difference.Days;

            int countWeekend = 0;
            List<string> hotelname = new List<string>();

            for (DateTime date = bookingDate; date <= checkoutDate; date = date.AddDays(1)) // Fixed loop
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    countWeekend++;
                }
            }

            int countWeekDay = daysDifference - countWeekend;

            int sumOfratings = hotels.Values
            .Sum(innerDictionary => innerDictionary.ContainsKey("ratings") ? innerDictionary["ratings"] : 0);

            int averageRating  = sumOfratings / hotels.Count;
            int minRate =int.MaxValue;
            int value = 0;
            foreach(var hotel in hotels)
            {
                if (hotel.Value["ratings"] == averageRating)
                {
                    value = hotel.Value["regularWeekDayRate"] * countWeekDay + hotel.Value["regularWeekEndRate"] * countWeekend;
                    if (minRate > value)
                    {
                        hotelratingAndCost.Add(hotel.Value["ratings"]);
                        hotelratingAndCost.Add((int)value);
                        listofHotel.Add(hotel.Key ,hotelratingAndCost );
                    }

                }
            }

            foreach (var Pair in listofHotel)
            {
                string Hotelname = Pair.Key;
                int rate = (int )Pair.Value[0];
                int ratings = (int)Pair.Value[1];

                Console.WriteLine($"Hotel Name : {Hotelname}, rating : {ratings}, TotalRate: {rate}");
            }


        }

        public void findthebestRatedHotel(DateTime bookingDate, DateTime checkoutDate)
        {
            TimeSpan difference = checkoutDate - bookingDate;
            int daysDifference = difference.Days;

            int countWeekend = 0;
            List<string> hotelname = new List<string>();

            for (DateTime date = bookingDate; date <= checkoutDate; date = date.AddDays(1)) // Fixed loop
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    countWeekend++;
                }
            }

            int countWeekDay = daysDifference - countWeekend;


            var sortedNestedDictionary = hotels.OrderByDescending(kv => kv.Value["ratings"]);
            var maxratedHotel = sortedNestedDictionary.First();
            int maxrating = maxratedHotel.Value["ratings"];
            Dictionary<string, int> listofMaxratedHotel = new Dictionary<string, int>();

            foreach (var kv in sortedNestedDictionary)
            {
                int value = 0;
                if (maxrating == kv.Value["ratings"])
                {
                    value = kv.Value["regularWeekDayRate"] * countWeekDay + kv.Value["regularWeekEndRate"] * countWeekend;
                    listofMaxratedHotel.Add(kv.Key, value);
                }

            }



            foreach (var Pair in listofMaxratedHotel)
            {
                string Hotelname = Pair.Key;
                int value = Pair.Value;

                Console.WriteLine($"Hotel Name : {Hotelname}, TotalRate: {value}");
            }

        }


    }



}
