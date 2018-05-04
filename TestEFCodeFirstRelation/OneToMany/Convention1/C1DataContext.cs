using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany

{
    public class C1DataContext : DbContext
    {
        public IDbSet<C1Student> Students { get; set; }
        public IDbSet<C1Grade> Grades { get; set; }
    }
}
