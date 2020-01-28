using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSubtitlesDotNET
{
	/*
	 *  ["application"]	"OpenSuber v0.2"	
		["contact"]	"admin@opensubtitles.org"	
		["subs_subtitle_files"]	"1204018"	
		["xmlrpc_version"]	"0.1"	
		["users_online_total"]	"0"	
		["seconds"]	0.082	
		["subs_downloads"]	"338593104"	
		["total_subtitles_languages"]	"56"	
		["users_loggedin"]	"0"	
		["movies_aka"]	"100129"	
		["last_update_strings"]	{CookComputing.XmlRpc.XmlRpcStruct}	
		["users_registered"]	"953214"	
		["movies_total"]	"59419"	
		["website_url"]	"http://www.opensubtitles.org"	
		["users_online_program"]	"0"	
		["xmlrpc_url"]	"http://api.opensubtitles.net/xml-rpc"	
		["users_max_alltime"]	"27449"	

	 */
	public class OSServerInfo
	{
		public String Application { get; internal set; }
		public String Contact { get; internal set; }
		public String SubsSubtitleFiles { get; internal set; }
		public String XmlRpcVersion { get; internal set; }
		public String TotalUsersOnline { get; internal set; }
		public String TotalSubsDownload { get; internal set; }
		public String TotalSubtitlesLanguages { get; internal set; }
		public String UsersLoggedIn { get; internal set; }
		public String MoviesAka { get; internal set; }
		public String UsersRegistred { get; internal set; }
		public String TotalMoviesCount { get; internal set; }
		public String WebsiteUrl { get; internal set; }
		public String UsersOnlineProgram { get; internal set; }
		public String XmlRpcUrl { get; internal set; }
		public String UsersMaxAllTime { get; internal set; }
	}
}
