﻿using System;
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
           
                Console.WriteLine("provide the regular rate for the hotel ");
                int regularrate = Convert.ToInt32(Console.ReadLine());


                hotels.Add(HotelName, new  Hotel( HotelName,  regularrate).hotelDetails);
               
                
        }

        public void findtheCheapestRates( DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate- startDate ;

            int daysDifference = (difference.Days);
            int max = 999999999;
            foreach(Dictionary<string , int > hotel in hotels.Values)
            {
                foreach (KeyValuePair<string, int> pair in hotel)
                {
                    if (pair.Key.Equals("regularRate"))
                    {
                        if (max > pair.Value * daysDifference)
                        {
                            max = pair.Value * daysDifference;
                            
                        }
                    }
                }

            }
            Console.WriteLine("the chepest price is " + max);


        }

       
    }
}
