using System;
namespace rocket_elevator_api.Models
{
    public class Column
    {
        public long Id { get; set; }
        public int Battery_id { get; set; }
        public string Building_type { get; set; }
        public int Number_of_floors { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Information { get; set; }
    }

    public class ColumnStatus
    {
        public long Id { get; set; }
        public string Status { get; set; }
    }
}
