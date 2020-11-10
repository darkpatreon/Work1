using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class Validator
    {
        public abstract bool IsPasswordValid(string password);
        public abstract string HashPassword(string password);
        public abstract bool IsUserExists(string login, string password);
        public abstract bool IsEmailValid(string email);
        public abstract bool IsPhoneValid(string phone);
        public abstract bool IsWebPageAvailable(string url);
        public abstract bool IsDatabaseAccessible(string connectionString);
        public abstract bool IsDateValid(string date);
        public abstract bool IsUserRoot();
        public abstract void Log();
    }

    public class MyValid : Validator
    {
        public override string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public override bool IsDatabaseAccessible(string connectionString)
        {
            throw new NotImplementedException();
        }

        public override bool IsDateValid(string date)
        {
            throw new NotImplementedException();
        }

        public override bool IsEmailValid(string email)
        {
            throw new NotImplementedException();
        }

        public override bool IsPasswordValid(string password)
        {
            throw new NotImplementedException();
        }

        public override bool IsPhoneValid(string phone)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserExists(string login, string password)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserRoot()
        {
            throw new NotImplementedException();
        }

        public override bool IsWebPageAvailable(string url)
        {
            throw new NotImplementedException();
        }

        public override void Log()
        {
            throw new NotImplementedException();
        }
    }

}
