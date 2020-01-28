using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using System.IO;
using System.Xml;
using System.Globalization;

namespace OpenSubtitlesDotNET
{
    public class OSLanguageHelper
    {
        private static Dictionary<String,OSLanguage> AvailableUploadEnabledLanguagesList;
        private static Dictionary<String,OSLanguage> AvailableWebEnabledLanguagesList;
        private static Dictionary<String, OSLanguage> AllLanguagesList;
        static OSLanguageHelper()
        {
            AvailableUploadEnabledLanguagesList = new Dictionary<String,OSLanguage>();
            AvailableWebEnabledLanguagesList = new Dictionary<String, OSLanguage>();
            AllLanguagesList = new Dictionary<String, OSLanguage>();
            XPathNavigator xmlMetadataNavigator = new XPathDocument(new XmlTextReader(new StringReader(OpenSubtitlesDotNET.Resource.OSLanguageTableDump))).CreateNavigator();
            XPathNodeIterator languagesIter = xmlMetadataNavigator.Select("OSLanguageTableDump/language");
            if (languagesIter.Count > 0)
            {
                while (languagesIter.MoveNext())
                {
                    OSLanguage language = language = new OSLanguage(languagesIter.Current.SelectSingleNode("IdSubLanguage").Value,
                                languagesIter.Current.SelectSingleNode("ISO639").Value,
                                languagesIter.Current.SelectSingleNode("LanguageName").Value,
                                languagesIter.Current.SelectSingleNode("UploadEnabled").Value.Equals("0") ? false : true,
                                languagesIter.Current.SelectSingleNode("WebEnabled").Value.Equals("0") ? false : true);
                    if (!languagesIter.Current.SelectSingleNode("UploadEnabled").Value.Equals("0"))
                    {
                        AvailableUploadEnabledLanguagesList.Add(language.IdSubLanguage,language);
                    }
                    if (!languagesIter.Current.SelectSingleNode("WebEnabled").Value.Equals("0"))
                    {
                        AvailableWebEnabledLanguagesList.Add(language.IdSubLanguage,language);
                    }
                    AllLanguagesList.Add(language.IdSubLanguage, language);
                }
            }

        }
        public static List<OSLanguage> GetAvailableUploadEnabledLanguages()
        {
            return new List<OSLanguage>(AvailableUploadEnabledLanguagesList.Values);
        }
        public static List<OSLanguage> GetAvailableWebEnabledLanguages()
        {
            return new List<OSLanguage>(AvailableWebEnabledLanguagesList.Values);
        }
        public static OSLanguage GetOSLanguageById(string IdSubLanguage)
        {
            return AllLanguagesList[IdSubLanguage];
        }
        public static OSLanguage GetOSLanguage(CultureInfo culture)
        {
            List < OSLanguage > list =  new List<OSLanguage>(AllLanguagesList.Values);
            return list.Find(delegate(OSLanguage osl)
            {
                return culture.TwoLetterISOLanguageName.Equals(osl.ISO639);
            });
        }
    }
}
