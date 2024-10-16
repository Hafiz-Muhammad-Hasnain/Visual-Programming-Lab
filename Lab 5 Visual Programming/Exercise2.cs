using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Customer(int customerId, string lastName, string firstName, string street, string city, string zipCode, string phone, string email, string password)
    {
        CustomerId = customerId;
        LastName = lastName;
        FirstName = firstName;
        Street = street;
        City = city;
        ZipCode = zipCode;
        Phone = phone;
        Email = email;
        Password = password;
    }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public Flight Flight { get; set; }
    public Seat[] Seats { get; set; }

    public Reservation(int reservationNo, DateTime date, Flight flight, Seat[] seats)
    {
        ReservationNo = reservationNo;
        Date = date;
        Flight = flight;
        Seats = seats;
    }
}

public class Flight
{
    public int FlightId { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public int SeatingCapacity { get; set; }

    public Flight(int flightId, string origin, string destination, DateTime departureTime, int seatingCapacity)
    {
        FlightId = flightId;
        Origin = origin;
        Destination = destination;
        DepartureTime = departureTime;
        SeatingCapacity = seatingCapacity;
    }
}

public class Seat
{
    public int RowNo { get; set; }
    public string SeatNo { get; set; }
    public bool Status { get; set; } 

    public Seat(int rowNo, string seatNo, bool status)
    {
        RowNo = rowNo;
        SeatNo = seatNo;
        Status = status;
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer(
            1, "Khan", "Ali", "123 Main Street", "Karachi", "75500", "03001234567", "ali.khan@example.com", "password123"
        );

        Flight flight = new Flight(
            1001, "Karachi", "Lahore", new DateTime(2024, 10, 20, 14, 30, 0), 180
        );

        Seat[] seats = new Seat[]
        {
            new Seat(1, "1A", true), 
            new Seat(1, "1B", false) 
        };
        Reservation reservation = new Reservation(5001, DateTime.Now, flight, seats);

        Console.WriteLine($"Reservation Number: {reservation.ReservationNo}");
        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"Flight from {reservation.Flight.Origin} to {reservation.Flight.Destination}");
        Console.WriteLine($"Departure Time: {reservation.Flight.DepartureTime}");
        Console.WriteLine("Seats:");
        foreach (var seat in reservation.Seats)
        {
            string status = seat.Status ? "Booked" : "Available";
            Console.WriteLine($"  - Seat {seat.SeatNo} (Row {seat.RowNo}): {status}");
        }
    }
}