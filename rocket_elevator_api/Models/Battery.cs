using System;
namespace rocket_elevator_api.Models
{
    public class Battery
    {
        public long Id { get; set; }
        public int Building_id { get; set; }
        public int User_id { get; set; }
        public string Building_type { get; set; }
        public string Status { get; set; }
        public string Date_of_install { get; set; }
        public string Date_of_inspect { get; set; }
        public long Inspect_certificate { get; set; }
        public string Information { get; set; }

    }

    public class BatteryStatus
    {
        public long Id { get; set; }
        public string Status { get; set; }

    }
}
