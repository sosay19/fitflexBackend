using System;
using System.Collections.Generic;
using fitflexBackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace fitflexBackend.Data;

// Data/FitFlexDbContext.cs
public class FitFlexDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public FitFlexDbContext(DbContextOptions<FitFlexDbContext> options) : base(options) { }

    public DbSet<Member> Members { get; set; }
    // Add more DbSets for other models
}
