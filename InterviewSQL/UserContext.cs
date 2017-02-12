using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSQL.Entity;

namespace InterviewSQL
{
    public class UserContext: DbContext
    {
        public UserContext()
          : base("DbConnection")
        { }
        public virtual DbSet<User> Users { get; set; }
    }
}
