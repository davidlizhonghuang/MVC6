using Microsoft.Data.Entity;
using System;
using EF7forApi.Models;

namespace EF7forApi
{
    public class OrderContext :DbContext
    {
        public DbSet<Order> Orders { get; set; }//create the table in DB
        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EF7Sstack;Trusted_Connection=True;");
         }
    }
}




//namespace EF7dataaccess
//{
//    public class OrderContext : DbContext
//    {
//        public DbSet<Order> Orders { get; set; } //connect to sql server
//        protected override void OnConfiguring(DbContextOptions builder)
//        {
//            builder.UseSqlServer(@"Server=(localdb)\v11.0;Database=TodoItems;Trusted_Connection=True;");
//        }

//        //k ef migration add "initial"
//        //ordercontext is added
//        //k ef migration apply
//        //create migration table apply migration 323eewe232-232e
//        //in cmd
//        //database is created in db
//    }
//}

