using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class UserInfoContext : DbContext
    {
        public UserInfoContext (DbContextOptions<UserInfoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.UserInfo>? UserInfo { get; set; }
    }
}
