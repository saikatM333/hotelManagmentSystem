using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    public  class HotelCollections
    {
        public static Dictionary<string , Dictionary<string , int >> hotels  = new Dictionary<string , Dictionary<string , int >>();


        public void AddHotel()
        {
            


                Console.WriteLine("add the hotel name in the hotel reservation system to add the hotel");
                string HotelName = Console.ReadLine();
           
                Console.WriteLine("provide the regular rate for the hotel ");
                int regularrate = Convert.ToInt32(Console.ReadLine());


                hotels.Add(HotelName, new  Hotel( HotelName,  regularrate).hotelDetails);
               
                
        }

       
    }
}
