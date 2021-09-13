namespace BlazorServerSignalRApp.Server.Hubs
{
    public class ChatMessage
    {
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}