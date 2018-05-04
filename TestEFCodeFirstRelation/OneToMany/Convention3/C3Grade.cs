using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany
{
    public class C3Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<C3Student> Students { get; set; }
    }
}
