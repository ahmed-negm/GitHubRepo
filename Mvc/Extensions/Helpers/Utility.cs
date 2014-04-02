using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net;

namespace RadarcOnline.App.Presentation.Mvc.Extensions.Helpers
{
    public static class Utility
    {
        public static string DecodeHtml(string htmltext)
        {
            htmltext = htmltext.Replace("<p>", "").Replace("</p>", "\r\n\r\n");

            string decoded = String.Empty;
            if (htmltext.IndexOf('<') > -1 || htmltext.IndexOf('>') > -1 || htmltext.IndexOf('&') > -1)
            {
                try
                {
                    HtmlDocument document = new HtmlDocument();

                    var decode = document.CreateElement("div");
                    htmltext = htmltext.Replace(".<", ". <").Replace("?<", "? <").Replace("!<", "! <").Replace("&#039;", "'");
                    decode.InnerHtml = htmltext;

                    var allElements = decode.Descendants().ToArray();
                    for (int n = allElements.Length - 1; n >= 0; n--)
                    {
                        if (allElements[n].NodeType == HtmlNodeType.Comment || allElements[n].Name.EqualNoCase("style") || allElements[n].Name.EqualNoCase("script"))
                        {
                            allElements[n].Remove();
                        }
                    }
                    decoded = WebUtility.HtmlDecode(decode.InnerText);
                }
                catch { }
            }
            else
            {
                decoded = htmltext;
            }
            return decoded;
        }

        public static string SanitizeString(string text)
        {
            var textArray = text.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            string sanitizedText = string.Empty;
            foreach (var item in textArray.ToList())
            {
                sanitizedText += item.Trim();
            }

            return sanitizedText;
        }

        public static bool EqualNoCase(this String value, string content)
        {
            if (value != null)
            {
                return value.Equals(content, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                return false;
            }
        }

        public static string Truncate(this String str, int length, bool ellipsis = false)
        {
            if (!String.IsNullOrEmpty(str))
            {
                str = str.Trim();
                if (str.Length > length)
                {
                    if (ellipsis)
                    {
                        return str.Substring(0, length) + "...";
                    }
                    else
                    {
                        return str.Substring(0, length);
                    }
                }
            }
            return str ?? String.Empty;
        }
    }
}