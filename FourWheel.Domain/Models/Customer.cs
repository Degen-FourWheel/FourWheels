namespace FourWheel.Domain.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; }

        public Customer()
        {
            CustomerFullName = $"{CustomerFirstName} {CustomerLastName}";
        }
    }
}