using HotelManagment;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hotel Managment System");


        HotelCollections hotelCollections = new HotelCollections();
        string pattren = "[0-9]{4}-[0-9]{2}-[0-9]{2}";
        Regex regex = new Regex(pattren);


        while (true)
        {

            Console.WriteLine("enter  0 for adding the hotel\nenter 1 for finding the cheap hotel rates\n enter 2 for finding the chepeast best rated hotel ");

            int choice = Convert.ToInt32(Console.ReadLine());

           
                switch (choice)

            {
               
                case 0:
                    hotelCollections.AddHotel();
                    break;

                case 1:
                    Console.WriteLine("enter the first Date for booking ");
                    
                    DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
                    string stringDate = Convert.ToString(startingDate);
                    if (regex.IsMatch(stringDate))
                    {
                         throw new  CustomException("please enter the correct date ");
                    }
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate = Convert.ToDateTime(Console.ReadLine());
                    string stringEndingDate = Convert.ToString(startingDate);
                    if (regex.IsMatch(stringEndingDate))
                    {
                        throw new CustomException("please enter the correct date ");
                    }

                    if (endingDate < startingDate)
                    {
                        throw new CustomException("please enter the checkout date greter than booking date  ");
                    }
                    hotelCollections.findtheCheapestRates(startingDate, endingDate); break;
                       

                case 2:
                    Console.WriteLine("enter the first Date for booking ");
                    DateTime startingDate1 = Convert.ToDateTime(Console.ReadLine());
                    string stringDate1 = Convert.ToString(startingDate1);
                    if (regex.IsMatch(stringDate1))
                    {
                        throw new CustomException("please enter the correct date ");
                    }
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate1 = Convert.ToDateTime(Console.ReadLine());
                    string stringEndingDate1 = Convert.ToString(endingDate1);
                    if (regex.IsMatch(stringEndingDate1))
                    {
                        throw new CustomException("please enter the correct date ");
                    }

                    if (endingDate1 < startingDate1)
                    {
                        throw new CustomException("please enter the checkout date greter than booking date  ");
                    }
                    hotelCollections.findtheCheapestBestRatedHotel(startingDate1, endingDate1); break;
                case 3:
                    Console.WriteLine("enter the first Date for booking ");
                    DateTime startingDate2 = Convert.ToDateTime(Console.ReadLine());
                    string stringDate2 = Convert.ToString(startingDate2);
                    if (regex.IsMatch(stringDate2))
                    {
                        throw new CustomException("please enter the correct date ");
                    }
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate2 = Convert.ToDateTime(Console.ReadLine());
                    string endDate2 = Convert.ToString(startingDate2);
                    if (regex.IsMatch(endDate2))
                    {
                        throw new CustomException("please enter the correct date ");
                    }

                    if (endingDate2 <startingDate2)
                    {
                        throw new CustomException("please enter the checkout date greter than booking date  ");
                    }
                    hotelCollections.findthebestRatedHotel(startingDate2, endingDate2); break;

                }   

             
        }


    }
}