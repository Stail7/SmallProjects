using System;

namespace StopWatch {
    public class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
        private DateTime _star;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running. " +
                                                    "Only one Start() method " +
                                                    "can be called at a time.");
            _star = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running. " +
                                                    "Call Start() method first.");
            Duration = DateTime.Now - _star;
            _isRunning = false;
        }
    }
}