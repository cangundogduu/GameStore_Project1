using GameStore_Project1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore_Project1.Abstract
{
    interface IPlayerService
    {
        void Add(IEntities entities);
        void Update(IEntities entities);
        void Delete(IEntities entities);
    }
}
