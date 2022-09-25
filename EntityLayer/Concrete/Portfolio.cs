﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }


        public string Name { get; set; }

        public string ImageURL { get; set; }

        public string ProjectURL { get; set; }

        public string ImageURL2 { get; set; }
    }
}
