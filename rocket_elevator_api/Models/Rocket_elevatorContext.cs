using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MySql.Data.MySqlClient;

namespace rocket_elevator_api.Models
{
    public class Rocket_elevatorContext: DbContext
    {
        public Rocket_elevatorContext(DbContextOptions<Rocket_elevatorContext> options)
            : base(options)
        {
        }
        public DbSet<Elevator> elevators { get; set; }
        public DbSet<ElevatorStatus> elevatorStatuses { get; set; }

        public DbSet<Battery> batteries { get; set;  }
        public DbSet<BatteryStatus> batteryStatuses { get; set; }

        public DbSet<Column> columns { get; set; }
        public DbSet<ColumnStatus> columnStatuses { get; set; }

        public DbSet<Building> buildings { get; set; }

        public DbSet<Lead> leads { get; set; }

    }
}
