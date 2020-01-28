using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.IO;
using System.IO.Compression;
using System.Globalization;

namespace OpenSubtitlesDotNET
{
    public class OSDotNetSession
    {
        private String Token { get; set; }
        private IOpenSubtitles proxy;
        public String LastResponseCode { get; internal set; }
        public double LastResponseTime { get; internal set; }

        private OSDotNetSession()
        {
            proxy = XmlRpcProxyGen.Create<IOpenSubtitles>();
            proxy.KeepAlive = false;
            //proxy.RequestEvent += new XmlRpcRequestEventHandler(proxy_RequestEvent);
        }

        public static OSDotNetSession LogIn(string username, string password, string language, string useragent)
        {
            OSDotNetSession oss = new OSDotNetSession();
            XmlRpcStruct ResponseStruct = oss.proxy.LogIn(username, password, language, useragent);
            oss.LastResponseCode = (string)ResponseStruct["status"];
            oss.LastResponseTime = Convert.ToDouble(ResponseStruct["seconds"]);
            if ((!String.IsNullOrEmpty(oss.LastResponseCode)) && oss.LastResponseCode.Equals("200 OK"))
            {
                oss.Token = (string)ResponseStruct["token"];
                return oss;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ImdbId"></param>
        /// <param name="query"></param>
        /// <param name="languages"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByImdbIdThenQuery(string ImdbId, string query, OSLanguage languages)
        {
            XmlRpcStruct SearchParamsStruct = new XmlRpcStruct();
            if (languages != null)
            {
                SearchParamsStruct.Add("sublanguageid", languages.IdSubLanguage);
            }
            else
            {
                SearchParamsStruct.Add("sublanguageid", "all");
            }
            if (!String.IsNullOrEmpty(ImdbId))
            {
                SearchParamsStruct.Add("imdbid", ImdbId);
            }
            if (!String.IsNullOrEmpty(query))
            {
                SearchParamsStruct.Add("query", query);
            }
            XmlRpcStruct ResponseStruct = proxy.SearchSubtitles(Token, new object[1] { new XmlRpcStruct[1] { SearchParamsStruct } });
            List<SearchSubtitleResult> SearchResultList = DoSearchRequest(ResponseStruct);
            return SearchResultList;
        }

        private static List<SearchSubtitleResult> DoSearchRequest(XmlRpcStruct ResponseStruct)
        {
            List<SearchSubtitleResult> SearchResultList = new List<SearchSubtitleResult>();
            if (ResponseStruct["data"] != null && (!ResponseStruct["data"].Equals(false)))
            {
                foreach (XmlRpcStruct SearchResult in ((object[])ResponseStruct["data"]))
                {
                    SearchSubtitleResult result = new SearchSubtitleResult();
                    result.SubSumCD = (string)SearchResult["SubSumCD"];
                    result.MovieYear = (String)SearchResult["MovieYear"];
                    result.SubFileName = (String)SearchResult["SubFileName"];
                    result.MovieImdbRating = (String)SearchResult["MovieImdbRating"];
                    result.UserNickName = (String)SearchResult["UserNickName"];
                    result.UserRank = (String)SearchResult["UserRank"];
                    result.SubHash = (String)SearchResult["SubHash"];
                    result.MovieName = (String)SearchResult["MovieName"];
                    result.SubActualCD = (String)SearchResult["SubActualCD"];
                    result.MovieNameEng = (String)SearchResult["MovieNameEng"];
                    result.SubHearingImpaired = (String)SearchResult["SubHearingImpaired"];
                    result.MatchedBy = (String)SearchResult["MatchedBy"];
                    result.MovieHash = (String)SearchResult["MovieHash"];
                    result.LanguageName = (String)SearchResult["LanguageName"];
                    result.IDSubtitleFile = (String)SearchResult["IDSubtitleFile"];
                    result.SubLanguageID = (String)SearchResult["SubLanguageID"];
                    result.SubAuthorComment = (String)SearchResult["SubAuthorComment"];
                    result.IDSubtitle = (String)SearchResult["IDSubtitle"];
                    result.UserID = (String)SearchResult["UserID"];
                    result.MovieByteSize = (String)SearchResult["MovieByteSize"];
                    result.SubSize = (String)SearchResult["SubSize"];
                    result.SubDownloadLink = (String)SearchResult["SubDownloadLink"];
                    result.SubtitlesLink = (String)SearchResult["SubtitlesLink"];
                    result.ISO639 = (String)SearchResult["ISO639"];
                    result.MovieReleaseName = (String)SearchResult["MovieReleaseName"];
                    result.SubBad = (String)SearchResult["SubBad"];
                    result.IDSubMovieFile = (String)SearchResult["IDSubMovieFile"];
                    result.SubComments = (String)SearchResult["SubComments"];
                    result.MovieTimeMS = (String)SearchResult["MovieTimeMS"];
                    result.SubFormat = (String)SearchResult["SubFormat"];
                    result.IDMovieImdb = (String)SearchResult["IDMovieImdb"];
                    result.SubRating = (String)SearchResult["SubRating"];
                    result.MovieFPS = (string)SearchResult["MovieFPS"];
                    try
                    {
                        result.SubDownloadsCnt = Convert.ToInt32((String)SearchResult["SubDownloadsCnt"]);
                    }
                    catch (Exception)
                    {
                        result.SubDownloadsCnt = 0;
                    }
                    result.IDMovie = (String)SearchResult["IDMovie"];
                    result.SubAddDate = (String)SearchResult["SubAddDate"];
                    result.ZipDownloadLink = (String)SearchResult["ZipDownloadLink"];
                    SearchResultList.Add(result);
                }
            }
            return SearchResultList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ImdbId"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByImdbIdThenQuery(string ImdbId, string query)
        {
            return SearchByImdbIdThenQuery(ImdbId, query, null); ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ImdbId"></param>
        /// <param name="languages"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByImdbId(string ImdbId, OSLanguage languages)
        {
            return SearchByImdbIdThenQuery(ImdbId, null, languages);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ImdbId"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByImdbId(string ImdbId)
        {
            return SearchByImdbId(ImdbId,null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="languages"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByQuery(string Query, OSLanguage languages)
        {
            return SearchByImdbIdThenQuery(null, Query, languages);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByQuery(string Query, CultureInfo culture)
        {
            return SearchByImdbIdThenQuery(null, Query, OSLanguageHelper.GetOSLanguage(culture));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public List<SearchSubtitleResult> SearchByQuery(string Query)
        {
            return SearchByQuery(Query, (OSLanguage)null);
        }
        public List<SearchSubtitleResult> SearchByFile(FileInfo VideoFile, OSLanguage languages)
        {
            if (VideoFile != null && VideoFile.Exists)
            {
                
                XmlRpcStruct SearchParamsStruct = new XmlRpcStruct();
                XmlRpcStruct Limit = new XmlRpcStruct();
                Limit.Add("limit", 10);
                if (languages != null)
                {
                    SearchParamsStruct.Add("sublanguageid", languages.IdSubLanguage);
                }
                else
                {
                    SearchParamsStruct.Add("sublanguageid", "all");
                }
                byte[] hash = GetHash.Main.ComputeHash(VideoFile.FullName);
                SearchParamsStruct.Add("moviehash", GetHash.Main.ToHexadecimal(hash));
                SearchParamsStruct.Add("moviebytesize", Convert.ToDouble(VideoFile.Length));
                XmlRpcStruct ResponseStruct = proxy.SearchSubtitles(Token, new object[2] { new XmlRpcStruct[1] { SearchParamsStruct }, new XmlRpcStruct[1] { Limit } });
                List<SearchSubtitleResult> SearchResultList = DoSearchRequest(ResponseStruct);
                return SearchResultList;
            }
            return new List<SearchSubtitleResult>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MemoryStream DownloadSubtitle(SearchSubtitleResult SearchResult)
        {
            XmlRpcStruct ResponseStruct = proxy.DownloadSubtitles(Token, new int[1] { Convert.ToInt32(SearchResult.IDSubtitleFile) });
            byte[] encodedDataAsBytes = System.Convert.FromBase64String((String)((XmlRpcStruct)((object[])ResponseStruct["data"])[0])["data"]);
            using (MemoryStream ms = new MemoryStream(encodedDataAsBytes))
            {
                int msgLength = BitConverter.ToInt32(encodedDataAsBytes, 0);
                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                { 
                    zip.Read(buffer, 0, buffer.Length);
                    return new MemoryStream(buffer);
                }
            }
        }
       
        public bool LogOut()
        {
            if (proxy != null && String.IsNullOrEmpty(Token))
            {
                XmlRpcStruct ResponseStruct = proxy.LogOut(Token);
                LastResponseCode = (string)ResponseStruct["status"];
                LastResponseTime = Convert.ToDouble(ResponseStruct["seconds"]);
                if ((!String.IsNullOrEmpty(LastResponseCode)) && LastResponseCode.Equals("200 OK"))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static OSServerInfo GetServerInfo()
        {
            IOpenSubtitles proxy = XmlRpcProxyGen.Create<IOpenSubtitles>();
            XmlRpcStruct ResponseStruct = proxy.GetServerInfo();
            OSServerInfo serverInfo = new OSServerInfo();
            serverInfo.Application = (string)ResponseStruct["application"];
            serverInfo.Contact = (string)ResponseStruct["contact"];
            serverInfo.SubsSubtitleFiles = (string)ResponseStruct["subs_subtitle_files"];
            serverInfo.XmlRpcVersion = (string)ResponseStruct["xmlrpc_version"];
            serverInfo.TotalUsersOnline = (string)ResponseStruct["users_online_total"];
            serverInfo.TotalSubsDownload = (string)ResponseStruct["subs_downloads"];
            serverInfo.TotalSubtitlesLanguages = (string)ResponseStruct["total_subtitles_languages"];
            serverInfo.UsersLoggedIn = (string)ResponseStruct["users_loggedin"];
            serverInfo.MoviesAka = (string)ResponseStruct["movies_aka"];
            serverInfo.UsersRegistred = (string)ResponseStruct["users_registered"];
            serverInfo.TotalMoviesCount = (string)ResponseStruct["movies_total"];
            serverInfo.WebsiteUrl = (string)ResponseStruct["website_url"];
            serverInfo.UsersOnlineProgram = (string)ResponseStruct["users_online_program"];
            serverInfo.XmlRpcUrl = (string)ResponseStruct["xmlrpc_url"];
            serverInfo.UsersMaxAllTime = (string)ResponseStruct["users_max_alltime"];
            return serverInfo;
        }
        public bool NoOperation()
        {
            XmlRpcStruct ResponseStruct = proxy.NoOperation(Token);
            this.LastResponseCode = (string)ResponseStruct["status"];
            this.LastResponseTime = Convert.ToDouble(ResponseStruct["seconds"]);
            return this.LastResponseCode.Equals("200 OK");
        }
        void proxy_RequestEvent(object sender, XmlRpcRequestEventArgs args)
        {
            Console.Clear();
            // Set the position to the beginning of the stream.
            Stream memStream = args.RequestStream;
            memStream.Seek(0, SeekOrigin.Begin);
            // Read the first 20 bytes from the stream.
           byte[] byteArray = new byte[memStream.Length];
           int count = memStream.Read(byteArray, 0, 20);
            // Read the remaining bytes, byte by byte.
            while (count < memStream.Length)
            {
                byteArray[count++] = Convert.ToByte(memStream.ReadByte());
            }
            // Decode the byte array into a char array 
            // and write it to the console.
            //UnicodeEncoding uniEncoding = new UnicodeEncoding();
            //char[]charArray = new char[uniEncoding.GetCharCount(byteArray, 0, count)];
            //uniEncoding.GetDecoder().GetChars(byteArray, 0, count, charArray, 0);
            ASCIIEncoding ascii = new ASCIIEncoding();
            Console.WriteLine(ascii.GetString(byteArray));
        }

        public int GetTimeOut()
        {
            return proxy.Timeout;
        }
        public void SetTimeOut(int TimeOut)
        {
            proxy.Timeout = TimeOut;
        }
    }
}
