using HotelManagment;
using System.Linq.Expressions;
using System.Transactions;

public  class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Hotel Managment System");

       
        HotelCollections hotelCollections = new HotelCollections();

        while(true){

            Console.WriteLine("enter  0 for adding the hotel");

            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 0: hotelCollections.AddHotel();
                    break;

                case 1:
                    Console.WriteLine("enter the first Date for booking ");
                    DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate = Convert.ToDateTime(Console.ReadLine());
                    hotelCollections.findtheCheapestRates(startingDate, endingDate); break;
            }
        }

        
    }
}