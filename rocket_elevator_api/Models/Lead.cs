using System;
using static System.Net.Mime.MediaTypeNames;

namespace rocket_elevator_api.Models
{
    public class Lead
    {
        public long Id { get; set; }
        public long? Customer_Id { get; set; }
        public string Full_Name { get; set; }
        public string Company_Name { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Project_Name { get; set; }
        public string Project_Description { get; set; }
        public string Department_In_Charge { get; set; }
        public string Message { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }

    }
}