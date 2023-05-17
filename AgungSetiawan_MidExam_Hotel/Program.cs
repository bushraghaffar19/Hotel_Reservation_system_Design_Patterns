using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Hotel_Project
{
    class Program
    {

        public static Dictionary<string, Guest> listGuest = new Dictionary<string, Guest>();
        public static Dictionary<string, Room> listRoom = new Dictionary<string, Room>();

        static void Main(string[] args)
        {

            #region datadummy
            // ---------------- Builder Class Object --------------//

            /*Biodata biodataBushra = new Biodata("Bushra", "Ghaffar", new DateTime(2001, 01 ,01), "Karachi", "Female", 312008923111990002, "A021");
            Biodata biodataAabira = new Biodata("Aabira", "Fahim", new DateTime(2001,7, 20), "Karachi", "Female", 312008911111990002, "A022");
            Biodata biodataMahnoor = new Biodata("Mahnoor", "Waseem ", new DateTime(2001, 4, 18), "Lahore", "Female", 312008923111990002, "A023");
            Biodata biodataRamsha = new Biodata("Ramsha", "Iqbal", new DateTime(2001, 8, 1), "Hyderabad", "Female", 312008901081990002, "A024");
            Biodata biodataMuliawan = new Biodata("Muliawan", "Sanjaya", new DateTime(2000, 10, 10), "Peshawar", "Male", 3120089010102000002, "A025");
            Biodata biodataTirta = new Biodata("Tirta", "Raharja", new DateTime(2002, 10, 14), "Lahore", "Male", 3120089014101988002, "A026");*/

            Biodata biodata1 = new BiodataBuilder()
                .SetFirstName("Bushra")
                .SetLastName("Ghaffar")
                .SetDateOfBirth(new DateTime(2001, 01, 01))
                .SetPlaceOfBirth("Karachi")
                .SetGender("Female")
                .SetIDNumber(987654321)
                .SetNumberRegister("B456")
                .Build();

            Biodata biodata2 = new BiodataBuilder()
                .SetFirstName("Aabira")
                .SetLastName("Fahim")
                .SetDateOfBirth(new DateTime(2001, 07, 20))
                .SetPlaceOfBirth("Islamabad")
                .SetGender("Female")
                .SetIDNumber(567890123)
                .SetNumberRegister("C789")
                .Build();

            Biodata biodata3 = new BiodataBuilder()
                .SetFirstName("Mahnoor")
                .SetLastName("Waseem")
                .SetDateOfBirth(new DateTime(2001, 3, 20))
                .SetPlaceOfBirth("Lahore")
                .SetGender("Female")
                .SetIDNumber(654321098)
                .SetNumberRegister("D012")
                .Build();

            Biodata biodata4 = new BiodataBuilder()
                .SetFirstName("Ali")
                .SetLastName("Rehman")
                .SetDateOfBirth(new DateTime(2000, 3, 20))
                .SetPlaceOfBirth("Sydney")
                .SetGender("Male")
                .SetIDNumber(654321098)
                .SetNumberRegister("D012")
                .Build();

            Biodata biodata5 = new BiodataBuilder()
                .SetFirstName("Ramsha")
                .SetLastName("Iqbal")
                .SetDateOfBirth(new DateTime(2001, 3, 10))
                .SetPlaceOfBirth("Peshawar")
                .SetGender("Female")
                .SetIDNumber(654321098)
                .SetNumberRegister("D012")
                .Build();

            Biodata biodata6 = new BiodataBuilder()
                .SetFirstName("Aliyan")
                .SetLastName("Ali")
                .SetDateOfBirth(new DateTime(2000, 3, 20))
                .SetPlaceOfBirth("London")
                .SetGender("Male")
                .SetIDNumber(654321098)
                .SetNumberRegister("D012")
                .Build();

            // ---------------- Builder Class Object End --------------//

            //---------------------- Room Observer Class Object ----------------//

             Room room301 = new Room("301", 3, "Regular single bed", 800000m);
             Room room302 = new Room("302", 3, "Regular double bed", 1000000m);
             Room room303 = new Room("303", 3, "Regular twin bed", 1200000m);
             Room room401 = new Room("401", 4, "VIP single bed", 1000000m);
             Room room402 = new Room("402", 4, "VIP double bed", 1200000m);
             Room room403 = new Room("403", 4, "VIP twin bed", 1400000m);


             /*listRoom.Add("301", new Room("301", 3, "Regular single bed", 800000m));
             listRoom.Add("302", new Room("302", 3, "Regular double bed", 1000000m));
             listRoom.Add("303", new Room("303", 3, "Regular twin bed", 1200000m));
             listRoom.Add("401", new Room("401", 4, "VIP single bed", 1000000m));
             listRoom.Add("402", new Room("402", 4, "VIP double bed", 1200000m));
             listRoom.Add("403", new Room("403", 4, "VIP twin bed", 1400000m));*/


            listRoom.Add(room301.NumberRoom, room301);
            listRoom.Add(room302.NumberRoom, room302);
            listRoom.Add(room303.NumberRoom, room303);
            listRoom.Add(room401.NumberRoom, room401);
            listRoom.Add(room402.NumberRoom, room402);
            listRoom.Add(room403.NumberRoom, room403);

            Guest bushra = new Guest(biodata1, "A021", new DateTime(2018, 4, 12), new DateTime(2018, 4, 14), room301);
            Guest aabira = new Guest(biodata2, "A022", new DateTime(2018, 4, 12), new DateTime(2018, 4, 14), room301);
            Guest mahnoor = new Guest(biodata3, "A023", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), room302);
            Guest muliawan = new Guest(biodata4, "A025", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), room302);
            Guest ramsha = new Guest(biodata5, "A024", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), room302);
            Guest tirta = new Guest(biodata6, "A026", new DateTime(2018, 5, 15), new DateTime(2018, 5, 18), room401);

            listGuest.Add("A021", bushra);
            listGuest.Add("A022", aabira);
            listGuest.Add("A023", mahnoor);
            listGuest.Add("A024", muliawan);
            listGuest.Add("A025", ramsha);
            listGuest.Add("A026", tirta);

            listGuest["A021"].Family.Add(aabira);
            listGuest["A022"].Family.Add(bushra);
            listGuest["A023"].Family.Add(ramsha);
            listGuest["A023"].Family.Add(muliawan);
            listGuest["A024"].Family.Add(mahnoor);
            listGuest["A024"].Family.Add(muliawan);
            listGuest["A025"].Family.Add(mahnoor);
            listGuest["A025"].Family.Add(ramsha);

            #endregion

            string input = String.Empty;
            input = MainMenu(input);

        }

        private static string MainMenu(string input)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Welcome to Hotel Design Pattern");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. All visitor data");
            Console.WriteLine("2. All room data");
            Console.WriteLine("3. About the hotel");
            Console.WriteLine("4. Exit the application");
            Console.Write("Please select a menu number to access the menu. (1/2/3/4) : ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    VisitorData(input);

                    return input;
                case "2":
                    Console.Clear();
                    DataRoom(input, listRoom);

                    return input;
                case "3":
                    Console.Clear();
                    AboutTheHotel(input);

                    return input;
                case "4":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Thank you for using this application");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;

                    //total Income hotel
                    List<Guest> listGuestNew = new List<Guest>();
                    foreach (Guest item in listGuest.Values)
                    {
                        if (listGuest.Count == 0 || item.Family.Count == 0)
                        {
                            listGuestNew.Add(item);
                            break;
                        }
                        foreach (Guest guest in item.Family)
                        {
                            if (listGuestNew.Contains(guest))
                            {
                                break;
                            }
                            else
                            {
                                listGuestNew.Add(item);
                            }
                        }
                    }

                    for (int i = 0; i < listGuestNew.Count; i++)
                    {
                        try
                        {
                            if (listGuestNew[i] == listGuestNew[i + 1])
                            {
                                listGuestNew.RemoveAt(i);
                            }
                        }
                        catch
                        {
                            if (listGuestNew[i] == listGuestNew[0])
                            {
                                listGuestNew.RemoveAt(0);
                            }
                            
                        }
                    }

                    //foreach (Guest item in listGuestNew)
                    //{
                    //    Console.WriteLine(item.Biodata.FullName());
                    //}

                    decimal Income = 0;
                    foreach (Guest item in listGuestNew)
                    {
                        Income += item.AccomodationCost();
                    }
                    Console.WriteLine(Income.ToString("C2"));
                    MainMenu(input);
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("The option is not available!");
                    MainMenu(input);
                    break;
            }
            return input;
        }

        private static void VisitorData(string input)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Here is a list of hotel guests.");
            Console.WriteLine("--------------------------------------");
            foreach (Guest item in listGuest.Values)
            {
                item.PrintTamu();
            }
            Console.WriteLine("\nSelect a menu number to access the menu. (1/2/3) : ");
            Console.WriteLine("\t1. Visitor information.");
            Console.WriteLine("\t2. Return to the main menu.");
            Console.WriteLine("\t3. Exit the application.");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //Console.Clear();
                    VisitorInformation(input);
                    break;
                case "2":
                    Console.Clear();
                    MainMenu(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Thank you for using this application");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not available!\n");
                    VisitorData(input);
                    break;
            }
        }

        private static void VisitorInformation(string input)
        {
            Console.Write("Please enter the Register number for which you want to view the information : ");
            input = Console.ReadLine().Trim();
            if (!(listGuest.Keys.Contains(input)))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, the register number you entered is not valid. Please try again\n");
                VisitorInformation(input);
            }

            Console.Clear();
            //The criteria for guests who are staying alone is that they will receive a discount 50%
            foreach (Guest item in listGuest.Values)
            {
                if (input.Equals(item.NumberRegister))
                {
                    item.InfoBiodata();
                    item.PrintGuestInformation();
                    item.InfoRoom();
                    item.FamilyMember();
                }
            }
            Console.WriteLine("\n\r\nPlease select a menu number to access its menu (1/2/3) : ");
            Console.WriteLine("\t1. Go back to all visitor data");
            Console.WriteLine("\t2. Go back to the main menu");
            Console.WriteLine("\t3. Exit the application");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    VisitorData(input);
                    break;
                case "2":
                    Console.Clear();
                    MainMenu(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("You're welcome! Feel free to ask. Have a great day!");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not available!\n");
                    break;
            }
        }
    // ------------------ Adding Notification Feature here --------------//
   //-------------------  Observer Pattern  ----------------------------//

        private static void DataRoom(string input, Dictionary<string, Room> listRoom)
        {
            Console.Write("Floor 3: ");
            foreach (Room item in listRoom.Values)
            {
                if (item.FloorRoom == 3)
                {
                    Console.Write($"{item.NumberRoom} ");
                }
            }
            Console.Write("\nFloor 4: ");
            foreach (Room item in listRoom.Values)
            {
                if (item.FloorRoom == 4)
                {
                    Console.Write($"{item.NumberRoom} ");
                }
            }

            Console.WriteLine("\n\nChoose the menu number to access its menu (1/2/3): ");
            Console.WriteLine("\t1. Room information");
            Console.WriteLine("\t2. Updates of Room information");
            Console.WriteLine("\t3. Back to the main menu");
            Console.WriteLine("\t4. Exit the application");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Initial Room Information:");
                    RoomInformation(input);
                    break;

            // -------------- Update Information ---------------//

                case "2":
                    Console.WriteLine("\nUpdating Room Information for Room 301...");
                    Room room301 = listRoom["301"];
                    room301.UpdateRoomInformation("301A", 3, "Regular single bed", 900000m);

                    Console.WriteLine("\nUpdated Room Information:");
                    foreach (var room in listRoom.Values)
                    {
                        room.PrintRoomInformation();
                    }
                    //Console.ReadLine();
                    BackInformation(input);
                    break;

                case "3":
                    Console.Clear();
                    MainMenu(input);
                    break;

                case "4":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Thank you for using this application.");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not available!");
                    DataRoom(input, listRoom);
                    break;
            }
        }

        private static void BackInformation(string input)
        {
            
            Console.WriteLine("\n\r\nPlease select a menu number to access its menu (1/2/3) : ");
            Console.WriteLine("\t1. Go back to room data");
            Console.WriteLine("\t2. Go back to the main menu");
            Console.WriteLine("\t3. Exit the application");
            input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    DataRoom(input, listRoom);
                    break;
                case "2":
                    Console.Clear();
                    MainMenu(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Thank you for using this application.");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not available!\n");
                    BackInformation(input);
                    break;
            }
        }

        private static void RoomInformation(string input)
        {
            Console.Write("Enter the room number for which you want to view the information : ");
            input = Console.ReadLine().Trim();

            if (!(listRoom.Keys.Contains(input)))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, the room number you entered is not valid. Please try again.\n");
                RoomInformation(input);
            }
            Console.Clear();
            foreach (Room item in listRoom.Values)
            {
                if (input.Equals(item.NumberRoom))
                {
                    item.PrintRoomInformation();
                }
            }
            foreach (Guest item in listGuest.Values)
            {
                if (input.Equals(item.Room.NumberRoom))
                {
                    item.ReservationHistory();
                }
            }

            Console.WriteLine("\n\r\nPlease select a menu number to access its menu (1/2/3) : ");
            Console.WriteLine("\t1. Go back to room data");
            Console.WriteLine("\t2. Go back to the main menu");
            Console.WriteLine("\t3. Exit the application");
            input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    DataRoom(input, listRoom);
                    break;
                case "2":
                    Console.Clear();
                    MainMenu(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Are you sure you want to exit this application? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MainMenu(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Thank you for using this application.");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not available!\n");
                    RoomInformation(input);
                    break;
            }
        }

        private static void AboutTheHotel(string input)
        {
            Console.WriteLine("This hotel is called Design Pattern Hotel. \nIt has been established since May 12, 2023 in NED University, \nKarachi, Pakistan.\n");
            Console.Write("Do you want to go back to the main menu? (y/n) ");
            input = Console.ReadLine();
            while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
            {
                Console.Write("Please input \"yes\" or \"no\" only. (y/n) ");
                input = Console.ReadLine().Trim();
            }
            if (input.ToLower().Equals("y"))
            {
                Console.Clear();
                MainMenu(input);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Thank you for using this application.");
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
