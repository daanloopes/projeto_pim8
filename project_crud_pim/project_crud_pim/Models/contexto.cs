using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using crud_pim.Models;

namespace project_crud_pim.Models
{
    public class contexto: DbContext
    {
        public DbSet<pessoa> Pessoas { get; set; }
    }
}