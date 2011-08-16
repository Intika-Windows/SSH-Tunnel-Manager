namespace SSHTunnelManager.Domain
{
    public class ForwardingResult
    {
        private ForwardingResult(bool success, string errorString = null)
        {
            Success = success;
            ErrorString = errorString;
        }

        public static ForwardingResult CreateSuccess() { return new ForwardingResult(true); }
        public static ForwardingResult CreateFailed(string errorString) { return new ForwardingResult(false, errorString); }

        public bool Success { get; private set; }
        public string ErrorString { get; private set; }

        public override string ToString()
        {
            return Success ? "Succeed" : ErrorString;
        }
    }
}