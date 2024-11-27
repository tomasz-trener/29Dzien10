using P04Zawodnicy.Shared.Domains;
using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy
{
    public partial class TabelaZawodnikowBezMaster : System.Web.UI.Page
    {
        public List<Zawodnik> Zawodnicy { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            IManagerZawodnikow mz = new ManagerZawodnikowLINQ();
            Zawodnicy = mz.WczytajZawodnikow();
        }
    }
}