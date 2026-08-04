using SplashKitSDK;

namespace GenerateReplyExample
{
    public class Program
    {
        public static void Main()
        {
            string prompt = "Explain recursion in one short paragraph.";

            SplashKit.WriteLine("Prompt:");
            SplashKit.WriteLine(prompt);
            SplashKit.WriteLine("");
            SplashKit.WriteLine("AI reply:");

            string reply = SplashKit.GenerateReply(prompt);

            SplashKit.WriteLine(reply);
        }
    }
}
