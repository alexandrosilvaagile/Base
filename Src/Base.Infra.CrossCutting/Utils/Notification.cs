namespace Base.Infra.CrossCutting.Utils
{
    public class Notification
    {
        public string Key { get; }
        public string Message { get; }
        protected Notification() { }
        public Notification(string message) : this(key: string.Empty, message) { }
        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }

}
