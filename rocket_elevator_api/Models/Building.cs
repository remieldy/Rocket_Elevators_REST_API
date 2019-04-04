using System;
namespace rocket_elevator_api.Models
{
    public class Building
    {
        public long Id { get; set; }
        public long Address_id { get; set; }
        public long Customer_id { get; set; }
        public string Full_Name_Admin_Person { get; set; }
        public string Email_Admin_Person { get; set; }
        public string Phone_Number_Admin_Person { get; set; }
        public string Full_Name_Tech_Person { get; set; }
        public string Email_Tech_Person { get; set; }
        public string Phone_Number_Tech_Person { get; set; }

    }
}
