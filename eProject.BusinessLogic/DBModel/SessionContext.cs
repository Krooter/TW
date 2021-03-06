﻿using System.Data.Entity;
using eProject.Domain.Entities.User;

namespace eProject.BusinessLogic.DBModel.Seed
{
    internal class SessionContext : DbContext
    {
        public SessionContext() : base("name=eProjectDB")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}