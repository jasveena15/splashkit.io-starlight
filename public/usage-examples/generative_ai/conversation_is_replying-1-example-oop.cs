using SplashKitSDK;

namespace ConversationIsReplyingExample
{
    public class Program
    {
        public static void Main()
        {
            Conversation chat = SplashKit.CreateConversation();

            string question = "Explain what a computer network is in one short paragraph.";

            SplashKit.WriteLine("Question:");
            SplashKit.WriteLine(question);
            SplashKit.WriteLine("");
            SplashKit.WriteLine("Status: AI is replying...");
            SplashKit.WriteLine("");
            SplashKit.WriteLine("AI reply:");

            SplashKit.ConversationAddMessage(chat, question);

            while (SplashKit.ConversationIsReplying(chat))
            {
                SplashKit.Write(SplashKit.ConversationGetReplyPiece(chat));
            }

            SplashKit.WriteLine("");
            SplashKit.WriteLine("");
            SplashKit.WriteLine("Status: Reply complete.");

            SplashKit.FreeConversation(chat);
        }
    }
}