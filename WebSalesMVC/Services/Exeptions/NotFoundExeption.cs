using System;


namespace WebSalesMVC.Services.Exeptions
{
    public class NotFoundExeption : ApplicationException
    {
        public NotFoundExeption(string message) : base(message)
        {

        }
    }
}
