using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Management_System_Project.Models
{
    /*
    Pseudocode / Plan:
    - Add five properties to the Student class to represent basic student data.
    - Properties to add:
      1. Id (int)                   : unique identifier for the student
      2. FirstName (string)         : student's given name
      3. LastName (string)          : student's family name
      4. DateOfBirth (DateTime)     : student's birth date
      5. Email (string)             : contact email for the student
    - Each property should be public with standard get and set accessors.
    - Keep implementation simple and POCO-style for compatibility with EF/serialization.
    */

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }
    }
}