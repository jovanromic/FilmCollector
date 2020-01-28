using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSubtitlesDotNET
{
    /*Successful 2xx

        200 OK
        206 Partial content; message
    Moved 3xx

        301 Moved (host)
    Errors 4xx

        401 Unauthorized
        402 Subtitles has invalid format
        403 SubHashes (content and sent subhash) are not same!
        404 Subtitles has invalid language!
        405 Not all mandatory parameters was specified
        406 No session
        407 Download limit reached
        408 Invalid parameters
        409 Method not found
        410 Other or unknown error
        411 Empty or invalid useragent
        412 %s has invalid format (reason)
        413 Invalid ImdbID
    Server Error 5xx

        503 Service Unavailable 
    */
    public class OSDotNetStatusCodeManager
    {
    }
}
