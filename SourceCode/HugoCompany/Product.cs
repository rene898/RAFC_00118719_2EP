
namespace HugoCompany
{
    public class Product
    {
        public int idProduct { get; set; }
        public int idBusiness { get; set; }
        public string name { get; set; }

        public Product()
        {
            idProduct = 1;
            idBusiness = 1;
            name = "";
        }
    }
}