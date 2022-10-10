using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WEB452_Ass1_PENS.Models {
    public class PenTipViewModel {
        public List<Pen> Pens { get; set; }
        public SelectList Tips { get; set; }
        public string PenTipSize { get; set; }
        public string SearchString { get; set; }
    }
}
