using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    internal class Hotel
    {
      
       public  Dictionary<string, Dictionary<string, int>> hotel = new Dictionary<string, Dictionary<string, int>>();

        public Dictionary<string, int> hotelDetails = new Dictionary<string, int>();
        public Hotel( string hotelname , int regularRate ) {

            hotelDetails.Add("regularRate" , regularRate);
           }


    }
}
