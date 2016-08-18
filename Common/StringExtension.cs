using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringExtension
    {
        public static string URLCombine(this string url, string relativePath)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            url = url.Trim();
            while (url.IndexOf("/") == url.Length - 1)
            {
                url = url.Substring(0, url.Length - 1);
                if (string.IsNullOrEmpty(url)) throw new ArgumentException("url无效");
            }
            if (!string.IsNullOrEmpty(relativePath))
            {
                relativePath = relativePath.Trim();
                while (relativePath[0] == '/')
                {
                    if (relativePath.Length == 1)
                    {
                        relativePath = string.Empty;
                        break;
                    }
                    relativePath = relativePath.Substring(1);

                }
            }
            return url + (string.IsNullOrEmpty(relativePath) ? string.Empty : "/" + relativePath);
        }
    }
}
