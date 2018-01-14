using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Serialization;
using ExamManagement.Models;

namespace ExamManagement.Helper
{
    public class ExamHelper
    {
        public static ExamXMLModel AllQuestionsGetter()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.wired.com/feed/rss");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());

            XmlSerializer serial = new XmlSerializer(typeof(ExamXMLModel));
            ExamXMLModel allModel = (ExamXMLModel)serial.Deserialize(sr);
            sr.Close();
            return allModel;
        }

        public static List<Item> Last5QuestionsGetter()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.wired.com/feed/rss");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());

            XmlSerializer serial = new XmlSerializer(typeof(ExamXMLModel));
            ExamXMLModel allModel = (ExamXMLModel)serial.Deserialize(sr);
            sr.Close();
            return allModel.Channel.Item.Take(5).Reverse().ToList();
        }
    }
}