using System;

namespace Demo_Strategy_Pattern
{
    public interface IStrategy
    {
        string GetTravelTime(string source, string destination);
    }
    public class CarStrategy : IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 40 minutes to reach from " + source + " to " + destination + " using Car.";
        }
    }
    public class BikeStrategy : IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 25 minutes to reach from " + source + " to " + destination + " using Bike.";
        }
    }
    public class BusStrategy : IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";
        }
    }
    public class TravelStrategy
    {
        private IStrategy _strategy;
        public TravelStrategy(IStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }
        public void GetTravelTime(string source, string destination)
        {
            var result = _strategy.GetTravelTime(source, destination);
            Console.WriteLine(result);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");
            var userStrategy = Console.ReadLine().ToLower();
            Console.WriteLine("User has selected *" + userStrategy + "* as mode of transport");
            Console.WriteLine("**************************************************************");
            switch (userStrategy)
            {
                case "car":
                    new TravelStrategy(new CarStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                case "bike":
                    new TravelStrategy(new BikeStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                case "bus":
                    new TravelStrategy(new BusStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                default:
                    Console.WriteLine("You have chosen an invalid mode of transport.");
                    break;
            }
        }
    }
}
