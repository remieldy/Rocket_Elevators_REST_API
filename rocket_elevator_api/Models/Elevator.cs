using System;
namespace rocket_elevator_api.Models
{
    public class Elevator
    {
        public long Id { get; set; }
        public long Column_id { get; set; }
        public int Serial_number { get; set; }
        public string Model_type { get; set; }
        public string Building_type { get; set;  }
        public string Status { get; set; }
        public DateTime? Date_of_install { get; set; }
        public DateTime? Date_of_inspect { get; set; }
        public long Inspect_certificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }

    }

    public class ElevatorStatus
    {
        public long Id { get; set; }
        public string Status { get; set; }

    }
}
