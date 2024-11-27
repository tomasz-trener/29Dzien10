using P04Zawodnicy.Shared.Domains;
using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy.services
{
    public partial class ZapiszZawodnika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idZawodnika = Request["id"];
            if (!string.IsNullOrEmpty(idZawodnika))
            {
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(idZawodnika);
                z.Imie = Request["imie"];
                z.Nazwisko = Request["nazwisko"];
                z.Kraj = Request["kraj"];
                z.DataUrodzenia = Convert.ToDateTime(Request["dataUr"]);
                z.Wzrost = Convert.ToInt32(Request["wzrost"]);
                z.Waga = Convert.ToInt32(Request["waga"]);
                z.Id_trenera = Convert.ToInt32(Request["idTrenera"]);

                IManagerZawodnikow mz = new ManagerZawodnikowLINQ();
                mz.Edytuj(z);
            }
        }
    }
}