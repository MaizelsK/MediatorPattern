using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RealtorMediator realtorMediator = new RealtorMediator();
            CustomerMember customer = new CustomerMember(realtorMediator);
            HolderMember holder = new HolderMember(realtorMediator);

            realtorMediator.CustomerMember = customer;
            realtorMediator.HolderMember = holder;

            customer.Send("Добрый день, я бы хотел посмотреть квартиру по адресу Пушкина 42.");
            Console.ReadLine();

            holder.Send("Добрый день, квартира на данный момент занята, свяжитесь через 2 недели.");
            Console.ReadLine();
        }
    }
}
