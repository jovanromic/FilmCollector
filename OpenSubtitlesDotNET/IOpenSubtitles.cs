using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Collections;

namespace OpenSubtitlesDotNET
{
    [XmlRpcUrl("http://api.opensubtitles.org/xml-rpc")]
    public interface IOpenSubtitles : IXmlRpcProxy
    {
        [XmlRpcMethod("ServerInfo")]
        XmlRpcStruct GetServerInfo();

        [XmlRpcMethod("LogIn")]
        XmlRpcStruct LogIn(string username, string password, string language, string useragent);

        [XmlRpcMethod("LogOut")]
        XmlRpcStruct LogOut(string token);

        //array SearchSubtitles( $token, array(array('sublanguageid' => $sublanguageid, 'moviehash' => $moviehash, 'moviebytesize' => $moviesize, imdbid => $imdbid, query => 'movie name' ),array(...)))
        [XmlRpcMethod("SearchSubtitles")]
        XmlRpcStruct SearchSubtitles(string token, params object[] parameters);

        [XmlRpcMethod("DownloadSubtitles")]
        XmlRpcStruct DownloadSubtitles(string token, int[] IDSubtitleFile);

        [XmlRpcMethod("DownloadSubtitles")]
        XmlRpcStruct NoOperation(string token);
    }
}
