using System.ComponentModel;

namespace Students.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [DisplayName("Nume utilizator")]
        public string UserName { get; set; }

        [DisplayName("Adresa de email")]
        public string Email { get; set; }

        public AddressViewModel Address { get; set; }
    }

    public class AddressViewModel
    {
        [DisplayName("Strada")]
        public string Street { get; set; }

        [DisplayName("Oras")]
        public string City { get; set; }
    }
}