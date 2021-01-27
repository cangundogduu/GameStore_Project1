using GameStore_Project1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore_Project1.Entities
{
    class Game : IEntities
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
