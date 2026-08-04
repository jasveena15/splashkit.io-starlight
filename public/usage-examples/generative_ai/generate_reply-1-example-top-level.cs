using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string prompt = "Explain recursion in one short paragraph.";

WriteLine("Prompt:");
WriteLine(prompt);
WriteLine("");
WriteLine("AI reply:");

string reply = GenerateReply(prompt);

WriteLine(reply);
