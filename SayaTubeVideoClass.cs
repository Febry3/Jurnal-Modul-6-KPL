using System.Diagnostics;

namespace tpmodul6_1302220084
{
    public class SayaTubeVideoClass
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideoClass(String title)
        {
            Debug.Assert(title.Length <= 100 && title != null, "Judul Kepanjangan");
            Random rdm = new Random();
            this.title = title;
            this.playCount = 0;
            this.id = rdm.Next(10000, 99999);
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 10000000, "Play Count harus dibawah dari 10000000");

            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Jumlah Play Count melebihi 2^32");
            }


        }

        public void PrintVideoDetails() {
            Console.WriteLine($"id          : {this.id}");
            Console.WriteLine($"title       : {this.title}");
            Console.WriteLine($"play count  : {this.playCount}");
        }
    }
}
