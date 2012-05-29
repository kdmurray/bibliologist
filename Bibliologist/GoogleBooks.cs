using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliologist
{
    public class GoogleBooks
    {
        public Volume GetBook(string isbn)
        {
            Volume vol = null;

            return vol;
        }


        //GoogleBooks Code
        //WebClient wc = new WebClient();

        //Console.Write("ISBN: ");
        //string isbn = Console.ReadLine();

        //JObject o = (JObject)JObject.Parse(wc.DownloadString("https://www.googleapis.com/books/v1/volumes?q=" + isbn));

        //JArray ar = (JArray)o["items"];

        //int itemCount = ar.Count;

        //string title = "";

        //for (int i = 0; i < itemCount; i++)
        //{
        //    title = (string)o.SelectToken("items[" + i.ToString() + "].volumeInfo.title");

        //    title = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(title);

        //    Console.WriteLine("Title: {0}", title);
        //}

        //Console.ReadLine();


    }
}
