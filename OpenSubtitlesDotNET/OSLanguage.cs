using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSubtitlesDotNET
{
    public class OSLanguage
    {
        public String IdSubLanguage { set; get; }
        public String ISO639 { set; get; }
        public String LanguageName { set; get; }
        public bool UploadEnabled { set; get; }
        public bool WebEnabled { set; get; }
        public OSLanguage(String IdSubLanguage, String ISO639, String LanguageName, bool UploadEnabled, bool WebEnabled)
        {
            this.IdSubLanguage = IdSubLanguage;
            this.ISO639 = ISO639;
            this.LanguageName = LanguageName;
            this.UploadEnabled = UploadEnabled;
            this.WebEnabled = WebEnabled;
        }
    }
}
