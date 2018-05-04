using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirstRelation.OneToMany
{
    public class C4Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public C4Grade Grade { get; set; }
    }
}
