using System;

namespace ProjetoWebMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }   
    }
}
