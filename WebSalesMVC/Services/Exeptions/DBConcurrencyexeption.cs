using System;


namespace WebSalesMVC.Services.Exeptions
{
    public class DBConcurrencyexeption : ApplicationException
    {
        public DBConcurrencyexeption(string message) : base(message)
        {

        }
    }
}
