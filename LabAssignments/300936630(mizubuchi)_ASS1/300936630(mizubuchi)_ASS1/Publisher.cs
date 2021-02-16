using System.Collections.Generic;

namespace _300936630_mizubuchi__ASS1
{
    public class Publisher
    {
        public List<SendViaEmail> ReadersViaEmail { get; } = new List<SendViaEmail>();
        public List<SendViaMobile> ReadersViaMobile { get; } = new List<SendViaMobile>();

        public delegate void PublishMessageDel(string msg);
        public PublishMessageDel publishMsg = null;

        public void PublishMessage(string content)
        {
            publishMsg.Invoke(content);
        }

    }
}
