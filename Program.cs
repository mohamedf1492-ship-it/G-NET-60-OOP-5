namespace OOP5
{

    #region part2 Q1
    /*
    // Interface for printing
    interface IPrintable
    {
        void PrintTicket();
    }

    // Interface for booking and cancellation
    interface IBookable
    {
        bool Book();
        bool Cancel();
    }

    // Base Ticket class
    abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int ticketCounter = 0;

        public int TicketId { get; private set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        protected Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            MovieName = movieName;
            Price = price;
            IsBooked = false;
        }

        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        public virtual void PrintTicket()
        {
            Console.Write(
                "[Ticket #" + TicketId + "] " +
                MovieName + " | " +
                GetTicketType() +
                " | Price: " + Price.ToString("0.##") +
                " | After Tax: " +
                PriceAfterTax.ToString("0.##") +
                " | Booked: " + (IsBooked ? "Yes" : "No"));
        }

        public abstract string GetTicketType();

        // Creates an independent copy with a new ID
        public abstract object Clone();

        protected void CopyBookingStatusTo(Ticket copy)
        {
            copy.IsBooked = IsBooked;
        }

        protected static int GetNextTicketId()
        {
            ticketCounter++;
            return ticketCounter;
        }

        protected void AssignNewId()
        {
            TicketId = GetNextTicketId();
        }

        protected void SetBookingStatus(bool status)
        {
            IsBooked = status;
        }
    }

    // Standard Ticket
    class StandardTicket : Ticket
    {
        public char SeatRow { get; set; }
        public int SeatNumber { get; set; }

        public StandardTicket(
            string movieName,
            decimal price,
            char seatRow,
            int seatNumber)
            : base(movieName, price)
        {
            SeatRow = seatRow;
            SeatNumber = seatNumber;
        }

        public override string GetTicketType()
        {
            return "Standard | Seat: " +
                   SeatRow + SeatNumber;
        }

        public override void PrintTicket()
        {
            Console.Write("[Ticket #" + TicketId + "] " +
                MovieName + " | Standard | Seat: " +
                SeatRow + SeatNumber +
                " | Price: " + Price.ToString("0.##") +
                " | After Tax: " +
                PriceAfterTax.ToString("0.##") +
                " | Booked: " + (IsBooked ? "Yes" : "No"));

            Console.WriteLine();
        }

        public override object Clone()
        {
            StandardTicket copy = new StandardTicket(
                MovieName, Price, SeatRow, SeatNumber);

            copy.AssignNewId();
            copy.SetBookingStatus(false);

            return copy;
        }
    }

    // VIP Ticket
    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public VIPTicket(
            string movieName,
            decimal price,
            bool loungeAccess,
            decimal serviceFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = serviceFee;
        }

        public override string GetTicketType()
        {
            return "VIP";
        }

        public override void PrintTicket()
        {
            Console.Write("[Ticket #" + TicketId + "] " +
                MovieName + " | VIP | Lounge: " +
                (LoungeAccess ? "Yes" : "No") +
                " | Fee: " + ServiceFee.ToString("0.##") +
                " | Price: " + Price.ToString("0.##") +
                " | After Tax: " +
                PriceAfterTax.ToString("0.##") +
                " | Booked: " + (IsBooked ? "Yes" : "No"));

            Console.WriteLine();
        }

        public override object Clone()
        {
            VIPTicket copy = new VIPTicket(
                MovieName, Price, LoungeAccess, ServiceFee);

            copy.AssignNewId();
            copy.SetBookingStatus(false);

            return copy;
        }
    }

    // IMAX Ticket
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(
            string movieName,
            decimal price,
            bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override string GetTicketType()
        {
            return "IMAX";
        }

        public override void PrintTicket()
        {
            Console.Write("[Ticket #" + TicketId + "] " +
                MovieName + " | IMAX | 3D: " +
                (Is3D ? "Yes" : "No") +
                " | Price: " + Price.ToString("0.##") +
                " | After Tax: " +
                PriceAfterTax.ToString("0.##") +
                " | Booked: " + (IsBooked ? "Yes" : "No"));

            Console.WriteLine();
        }

        public override object Clone()
        {
            IMAXTicket copy = new IMAXTicket(
                MovieName, Price, Is3D);

            copy.AssignNewId();
            copy.SetBookingStatus(false);

            return copy;
        }
    }

    // Cinema class
    class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void CloseCinema()
        {
            Console.WriteLine("=== Cinema Closed ===");
        }

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets ---");

            foreach (Ticket ticket in tickets)
            {
                if (ticket != null)
                    ticket.PrintTicket();
            }
        }
    }

    // Utility class
    static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            foreach (IPrintable item in items)
            {
                if (item != null)
                    item.PrintTicket();
            }
        }
    }
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 Q1
            /*
            An interface in C# is a contract that defines methods or properties a class must implement.

            We use interfaces instead of depending directly on concrete classes because they provide:

                 Loose Coupling: Reduces dependency between classes.
                 Flexibility: Different classes can implement the same interface in different ways.
                 Testability: Makes unit testing and mocking easier.
                 Polymorphism: Allows different objects to be handled through the same interface.
            */
            #endregion

            #region part1 Q2
            /*
            a) The problem is that both interfaces define a method named Greet(), but the class provides only one public implementation.
            Therefore, both interfaces use the same method implementation, which prints "Hello / Ahlan".

            b) The solution is to use Explicit Interface Implementation:
            c) No, translator.Greet() cannot be called directly because the methods are implemented explicitly.
            We must call each method through its interface reference:

            */
            #endregion

            #region part1 Q3
            /*
            Shallow Copy: Creates a new object but copies reference-type fields as references, 
            so the original and copied objects share the same referenced objects.

            Deep Copy: Creates a new object and independent copies of its referenced objects.

            Shallow Copy: Useful when sharing referenced objects is acceptable or when the object contains only value types
            and immutable references.

            Deep Copy: Useful when the copy must be fully independent from the original.
            */
            #endregion

            #region part1 Q4
            /*
            the output is:
                       Dev - Testing
                       QA - Testing
            MemberwiseClone() creates a shallow copy. The Title field is a string reference that is reassigned independently 
            when e2.Title = "QA" is executed. However, e1.Dept and e2.Dept refer to the same Department object.
            Therefore, changing e2.Dept.Name to "Testing" also changes the department name observed through e1.


            */
            #endregion

            #region part2 Q1
            /*
             Cinema cinema = new Cinema();

            // a. Open cinema
            cinema.OpenCinema();

            // b. Create tickets
            StandardTicket standard = new StandardTicket(
                "Inception", 80m, 'A', 5);

            VIPTicket vip = new VIPTicket(
                "Avengers", 200m, true, 50m);

            IMAXTicket imax = new IMAXTicket(
                "Dune", 130m, true);

            standard.Book();
            vip.Book();
            imax.Book();

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            // c. Print all tickets
            cinema.PrintAllTickets();

            // d. Clone VIP ticket
            Console.WriteLine("\n--- Clone Test ---");

            VIPTicket clone = (VIPTicket)vip.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original : ");
            vip.PrintTicket();

            Console.Write("Clone    : ");
            clone.PrintTicket();

            // e. Cancel one ticket
            Console.WriteLine("\n--- After Cancellation ---");

            standard.Cancel();
            standard.PrintTicket();

            // f. Print through IPrintable
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");

            IPrintable[] printableTickets =
            {
                standard,
                vip,
                imax
            };

            BookingHelper.PrintAll(printableTickets);

            // g. Close cinema
            Console.WriteLine();
            cinema.CloseCinema();
            */
            #endregion


        }
    }
}
