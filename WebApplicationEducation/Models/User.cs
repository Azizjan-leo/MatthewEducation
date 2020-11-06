using System;

namespace WebApplicationEducation.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Balance { get; set; }

        public DateTime Created { get; set; }
    }
}
