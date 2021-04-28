using System;
using System.IO;

namespace ConsoleApp3
{
    public class Customer : IDisposable
    {
        private StringReader _reader;
        private bool disposed = false;
        public Customer(string value)
        {
            this._reader = new StringReader(value);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_reader != null)
                    {
                        this._reader.Dispose();
                    }
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    class Sample
    {
        public static void Main()
        {
            Customer c = new Customer("sample");
            Console.ReadLine();
        }
    }
      
}