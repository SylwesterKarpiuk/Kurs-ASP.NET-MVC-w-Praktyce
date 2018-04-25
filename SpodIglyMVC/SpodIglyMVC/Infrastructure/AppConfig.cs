using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.Infrastructure
{
    public class AppConfig
    {
        public static string _genreIconsFolderRelative = ConfigurationManager.AppSettings["GenreIconsFolder"];
        public static string GenreIconsFolderRelative { get { return _genreIconsFolderRelative; } }
        

        public static string _photosFolderRelative = ConfigurationManager.AppSettings["PhotosFolder"];
        public static string PhotosFolderRelative { get { return _photosFolderRelative; } }
    }
}