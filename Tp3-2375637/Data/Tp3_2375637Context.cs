using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tp3_2375637.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tp3_2375637.Data
{
  public class Tp3_2375637Context : IdentityDbContext<User>
  {
    public Tp3_2375637Context(DbContextOptions<Tp3_2375637Context> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      PasswordHasher<User> hasher = new PasswordHasher<User>();

      User u1 = new User(){Id = "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",UserName = "Nizar",Email = "Nizarsniper@gmail.com",NormalizedEmail = "NIZARSNIPER@GMAIL.COM",NormalizedUserName = "NIZAR"};
      u1.PasswordHash = hasher.HashPassword(u1, "NizarSniper");
      builder.Entity<User>().HasData(u1);

      User u2 = new User(){ Id = "40745596-da83-4e03-811f-4dc310ca83ee",UserName = "Bassem",Email = "Bassemsniper@gmail.com",NormalizedEmail = "BASSEMSNIPER@GMAIL.COM",NormalizedUserName = "BASSEM"};
      u2.PasswordHash = hasher.HashPassword(u2, "BassemSniper");
      builder.Entity<User>().HasData(u2);

      builder.Entity<Score>().HasData(new Score{id=1,Pseudo= "Nizar",ScoreValue="3",TimeInSeconds="62",Date="Mar 26, 2024",IsPublic=true,UserId= "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e" },
      new Score{id = 2,Pseudo = "Nizar",ScoreValue = "3",TimeInSeconds = "12",Date = "Mar 26, 2024",IsPublic = false, UserId = "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e" },
      new Score{ id = 3,Pseudo = "Bassem",ScoreValue = "3",TimeInSeconds = "12",Date = "Mar 26, 2024",IsPublic = true , UserId = "40745596-da83-4e03-811f-4dc310ca83ee" },
      new Score{id = 4,Pseudo = "Bassem",ScoreValue = "3",TimeInSeconds = "31",Date = "Mar 26, 2024",IsPublic = false, UserId = "40745596-da83-4e03-811f-4dc310ca83ee" });
    }
    public DbSet<Tp3_2375637.Models.Score> Score { get; set; } = default!;
  }
}
