using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB452_Ass1_PENS.Models {
    public class Pen {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Type { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public bool Erasable { get; set; }

    //    public int Rating { get; set; }

    }
}
