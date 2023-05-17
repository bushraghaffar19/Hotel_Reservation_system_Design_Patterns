using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Hotel_Project
{
    public class Guest
    {
        public string NumberRegister { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int LengthOfStay { get; set; }

        public Biodata Biodata { get; set; }
        public List<Guest> Family { get; set; }
        public Room Room { get; set; }
        
        public Guest() { }

        public Guest(Biodata biodata, string numberRegister, DateTime dateCheckIn, DateTime dateCheckOut ,Room room)
        {
            this.Biodata = biodata;
            this.NumberRegister = numberRegister;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.LengthOfStay = this.DateCheckOut.Day - this.DateCheckIn.Day;
            this.Family = new List<Guest>();
            this.Room = room;
        }

        public decimal AccomodationCost()
        {
            if (this.Family.Count == 0)
            {
                return this.Room.RoomPrice * LengthOfStay - ((this.Room.RoomPrice * LengthOfStay) * (Convert.ToDecimal(0.5)));
            }
            else
            {

                return this.Room.RoomPrice * LengthOfStay;
            }
            
        }

        public void PrintTamu()
        {
            Console.WriteLine("{0} with registration number \t: {1}", Biodata.FullName(),this.NumberRegister);
        }

        public void PrintGuestInformation()
        {
            Console.WriteLine("Stay duration \t: {0} hour", this.LengthOfStay);
            Console.WriteLine("Accommodation cost \t: {0}", AccomodationCost().ToString("C2"));
        }

        public void ReservationHistory()
        {
            Console.WriteLine("{0} - {1} ({2}, {3})", this.DateCheckIn.ToString("dd MMMM yyyy"), this.DateCheckOut.ToString("dd MMMM yyyy"), this.Biodata.FullName(), this.NumberRegister);
        }

        public void InfoBiodata()
        {
            Console.WriteLine("\r\nHere is the guest information {0}", this.NumberRegister);
            Console.WriteLine("\nFirst Name \t\t: {0}", this.Biodata.FirstName);
            Console.WriteLine("Last Name \t\t: {0}", this.Biodata.LastName);
            Console.WriteLine("Gender \t\t\t: {0}", this.Biodata.Gender);
            Console.WriteLine("Birth Information \t: {0}, ({1} year)", this.Biodata.DateOfBirth.ToString("dd MMMM yyyy"), Biodata.Age());
            Console.WriteLine("ID Card \t\t: {0}", this.Biodata.IDNumber);
        }

        public void InfoRoom()
        {
            Console.WriteLine("\nStayed in");
            Console.WriteLine("Room number \t\t: {0}", this.Room.NumberRoom);
            Console.WriteLine("Floor \t\t\t: {0}", this.Room.FloorRoom);
            Console.WriteLine("Room type \t\t: {0}", this.Room.TypeRoom);
        }

        public void FamilyMember()
        {
            Console.WriteLine("\nFamily member:");
            foreach (Guest item in Family)
            {
                Console.WriteLine("{0} with Registration Number \t: {1}", item.Biodata.FullName(), item.NumberRegister);
            }
        }

    }
}
