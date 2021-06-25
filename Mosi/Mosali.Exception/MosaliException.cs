using System;
using System.Runtime.Serialization;

namespace Mosali.Exceptions
{
    [Serializable]
    public class MosaliException : Exception
    {
        public MosaliException()
       : base() { }

        public MosaliException(string message)
            : base(message) { }

        public MosaliException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public MosaliException(string message, Exception innerException)
            : base(message, innerException) { }

        public MosaliException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected MosaliException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
