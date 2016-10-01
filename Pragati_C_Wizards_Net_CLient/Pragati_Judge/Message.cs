using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pragati_Judge
{
    class Message
    {
        int fromId,toId,id;
        string msgText;
        public Message(int fromId, int toId, string msgText)
        {
            id = 0;
            this.msgText = msgText;
            this.fromId = fromId;
            this.toId = toId;
        }

        public int FromId
        {
            get { return fromId; }
        }

        public int ToId
        {
            get { return toId; }
        }

        public string Text
        {
            get { return msgText; }
        }
            

        internal bool send()
        {
            return (new DbaseHandler()).sendSms(this);
        }
    }
}
