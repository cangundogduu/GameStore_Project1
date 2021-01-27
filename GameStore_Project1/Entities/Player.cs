using GameStore_Project1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore_Project1.Entities
{
    class Player : IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationaltyNumber { get; set; }
    }

}
