namespace tpmodul6_1302220084
{
    public class SayaTubeVideoClass
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideoClass(String title)
        {
            Random rdm = new Random();
            this.title = title;
            this.playCount = 0;
            this.id = rdm.Next(10000, 99999);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount+=playCount;
        }

        public void PrintVideoDetails() {
            Console.WriteLine($"id:     {id}");
            Console.WriteLine($"title:  {title}");
            Console.WriteLine($"play count: {playCount}");
        }
    }
}
