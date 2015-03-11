using EF7forApi.Models;
using System.Collections.Generic;

namespace EF7forApi.Repository
{
    public interface IRepository
    {
        List<Order> getAll();
    }
}