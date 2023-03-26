// See https://aka.ms/new-console-template for more information

using tpmodul6_1302210096;
class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract – Arzaq Ajradika");
        SayaTubeVideo video2 = new SayaTubeVideo(null);
        SayaTubeVideo video3 = new SayaTubeVideo("Tutorial Design By Contract - Arzaq Ajradika...............................................................................................................................................");

        video1.IncreasePlayCount(500);


        video2.IncreasePlayCount(20000000);
        video3.IncreasePlayCount(-100);


        Console.WriteLine("\n");

        Console.WriteLine("Videos Details:\n");
        video1.PrintVideoDetails();
        Console.WriteLine("\n");
        video2.PrintVideoDetails();
        Console.WriteLine("\n");
        video3.PrintVideoDetails();

        Console.ReadLine();
    }
}
