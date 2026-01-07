using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song(); // 1

            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);
            song.Play();

            Song song2 = new Song(); // 2
            song2.Title = "Dark side of moon";
            song2.Seconds = 350;
            song2.Position = new ShelvePosition(1, 0);

            Console.WriteLine(song2.ToString());

            if (song == song2)
            {
                Console.WriteLine("Son iguales");
            }

            PlayList<Song> playListSongs = new PlayList<Song>();
            playListSongs.Add(song);
            playListSongs.Add(song2);

            ListExplanation();
            StackExplanation();
            QueueExplanation();
            DictionaryExplanation();
        }

        private static void DownloadSong()
        {
            DownloadService downloadService = new DownloadService();
            byte[] song = downloadService.Download("Dark side of the moon");
        }

        private async static void DownloadSongAsync()
        {
            DownloadService downloadService = new DownloadService();
            byte[] futureSong = await downloadService.DownloadAsync("Dark side of the moon");
        }

        private static void DictionaryExplanation()
        {
            Dictionary<string, Client> clients = new Dictionary<string, Client>();

            clients.Add("0000000D", new Client() { Name = "Jose Manuel" });

            if (!clients.ContainsKey("0000000D"))
            {
                clients.Add("0000000D", new Client() { Name = "Jose Manuel" });
            }

            clients["0000000D"] = new Client();

            Client myClient = clients["0000000D"];

            var elements = new List<KeyValuePair<string, Client>>();
            elements.Add(new KeyValuePair<string, Client>("0001", new Client()));
            elements.Add(new KeyValuePair<string, Client>("0002", new Client()));

            // Utils.AddRangeDictionary(clients, elements);
            clients.AddRange(elements);
        }

        private static void ListExplanation()
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            // numbers.Count;
        }

        private static void StackExplanation()
        {
            Stack<Song> salesSongs = new Stack<Song>();
            salesSongs.Push(new Song());
            Song song = salesSongs.Pop();
        }

        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            int number = queueNumbers.Dequeue();
        }

        static void Declarations()
        {
            int num = 0;
            double numDecimal = 0.0;
            bool booleano = true;
            string helloWorld = string.Empty;

            // ==
            //_ !=
            // >=
            // <=
            // >
            // <
            // && (AND)
            // || (OR)
        }

        static void Conditions()
        {
            int number = 0;
            number += 2; // number => 2

            number -= 2; // number => 0
                         //Si
            if (number == 0)
            {
                //
            }
            // Si no si
            else if (number > 0)
            {

            }
            else
            {

            }
        }

        static void Loops()
        {
            int number = 0;
            for (int i = 0; i < 10; i++)
            {
                // Do something
            }

            while (number != 10)
            {
                number++;
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {

            }
        }

        static void Switch()
        {
            int number = 0;
            switch (number)
            {
                case 0:

                    break;
                case 10:

                    break;
                default:
                    break;
            }
        }
    }
}
