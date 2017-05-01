using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Feed : System.Web.UI.Page
{
    public string feed = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string XMLfile = Server.MapPath("FeedFile.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load(XMLfile);

        XmlNodeList title = doc.GetElementsByTagName("title");
        XmlNodeList content = doc.GetElementsByTagName("content");
        feed = "<h1>Feed</h1>";
        int num = content.Count;     
        for (int i = 0; i < num; i++)
        {

            feed += "<p>";
            feed += "<div>";
            feed += "<u>" + title[i].InnerText + "</u>" + "</br>";
            feed +=  content[i].InnerText + "</br>";
            feed += "</div>";
            feed += "</p>";
            
            

        }
        
    }
}