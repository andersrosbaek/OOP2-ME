namespace Domain.Customers
{
    public class Customer : ICustomer
    {
        public virtual void PresentAnnouncement(string msg)
        {
            // To be extended in sub-classes
        }

        public virtual bool CheckIfNewsReciever()
        {
            // To be extended in sub-classes
            return false;
        }
    }
}
