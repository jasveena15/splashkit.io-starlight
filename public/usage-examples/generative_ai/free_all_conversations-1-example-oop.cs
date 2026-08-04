using SplashKitSDK;

Conversation studyConversation = new Conversation();
Conversation travelConversation = new Conversation();
Conversation codingConversation = new Conversation();

SplashKit.WriteLine("Three AI conversations have been created:");
SplashKit.WriteLine("- Study assistant");
SplashKit.WriteLine("- Travel assistant");
SplashKit.WriteLine("- Coding assistant");
SplashKit.WriteLine("");

SplashKit.WriteLine("Freeing all loaded conversations...");

GenerativeAi.FreeAll();

SplashKit.WriteLine("All conversation resources have been released.");