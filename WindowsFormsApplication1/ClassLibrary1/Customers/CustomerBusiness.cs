using Domain.Customers;

namespace Domain
{
    public partial class CustomerBusiness : Customer, ICustomer
    {
        public override string ToString()
        {
            return "Name: "+CompanyName+", Contact Person: "+ContactPerson+", Phone: "+Phone+", Address"+Address+", SE #: "+SENumber;
        }

        public override void PresentAnnouncement(string msg)
        {
            if (NewsReciever)
            {
                System.Diagnostics.Debug.WriteLine("Hello " + CompanyName + ",  \n" + msg);
            }
        }

        public override bool CheckIfNewsReciever()
        {
            return NewsReciever;
        }
    }
}
