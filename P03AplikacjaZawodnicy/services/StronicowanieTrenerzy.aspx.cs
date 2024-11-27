using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy.services
{
    public partial class StronicowanieTrenerzy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stronaStr = Request["strona"];
            string ileRekordowStr = Request["ileRekordow"];

            if (!string.IsNullOrEmpty(stronaStr) && !string.IsNullOrEmpty(ileRekordowStr))
            {
                IManagerZawodnikow mz = new ManagerZawodnikowLINQ();
                var dane = mz.PodajTrenerowStronicowanie(new Model.RequestData()
                {
                    Strona = Convert.ToInt32(stronaStr),
                    LiczbaRekordow = Convert.ToInt32(ileRekordowStr)
                });

                string json = new JavaScriptSerializer().Serialize(dane);
                Response.ContentType = "application/json";
                Response.Write(json);



            }



        }
    }
}