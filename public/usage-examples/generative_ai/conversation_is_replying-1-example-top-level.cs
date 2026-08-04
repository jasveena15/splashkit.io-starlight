using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Conversation chat = CreateConversation();

string question = "Explain what a computer network is in one short paragraph.";

WriteLine("Question:");
WriteLine(question);
WriteLine("");
WriteLine("Status: AI is replying...");
WriteLine("");
WriteLine("AI reply:");

ConversationAddMessage(chat, question);

while (ConversationIsReplying(chat))
{
    Write(ConversationGetReplyPiece(chat));
}

WriteLine("");
WriteLine("");
WriteLine("Status: Reply complete.");

FreeConversation(chat);