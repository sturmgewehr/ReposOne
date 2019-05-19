namespace DataAccessLayer
{
    using DataAccessLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=ConnectionString")
        { }

        public virtual DbSet<User> Users { get; set; }
    }
}