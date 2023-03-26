using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210096
{
    public class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;


        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Video title: " + this.title);
            Console.WriteLine("Playcount: " + this.playCount);

        }
    }
}
