using System;

namespace HugoCompany
{
    public class AppOrder
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; } 
        public int idAddress { get; set; }

        public AppOrder()
        {
            idOrder = 1;
            createDate = DateTime.Now;
            idProduct= 1;
            idAddress = 1;
        }
    }
}