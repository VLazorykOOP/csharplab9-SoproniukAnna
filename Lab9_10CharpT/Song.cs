﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class Song
    {
            public string Title { get; set; }
            public string Artist { get; set; }

            public Song(string title, string artist)
            {
                Title = title;
                Artist = artist;
            }
    }
}
