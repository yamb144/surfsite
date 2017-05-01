using System;
using System.Data.SqlClient;
using System.Xml;

public partial class Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod == "POST")

        {
            string Beach = Request.Form["Beach"];
            if (Beach == "palmahim")
            {
                string Title = Request.Form["title"];
                string Content = Request.Form["content"];
                string XMLfile = Server.MapPath("FeedFile.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XMLfile);
                XmlNode beach = xmlDoc.CreateElement("beach");
                XmlNode title = xmlDoc.CreateElement("title");
                title.InnerText = Title;
                XmlNode content = xmlDoc.CreateElement("content");
                content.InnerText = Content;
                beach.AppendChild(title);
                beach.AppendChild(content);
                xmlDoc.DocumentElement.AppendChild(beach);
                xmlDoc.Save(XMLfile);
            }
            if (Beach == "zvolon")
            {
                string Title = Request.Form["title"];
                string Content = Request.Form["content"];
                string XMLfile = Server.MapPath("XmlZvolon.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XMLfile);
                XmlNode beach = xmlDoc.CreateElement("beach");
                XmlNode title = xmlDoc.CreateElement("title");
                title.InnerText = Title;
                XmlNode content = xmlDoc.CreateElement("content");
                content.InnerText = Content;
                beach.AppendChild(title);
                beach.AppendChild(content);
                xmlDoc.DocumentElement.AppendChild(beach);
                xmlDoc.Save(XMLfile);
            }
            if (Beach == "hadromi")
            {
                string Title = Request.Form["title"];
                string Content = Request.Form["content"];
                string XMLfile = Server.MapPath("XmlZvolon.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XMLfile);
                XmlNode beach = xmlDoc.CreateElement("beach");
                XmlNode title = xmlDoc.CreateElement("title");
                title.InnerText = Title;
                XmlNode content = xmlDoc.CreateElement("content");
                content.InnerText = Content;
                beach.AppendChild(title);
                beach.AppendChild(content);
                xmlDoc.DocumentElement.AppendChild(beach);
                xmlDoc.Save(XMLfile);
            }





        }
    }
}