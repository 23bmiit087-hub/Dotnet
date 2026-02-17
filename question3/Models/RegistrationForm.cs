using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace question3.Models
{
    public class RegistrationForm
    {
        public Category Category{get; set;}
        public int NoofParticipants{get; set;}

    }
    public enum Category
    {
        Student,
        Faculty,
        Other
    }
}