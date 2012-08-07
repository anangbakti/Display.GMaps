using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using GMaps.Classes.Helpers;
using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;

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

        //add red marker
        GLatLng redPosition = new GLatLng(-7.197681, 112.72429);
        XPinLetter xPinLetter = new XPinLetter(PinShapes.pin_star, "A", Color.White, Color.Black, Color.Red);
        GMarker redMarker = new GMarker(redPosition, new GMarkerOptions(new GIcon(xPinLetter.ToString(), xPinLetter.Shadow())));

        //add info window
        GInfoWindowOptions IWoptions = new GInfoWindowOptions(12, GMapType.GTypes.Normal);
        GInfoWindow mbUp = new GInfoWindow(redMarker, "<i>I'm in</i> <a style='color:red'>RED</a> <b>Condition</b>", IWoptions);

        GMap1.addGMarker(redMarker);
        GMap1.addInfoWindow(mbUp);


        //add green marker
        GLatLng greenPosition = new GLatLng(-7.19651, 112.731035);
        xPinLetter = new XPinLetter(PinShapes.pin_star, "B", Color.White, Color.Black, Color.Green);
        GMarker greenMarker = new GMarker(greenPosition, new GMarkerOptions(new GIcon(xPinLetter.ToString(), xPinLetter.Shadow())));

        //add info window
        IWoptions = new GInfoWindowOptions(12, GMapType.GTypes.Normal);
        mbUp = new GInfoWindow(greenMarker, "<i>I'm in</i> <a style='color:green'>GREEN</a> <b>Condition</b>", IWoptions);
        
        GMap1.addGMarker(greenMarker);
        GMap1.addInfoWindow(mbUp);
    }
}
