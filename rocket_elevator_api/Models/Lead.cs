using System;
using static System.Net.Mime.MediaTypeNames;

namespace rocket_elevator_api.Models
{
    public class Lead
    {
        public long Id { get; set; }
        public long? Customer_id { get; set; }
        public string Full_name { get; set; }
        public string Company_name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Project_name { get; set; }
        public string Project_description { get; set; }
        public string Department_in_charge { get; set; }
        public string Message { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

    }
}