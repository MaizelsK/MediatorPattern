using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class RealtorMediator : Mediator
    {
        public Member CustomerMember { get; set; }
        public Member HolderMember { get; set; }

        public override void Send(string message, Member member)
        {
            if (member == CustomerMember)
            {
                HolderMember.Notify(message);
            }
            else if (member == HolderMember)
            {
                CustomerMember.Notify(message);
            }
        }
    }
}
