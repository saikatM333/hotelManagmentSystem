using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    internal class Hotel
    {
        //public  Dictionary<string, Dictionary<string, int>> hotel = new Dictionary<string, Dictionary<string, int>>();

        public Dictionary<string, int> hotelDetails = new Dictionary<string, int>();
       
        public Hotel(string hotelname, int rating, int regularWeekDayRate, int regularWeekEndRate, int rewardedWeekdayRate, int rewardedWeekEndRate)
        {
            hotelDetails.Add("ratings", rating);
            hotelDetails.Add("regularWeekDayRate", regularWeekEndRate);
            hotelDetails.Add("regularWeekEndRate", regularWeekEndRate);
            hotelDetails.Add("rewardedWeekdayRate", rewardedWeekdayRate);
            hotelDetails.Add("rewardedWeekEndRate", rewardedWeekEndRate);
        }
    }
}
