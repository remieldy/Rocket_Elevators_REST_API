using System;
namespace rocket_elevator_api.Models
{
    public class Building
    {
        public long Id { get; set; }
        public long Address_id { get; set; }
        public long Customer_id { get; set; }
        public string Full_name_admin_person { get; set; }
        public string Email_admin_person { get; set; }
        public string Phone_number_admin_person { get; set; }
        public string Full_name_tech_person { get; set; }
        public string Email_tech_person { get; set; }
        public string Phone_number_tech_person { get; set; }

    }
}
