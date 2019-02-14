using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeliveryService.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DeliveryService.Core
{
    public class DeliveryServiceContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<StateZone> StateZones { get; set; }
    }
}