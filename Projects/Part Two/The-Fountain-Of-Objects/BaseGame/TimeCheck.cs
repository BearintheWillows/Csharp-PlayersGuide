namespace The_Fountain_Of_Objects.BaseGame
{
    public class TimeCheck
    {
        private readonly DateTime _startTime;
        private DateTime _finishTime;
        public TimeCheck()
        {
            _startTime = DateTime.Now;
        }

        public Double WinTimeCheck()
        {
            _finishTime = DateTime.Now;
            TimeSpan time = _finishTime - _startTime;
            return time.TotalSeconds;

        }
    }
}
