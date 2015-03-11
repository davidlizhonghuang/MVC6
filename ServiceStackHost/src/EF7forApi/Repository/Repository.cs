using EF7forApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace EF7forApi.Repository
{
    public class Repository :IRepository
    {
        OrderContext db = new OrderContext();
        public List<Order> getAll()
        {
            return db.Orders.ToList();
        }

    }
}