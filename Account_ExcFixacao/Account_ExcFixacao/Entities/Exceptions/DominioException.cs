using System;

namespace Account_ExcFixacao.Entities.Exceptions
{
    class DominioException : Exception
    {
        public DominioException(string mensagem) :  base(mensagem)
        { }
    }
}
