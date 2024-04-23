using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class MusicDisc
    {
        private Hashtable songs = new Hashtable();

        public void AddSong(string title, string artist)
        {
            songs.Add(title, new Song(title, artist));
        }

        public void RemoveSong(string title)
        {
            songs.Remove(title);
        }

        public void DisplayContents()
        {
            foreach (DictionaryEntry entry in songs)
            {
                Song song = (Song)entry.Value;
                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}");
            }
        }

        public bool ContainsArtist(string artist)
        {
            foreach (DictionaryEntry entry in songs)
            {
                Song song = (Song)entry.Value;
                if (song.Artist == artist)
                    return true;
            }
            return false;
        }
    }
}
