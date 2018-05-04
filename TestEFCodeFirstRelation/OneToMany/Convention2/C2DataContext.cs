using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany
{
    public class C2DataContext : DbContext
    {
        public IDbSet<C2Student> Students { get; set; }
        public IDbSet<C2Grade> Grades { get; set; }
    }
}
