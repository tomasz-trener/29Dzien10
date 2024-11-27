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
    public partial class UsunZawodnika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            string idUsuwanegoStr = Request["idUsuwanego"];
            if (!string.IsNullOrEmpty(idUsuwanegoStr))
            {
                int idUsuwanego = Convert.ToInt32(idUsuwanegoStr);
                IManagerZawodnikow mz = new ManagerZawodnikowLINQ();
                mz.Usun(idUsuwanego);
            }
        }
    }
}