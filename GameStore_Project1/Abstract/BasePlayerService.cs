using System;
using System.Collections.Generic;
using System.Text;
using GameStore_Project1.Entities;

namespace GameStore_Project1.Abstract
{
    abstract class BasePlayerService : IPlayerService
    {
        public void Add(IEntities entities)
        {
            Console.WriteLine("Aded to db : " + entities.FirstName);
        }

        public void Delete(IEntities entities)
        {
            Console.WriteLine("Deleted to db : " + entities.FirstName);
        }

        public void Update(IEntities entities)
        {
            Console.WriteLine("Updated to db : " + entities.FirstName);
        }
    }
}
