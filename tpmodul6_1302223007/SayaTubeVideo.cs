
using System;
namespace tpmodul6_1302223007
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random generateId = new Random();
            this.id = generateId.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int num)
        {
            this.playCount += num;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id + "\nJudul : " + title + "\nJumlah Pemutaran : " + playCount + "\n");
        }
    }
}

