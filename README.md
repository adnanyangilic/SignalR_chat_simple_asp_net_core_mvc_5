# SignalR_chat_simple_asp_net_core_mvc_5
1-Create an ASP.Net Core MVC 5 application (with individual accounts identity selected for later improvements.)
2-Create Hubs folder and ChatHub class.
3-In Startup.cs add------------- services.AddSignalR();
4-In Startup.cs add------------- endpoints.MapHub<ChatHub>("/chat");
5-In wwwroot folder create main.js 
6-In Home/Index.cshtml create view. 
7-For basic functionality of SignalR chat application, database and connection is not required. Nuget package is not required.
8-If you put html file (here its name is index.html) in wwwroot folder then you can also run chat application page 
