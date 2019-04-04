using System;
namespace rocket_elevator_api.Models
{
    public class Elevator
    {
        public long Id { get; set; }
        public long Column_Id { get; set; }
        public int Serial_number { get; set; }
        public string Status { get; set; }
        public string Model_type { get; set; }
        public string Building_type { get; set;  }
        public DateTime? Date_Of_Install { get; set; }
        public DateTime? Date_Of_Inspect { get; set; }
        public long Inspect_Certificate { get; set; }
        public string Information { get; set; }

    }

    public class ElevatorStatus
    {
        public long Id { get; set; }
        public string Status { get; set; }

    }
}
