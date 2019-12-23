using System;
using System.Collections.Generic;
using System.Text;
using KudyFinancials.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KudyFinancials.Data
{
    public class ApplicationDbContext : IdentityDbContext<InvestorInformationI>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
