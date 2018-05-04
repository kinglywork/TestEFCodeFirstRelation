using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany
{
    public class C4DataContext : DbContext
    {
        public IDbSet<C4Student> Students { get; set; }
        public IDbSet<C4Grade> Grades { get; set; }
    }
}
