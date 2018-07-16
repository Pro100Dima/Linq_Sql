using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ADO_LINQ_SQL
{
    [Table]//esli imya tablicy i imya classa sovpadaut to mozhno ostavit Table
    public class Area
    {
        [Column(IsPrimaryKey = true)]
        public int AreaId { get; set; }
        
        [Column]
        public string Name { get; set; }

        [Column]
        public int WorkingPeople { get; set; }

        public virtual ICollection<Timer> Timer { get; set; }

        [Column]
        public bool? AssemblyArea { get; set; }
    }
}
