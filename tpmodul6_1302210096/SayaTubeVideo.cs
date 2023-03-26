using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210096
{

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            try
            {
                if (string.IsNullOrEmpty(title) || title.Length > 100)
                {
                    throw new ArgumentException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak boleh null atau kosong.");
                }

                this.id = new Random().Next(10000, 99999);
                this.title = title;
                this.playCount = 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void IncreasePlayCount(int count)
        { 
            try
            {
                checked
                {
                    if (count > 10000000 || count < 0)
                    {
                        throw new OverflowException("Play count tidak boleh lebih dari 10.000.000 atau kurang dari 0.");
                    }

                    playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }
    }
}