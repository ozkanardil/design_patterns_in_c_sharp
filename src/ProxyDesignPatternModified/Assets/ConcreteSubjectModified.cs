using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternModified.Assets
{
    internal class ConcreteSubjectModified : SubjectModified
    {
        private string _user;

        public ConcreteSubjectModified(string user)
        {
            _user = user;
        }

        public override void DoSomeWork()
        {
            Console.WriteLine($"User {_user} is authorized and this text comes from ConcreteSubjectModified.DoSomeWork() method for him.");
        }
    }
}
