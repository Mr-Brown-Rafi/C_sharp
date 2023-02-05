using StaticKeyword;

namespace StaticKeyowrdDemo
{
    public class Customer
    {
        private string MachineName = "";
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        public Customer()
        {
   
            MachineName = CommonTask.ComputerName;
        }

        
        public void Insert()
        {

            if (CommonTask.IsEmpty(CustomerCode) && CommonTask.IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}