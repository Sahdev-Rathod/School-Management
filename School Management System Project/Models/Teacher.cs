using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Management_System_Project.Models
{
    public class Teacher
    {
        /// <summary>
        /// Primary identifier for the teacher.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Teacher's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Teacher's middle name (optional).
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Teacher's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Read-only convenience property combining first and last name.
        /// </summary>
        public string FullName
        {
            get
            {
                var first = string.IsNullOrWhiteSpace(FirstName) ? string.Empty : FirstName.Trim();
                var last = string.IsNullOrWhiteSpace(LastName) ? string.Empty : LastName.Trim();
                if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(last))
                {
                    return string.Empty;
                }
                if (string.IsNullOrEmpty(first))
                {
                    return last;
                }
                if (string.IsNullOrEmpty(last))
                {
                    return first;
                }
                return first + " " + last;
            }
        }

        /// <summary>
        /// Contact email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Postal or street address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Date of birth; nullable if unknown.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Date the teacher was hired.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Whether the teacher is currently active.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Subjects the teacher can teach. Initialized to an empty list.
        /// </summary>
        public List<string> Subjects { get; set; } = new List<string>();
    }
}