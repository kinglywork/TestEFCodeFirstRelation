using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany
{
    public class C3DataContext : DbContext
    {
        public IDbSet<C3Student> Students { get; set; }
        public IDbSet<C3Grade> Grades { get; set; }
    }
}
