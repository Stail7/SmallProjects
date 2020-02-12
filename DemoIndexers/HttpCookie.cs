using System;
using System.Collections.Generic;

namespace DemoIndexers
{
    public class HttpCookie
    {
        private readonly Dictionary<int, string> _dictionary = new Dictionary<int, string>();
        public DateTime Expiry { get; set; }
        public string this[int key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}