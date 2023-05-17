using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// code before Applying Builder Pattern//
/*namespace Dp_Hotel_Project
{
    public class Room
    {
        public string NumberRoom { get; set; }
        public int FloorRoom { get; set; }
        public string TypeRoom { get; set; }
        public decimal RoomPrice { get; set; }

        public Biodata Biodata { get; set; }
        public List<Room> ListNumberRoom { get; set; }

        public Room() { }

        public Room(string numberRoom, int floorRoom, string typeRoom, decimal priceRoom)
        {
            this.NumberRoom = numberRoom;
            this.FloorRoom = floorRoom;
            this.TypeRoom = typeRoom;
            this.RoomPrice = priceRoom;
        }

        public Room(List<Room> listRoom)
        {
            this.ListNumberRoom = listRoom;
        }

        public void PrintRoomInformation()
        {
            Console.WriteLine("Stayed at");
            Console.WriteLine("Room Number \t: {0}", this.NumberRoom);
            Console.WriteLine("Floor \t\t: {0}", this.FloorRoom);
            Console.WriteLine("Room Type \t: {0}", this.TypeRoom);
            Console.WriteLine("Price \t\t: {0}", this.RoomPrice.ToString("C2"));
            Console.WriteLine("\nReservation History:");
        }



    }
}*/

//---------------------- OBERVER PATTERN ----------------//

/* The Observer pattern is suitable when there is a one-to-many relationship between objects, 
    where the change in one object's state should trigger updates in multiple dependent objects.*/

// To apply the Observer pattern to the Room class, we can introduce an IRoomObserver interface and modify the class as follows

namespace Dp_Hotel_Project
{
    public class Room
    {
        public string NumberRoom { get; set; }
        public int FloorRoom { get; set; }
        public string TypeRoom { get; set; }
        public decimal RoomPrice { get; set; }

        private List<IRoomObserver> observers = new List<IRoomObserver>();

        public Room(string numberRoom, int floorRoom, string typeRoom, decimal priceRoom)
        {
            NumberRoom = numberRoom;
            FloorRoom = floorRoom;
            TypeRoom = typeRoom;
            RoomPrice = priceRoom;
        }

        public void AddObserver(IRoomObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IRoomObserver observer)
        {
            observers.Remove(observer);
        }

        public void PrintRoomInformation()
        {
            Console.WriteLine("Stayed at");
            Console.WriteLine("Room Number \t: {0}", NumberRoom);
            Console.WriteLine("Floor \t\t: {0}", FloorRoom);
            Console.WriteLine("Room Type \t: {0}", TypeRoom);
            Console.WriteLine("Price \t\t: {0}", RoomPrice.ToString("C2"));
            Console.WriteLine("\nReservation History:");
        }

        private void NotifyObservers()
        {
            foreach (IRoomObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void UpdateRoomInformation(string numberRoom, int floorRoom, string typeRoom, decimal priceRoom)
        {
            NumberRoom = numberRoom;
            FloorRoom = floorRoom;
            TypeRoom = typeRoom;
            RoomPrice = priceRoom;

            NotifyObservers();
        }
    }

    public interface IRoomObserver
    {
        void Update(Room room);
    }

    public class Guest1 : IRoomObserver
    {
        public string Name { get; set; }

        public Guest1(string name)
        {
            Name = name;
        }

        public void Update(Room room)
        {
            Console.WriteLine("Notification for Guest: {0}", Name);
            Console.WriteLine("Room information has been updated.");
            Console.WriteLine("New Room Number: {0}", room.NumberRoom);
            Console.WriteLine("New Floor: {0}", room.FloorRoom);
            Console.WriteLine("New Room Type: {0}", room.TypeRoom);
            Console.WriteLine("New Price: {0}\n", room.RoomPrice.ToString("C2"));
        }
    }
}

    


