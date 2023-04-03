namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoPost myVideo = new VideoPost(
                "my first video", "Joca", "https://jocas/myFirstVideo.mp3", true, 100);

            Console.WriteLine(myVideo.ToString());

            myVideo.Play();
            Console.ReadLine();
            myVideo.Stop();

        }
    }
}