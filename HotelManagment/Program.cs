﻿using HotelManagment;
using System.Linq.Expressions;
using System.Transactions;

public  class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Hotel Managment System");

       
        HotelCollections hotelCollections = new HotelCollections();

        while(true){

            Console.WriteLine("enter  0 for adding the hotel\nenter 1 for finding the cheap hotel rates\n enter 2 for finding the chepeast best rated hotel ");

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

                    case 2:
                    Console.WriteLine("enter the first Date for booking ");
                    DateTime startingDate1 = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate1 = Convert.ToDateTime(Console.ReadLine());
                    hotelCollections.findtheCheapestBestRatedHotel( startingDate1, endingDate1); break;
                    case 3:
                    Console.WriteLine("enter the first Date for booking ");
                    DateTime startingDate2 = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter the last Date for booking ");
                    DateTime endingDate2 = Convert.ToDateTime(Console.ReadLine());
                    hotelCollections.findthebestRatedHotel(startingDate2 , endingDate2 ); break;
            }
        }

        
    }
}