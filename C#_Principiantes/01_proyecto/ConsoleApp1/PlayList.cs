using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class PlayList<T, V, Z>
    {

    }
    public class PlayList<T> where T : Song
    {
        List<T> mediaList = new List<T>();
        public void Add(T media)
        {
            mediaList.Add(media);
        }

        public void PlayAll()
        {
            foreach (T media in mediaList)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (mediaList.Count > 0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }

        public List<T> SearchForCategory(string category)
        {
            var songs = mediaList.Where(x => x.Category == category);

            /*
                        List<Song> songs = new List<Song>();
                        foreach (Song song in mediaList)
                        {
                            if (song.Category == category)
                            {
                                songs.Add(song);
                            }
                        }*/

            return songs.ToList();
        }

        public List<T> SearchForTitle(string title)
        {

            var songs = mediaList.Where(x => x.Title.Contains(title));
            /*List<Song> songs = new List<Song>();
            foreach (Song song in mediaList)
            {
                if (song.Title.Contains(title))
                {
                    songs.Add(song);
                }
            }*/

            return songs.ToList();
        }

        public List<string> GimmeTitlesFromSongs()
        {
            var titles = mediaList.Select(x => x.Title);
            /*List<string> titles = new List<string>();
            foreach (Song song in mediaList)
            {
                titles.Add(song.Title);
            }*/

            return titles.ToList();
        }

        public List<string> GimmeNamesOfArtists()
        {
            var names = mediaList.SelectMany(x => x.Artists)
                            .Select(x => x.Name);

            return names.ToList();
        }

        public bool HaveATitle(String title)
        {
            return mediaList.Any(x => x.Title == title);
        }

        public Song GetFirstSongWithLess1Minute()
        {
            var song = mediaList.FirstOrDefault(x => x.Seconds < 60);

            return song;
        }


        public Song GetLastSongWithLess1Minute()
        {
            var song = mediaList.LastOrDefault(x => x.Seconds < 60);

            return song;
        }

        public List<T> Top10()
        {
            return mediaList.OrderByDescending(x => x.Visits)
                            .Take(10).ToList();
        }

        public List<T> Bottom10()
        {
            return mediaList.OrderBy(x => x.Visits)
                            .Take(10).ToList();
        }

        public List<T> Skip10Top20()
        {
            return mediaList.Skip(10).Take(10).ToList();
        }

        public void GroupFromCategory()
        {
            mediaList.GroupBy(x => x.Category)
                    .ToDictionary(x => x.Key);
        }

        public List<Media> ToConvertMedia()
        {
            return mediaList.OfType<Media>().ToList();

        }

    }
}