using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// code before Applying Builder Pattern//

/*namespace Dp_Hotel_Project
{
    public class Biodata
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Gender { get; set; }
        public long IDNumber { get; set; }
        public string NumberRegister { get; set; }

        public Biodata() { }

        public Biodata(string firstName, string lastName, DateTime dateOfBirth, string placeOfBirth, string gender, long idNumber, string numberRegister)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
            this.Gender = gender;
            this.IDNumber = idNumber;
            this.NumberRegister = numberRegister;
        }

        public int Age()
        {
            return DateTime.Now.Year - this.DateOfBirth.Year;
        }

        public string FullName()
        {
            return string.Format("{0} {1}",this.FirstName, this.LastName);
        }


    }
}*/

// -------------------- BUILDER PATTERN ------------------------- //

/*  The Builder pattern is a creational pattern that separates the construction of an object from its representation,
       allowing the same construction process to create different representations.*/

/*  To apply the Builder pattern to our code, we create a "BiodataBuilder" class that provides methods for setting
      individual properties of the "Biodata" class. Below is the implementation */


namespace Dp_Hotel_Project
{
    // Biodata class represents the personal information of a person
    public class Biodata
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Gender { get; set; }
        public long IDNumber { get; set; }
        public string NumberRegister { get; set; }

        public Biodata()
        {
            // Set default values for properties
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            PlaceOfBirth = string.Empty;
            Gender = string.Empty;
            IDNumber = 0;
            NumberRegister = string.Empty;
        }

        // Constructor to initialize Biodata object with provided values
        public Biodata(BiodataBuilder builder)
        {
            this.FirstName = builder.FirstName;
            this.LastName = builder.LastName;
            this.DateOfBirth = builder.DateOfBirth;
            this.PlaceOfBirth = builder.PlaceOfBirth;
            this.Gender = builder.Gender;
            this.IDNumber = builder.IDNumber;
            this.NumberRegister = builder.NumberRegister;
        }

        // Calculate the age based on the DateOfBirth
        public int Age()
        {
            return DateTime.Now.Year - this.DateOfBirth.Year;
        }

        // Get the full name by combining the first name and last name
        public string FullName()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }

    // Builder class to construct Biodata objects step by step
    public class BiodataBuilder
    {
        // Biodata properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PlaceOfBirth { get; private set; }
        public string Gender { get; private set; }
        public long IDNumber { get; private set; }
        public string NumberRegister { get; private set; }

        // Method to set the first name
        public BiodataBuilder SetFirstName(string firstName)
        {
            this.FirstName = firstName;
            return this;
        }

        // Method to set the last name
        public BiodataBuilder SetLastName(string lastName)
        {
            this.LastName = lastName;
            return this;
        }

        // Method to set the date of birth
        public BiodataBuilder SetDateOfBirth(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            return this;
        }

        // Method to set the place of birth
        public BiodataBuilder SetPlaceOfBirth(string placeOfBirth)
        {
            this.PlaceOfBirth = placeOfBirth;
            return this;
        }

        // Method to set the gender
        public BiodataBuilder SetGender(string gender)
        {
            this.Gender = gender;
            return this;
        }

        // Method to set the ID number
        public BiodataBuilder SetIDNumber(long idNumber)
        {
            this.IDNumber = idNumber;
            return this;
        }

        // Method to set the registration number
        public BiodataBuilder SetNumberRegister(string numberRegister)
        {
            this.NumberRegister = numberRegister;
            return this;
        }

        // Build the final Biodata object with the provided values
        public Biodata Build()
        {
            return new Biodata(this);
        }
    }

}

