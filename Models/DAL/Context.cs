using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Centric4200Team12.Models;
using System.Data.Entity;


namespace Centric4200Team12.Models.DAL
{
    public class context: DbContext 
    {
        public context() : base ("name=defaultConnection")
        {

        }
        public DbSet<employee> Employees { get; set; }


    }
}