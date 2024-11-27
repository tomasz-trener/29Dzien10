using P04Zawodnicy.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P03AplikacjaZawodnicy.Model
{
    public class ResponseData
    {
        public Trener[] Trenerzy { get; set; }
        public int IleStron { get; set; }   
    }
}