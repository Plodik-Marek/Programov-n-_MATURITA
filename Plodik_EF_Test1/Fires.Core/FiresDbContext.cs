using Fires.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fires.Core
{
    public class FiresDbContext : DbContext
    {
        public DbSet<CountryFire> CountryFire {  get; set; }
        public BindingList<CountryFire> CountryFireData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=3c2_plodikmarek_db1;uid=plodikmarek;password=123456");
        }

         
    }
}
