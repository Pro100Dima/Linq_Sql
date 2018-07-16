using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ADO_LINQ_SQL
{
    [Table(Name = "AccessTab")]//(Name = "AccessTab")
    public class AccTab//imya mozhno izmenit
    {
        [Column(IsPrimaryKey = true)]
        public int intTabID { get; set; }//imena stolbcov

        [Column]
        public int strTabID { get; set; }

        private string strTabURL_ { get; set; } // istochnik
        [Column(Storage = "strTabURL_")]// obrawenie k istochniku

        public string strTabUrl//proverka 
        {
            get { return strTabURL_; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    strTabURL_ = "no URL";
                else
                {
                    strTabURL_ = value;
                }
            }
        }
    }
}
