using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using GMaps.Classes.Helpers;
using Subgurim.Controles; 

public partial class Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GMapUIOptions options = new GMapUIOptions();
        options.zoom_scrollwheel = true;
        
        //options
        GMap1.addGMapUI(new GMapUI(options));
        //setcenter
        GMap1.setCenter(new GLatLng(-7.197617, 112.73288),15,  GMapType.GTypes.Satellite);
    }
}
