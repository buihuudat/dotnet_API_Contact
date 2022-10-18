namespace ContactsAPI.Models
{
    public class UpdateContactRequest
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public long Phone { get; set; }
        public string Address { get; set; } = "";
    }
}
