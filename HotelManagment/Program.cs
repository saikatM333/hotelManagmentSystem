using HotelManagment;
using System.Linq.Expressions;

public  class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Hotel Managment System");

        Console.WriteLine("enter  0 for adding the hotel");

        int choice = Convert.ToInt32(Console.ReadLine());
        HotelCollections hotelCollections = new HotelCollections();

        switch (choice)
        {
            case 0: hotelCollections.AddHotel();
                break;
        }

        
    }
}