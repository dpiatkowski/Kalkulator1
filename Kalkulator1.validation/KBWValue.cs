using System;

namespace Kalkulator1.validation
{
    public class KBWValue
    {
        public string Message { get; private set; }

        public string Step { get; private set; }

        public KBWValue(string message, string step)
        {
            Message = message;
            Step = step;
        }

        public static bool operator ==(KBWValue c1, KBWValue c2)
        {
            return c1.Message == c2.Message && c1.Step == c2.Step;
        }

        public static bool operator !=(KBWValue c1, KBWValue c2)
        {
            return !(c1.Message == c2.Message) || !(c1.Step == c2.Step);
        }
    }
}
