namespace ProgramiranjeUDotNetuOOPVjezba1
{
    internal class Contact
    {
        public string? Name { get; set; } = "";

        public string PhoneNumber { get; set; } = string.Empty;

        public Contact(string name)
        {
            Name = name;
        }

        public Contact(string name, string phoneNumber = "")
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
