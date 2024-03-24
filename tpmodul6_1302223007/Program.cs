using tpmodul6_1302223007;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo(
            "Tutorial Design By Contract - Muhammad Haulul Azkiyaa"
            );
        video1.PrintVideoDetails();

        // tes prekondisi (kode diberi komentar karena hanya untuk pengujian)

        // 1. judul null
        //SayaTubeVideo video2 = new SayaTubeVideo(null);

        // 2. judul lebih dari 100 karakter
        //SayaTubeVideo video3 = new SayaTubeVideo(
        //    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "
        //    );

        // 3. Penambahan play count lebih dari 10.000.000
        //video1.IncreasePlayCount(10000001);


        // tes overflow exception
        for (int i = 0; i < 215; i++)
        {
            video1.IncreasePlayCount(10000000);
            video1.PrintVideoDetails();
        }
    }
}