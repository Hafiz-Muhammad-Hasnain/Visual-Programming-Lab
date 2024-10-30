using System;
using System.Collections.Generic;

namespace Ride_Sharing_System
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public User(int id, string name, string phone)
        {
            UserId = id;
            UserName = name;
            PhoneNumber = phone;
        }
    }

    public class Rider : User
    {
        public List<Trip> RideHistory { get; set; } = new List<Trip>();

        public Rider(int id, string name, string phone) : base(id, name, phone) { }

        public void RequestRide(RideSharingSystem system, string startLocation, string destination)
        {
            Trip trip = new Trip(system.GenerateTripID(), this.UserName, null, startLocation, destination, 0, "Requested");
            system.AvailableTrips.Add(trip);
            Console.WriteLine($"Ride requested from {startLocation} to {destination}.");
        }

        public void ViewRideHistory()
        {
            Console.WriteLine("Ride History:");
            foreach (var trip in RideHistory)
            {
                Console.WriteLine($"Trip ID: {trip.TripID}, From: {trip.StartLocation}, To: {trip.Destination}, Status: {trip.Status}");
            }
        }
    }

    public class Trip
    {
        public int TripID { get; set; }
        public string RiderName { get; set; }
        public string DriverName { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public double Fare { get; set; }
        public string Status { get; set; }

        public Trip(int id, string riderName, string driverName, string startLocation, string destination, double fare, string status)
        {
            TripID = id;
            RiderName = riderName;
            DriverName = driverName;
            StartLocation = startLocation;
            Destination = destination;
            Fare = fare;
            Status = status;
        }

        public void CalculateFare()
        {
            Fare = 10.0 + (StartLocation.Length + Destination.Length) * 0.5;
        }
    }

    public class Driver : User
    {
        public string VehicleDetail { get; set; }
        public bool IsAvailable { get; set; }
        public List<Trip> TripHistory { get; set; } = new List<Trip>();

        public Driver(int id, string name, string phone, string vehicleDetail) : base(id, name, phone)
        {
            VehicleDetail = vehicleDetail;
            IsAvailable = true;
        }

        public void AcceptRide(Trip trip)
        {
            if (IsAvailable && trip.Status == "Requested")
            {
                trip.DriverName = this.UserName;
                trip.Status = "Accepted";
                trip.CalculateFare();
                TripHistory.Add(trip);
                IsAvailable = false;
                Console.WriteLine($"Ride accepted for trip ID: {trip.TripID}");
            }
            else
            {
                Console.WriteLine("Ride cannot be accepted.");
            }
        }

        public void ViewTripHistory()
        {
            Console.WriteLine("Trip History:");
            foreach (var trip in TripHistory)
            {
                Console.WriteLine($"Trip ID: {trip.TripID}, Rider: {trip.RiderName}, From: {trip.StartLocation}, To: {trip.Destination}, Status: {trip.Status}");
            }
        }

        public void ToggleAvailability()
        {
            IsAvailable = !IsAvailable;
            Console.WriteLine($"Driver availability toggled. Now available: {IsAvailable}");
        }
    }

    public class RideSharingSystem
    {
        public List<Rider> RegisteredRiders { get; set; } = new List<Rider>();
        public List<Driver> RegisteredDrivers { get; set; } = new List<Driver>();
        public List<Trip> AvailableTrips { get; set; } = new List<Trip>();
        private int tripCounter = 1;

        public int GenerateTripID()
        {
            return tripCounter++;
        }

        public void RegisterUser(User user)
        {
            if (user is Rider)
            {
                RegisteredRiders.Add((Rider)user);
                Console.WriteLine("Rider registered successfully.");
            }
            else if (user is Driver)
            {
                RegisteredDrivers.Add((Driver)user);
                Console.WriteLine("Driver registered successfully.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
        }