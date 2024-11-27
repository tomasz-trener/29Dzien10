using P04Zawodnicy.Shared.Domains;
using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy.services
{
    public partial class Wyszukiwarka : System.Web.UI.Page
    {
        public List<Zawodnik> Zawodnicy { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            IManagerZawodnikow mz = new ManagerZawodnikowLINQ();

            string szukanaFraza = Request["fraza"];
            if(!string.IsNullOrEmpty(szukanaFraza))
                Zawodnicy = mz.PodajZawodnikow
        }
    }
}