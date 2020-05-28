namespace HugoCompany
{
    public class Address
    {
        public int idAddress { get; set; }
        public int idUser { get; set; }
        public string address { get; set; }

        public Address()
        {
            idAddress = 1;
            idUser = 1;
            address = "";
        }

    }
}