using System;
using System.Runtime.Serialization;

namespace Fiap.Exercicio01.Exceptions
{
    [Serializable]
    internal class ExceptionSaldoInsuficiente : Exception
    {
        public ExceptionSaldoInsuficiente()
        {
        }

        public ExceptionSaldoInsuficiente(string message) : base(message)
        {
        }

        public ExceptionSaldoInsuficiente(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionSaldoInsuficiente(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}