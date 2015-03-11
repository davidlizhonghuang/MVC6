using System;

namespace EF7forApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime OrderDate { get; set; }
    }
}