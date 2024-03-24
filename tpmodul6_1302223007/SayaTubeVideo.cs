
using System;
using System.Diagnostics;

namespace tpmodul6_1302223007
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

        public SayaTubeVideo(string title)
        {
            // precondition
            Debug.Assert(title != null, "Judul tidak boleh null!");
            Debug.Assert(title.Length <= 100, "Panjang judul maksimal 100 karakter!");

            this.title = title;
            Random generateId = new Random();
            this.id = generateId.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int num)
        {
            // precondition
            Debug.Assert(num <= 10000000, "Penambahan jumlah pemutaran maksimal 10.000.000");

            // exception
            try
            {
                int result = checked(playCount + num);
                this.playCount = result;
            }
            catch (OverflowException)
            {
                Console.WriteLine("[WARN] Play count melebihi batas integer.\n");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id + "\nJudul : " + title + "\nJumlah Pemutaran : " + playCount + "\n");
        }
    }
}

