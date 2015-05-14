using Domain.Customers;

namespace Domain
{
    public partial class CustomerPrivate : Customer, ICustomer
    {
        public override string ToString()
        {
            return "Name: " + Name + ", Phone: " + Phone + ", Address" + Address + ", Age: " + Age+", Sex: "+Sex;
        }

        public override void PresentAnnouncement(string msg)
        {
            if (NewsReciever)
            {
                System.Diagnostics.Debug.WriteLine("Hi " + Name + ",  \n" + msg);
            }
        }

        public override bool CheckIfNewsReciever()
        {
            return NewsReciever;
        }
    }
}
