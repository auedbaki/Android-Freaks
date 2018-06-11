using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Android_Freaks
{
    public static class Services
    {
        //Domain of the host
        public static string domain = "https://hackers-choice-206505.appspot.com/";

        //Function to get the URI to request the articles
        public static string GetarticlesURI(string category="recent", int skip = 0)
        {
            return "api/androidfreak/category/skip/" + category + "/" + skip;
        }

        //Function to get the URI to request the categories
        public static string  GetCategoriesURI()
        {
            return "api/androidfreak/categories";
        }

        //Function to get the URI to request the content of Article
        public static string GetArticleURI(string _id)
        {
            return "api/androidfreak/id/" + _id;
        }
        //Function to get the URI to request the comments on the Article with expanding
        public static string GetCommentsURI(string articleid, int skip = 0)
        {
            return "api/androidfreak/comments/id/" + articleid + "/" + skip;
        }
        //Function to get the URI to post the new Comment
        public static string PostCommentsURI(string articleid)
        {
            return "api/androidfreak/comments/id/" + articleid;
        }
    }
}