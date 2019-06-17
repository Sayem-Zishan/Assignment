using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Agent.Models;

namespace Agent.Gateway
{
      public class DBContext : DbContext
        {

            public DBContext() : base("name=AgentDb")
            {
            }
            public DbSet<User> Users { get; set; }
            
        }
    
}