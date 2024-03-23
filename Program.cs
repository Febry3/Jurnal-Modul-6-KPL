using tpmodul6_1302220084;

internal class Program 
{
    private static void Main(string[] args)
    {
        SayaTubeVideoClass video = new SayaTubeVideoClass("Tutorial Design By Contract - Febry Twenido F.");

        //prekondisi
        //video.IncreasePlayCount(10000001);

        //exception
        int i = 1;
        while (i <= 100000)
        {
            video.IncreasePlayCount(100000);
            i++;
        }
        video.PrintVideoDetails();

    }
}