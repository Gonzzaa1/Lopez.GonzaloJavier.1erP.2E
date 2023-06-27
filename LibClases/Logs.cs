namespace LibClases
{
    public delegate void EventoLog(string message);
    public class Logs
    {
        public event EventoLog? logEvento;

        public void Log(string message)
        {
            logEvento?.Invoke(message);
        }
    }
    
}
