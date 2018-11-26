using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract public class Mediator
    {
        public abstract void Send(string message, Member member);
    }
}
