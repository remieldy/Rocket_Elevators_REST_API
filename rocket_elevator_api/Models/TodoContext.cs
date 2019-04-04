using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;


namespace rocket_elevator_api.Models
{
    public class TodoContext : DbContext
    {
        public string ConnectionString { get; set; }

        public TodoContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<Elevator> GetElevator()
        {
            List<Elevator> list = new List<Elevator>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM elevators where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Elevator()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Serial_number = Convert.ToInt32(reader["serial_number"]),
                            Status = reader["status"].ToString()

                        });
                    }
                }
            }
            return list;
        }


        public List<Elevator> GetElevatorId(long id)
        {
            Console.WriteLine(id);
            List<Elevator> list = new List<Elevator>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM elevators where id = @id", conn);

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@id",
                    Value = id,
                });

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Elevator()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Serial_number = Convert.ToInt32(reader["serial_number"]),
                            Status = reader["status"].ToString()

                        });
                    }
                }
            }
            return list;
        }
        // BATTERY ---------------------------------------------------------------------------------------

        public List<Battery> GetBattery()
        {
            List<Battery> list = new List<Battery>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM batteries", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Battery()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Status = reader["status"].ToString()

                        });
                    }
                }
            }
            return list;
        }



        public List<Battery> GetBatteryId(long id)
        {
            List<Battery> list = new List<Battery>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM batteries where id = @id", conn);

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@id",
                    Value = id,
                });

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Battery()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Status = reader["status"].ToString()

                        });
                    }
                }
            }
            return list;
        }

        // PUT 
        public void PutBatteryStatus(long id, [FromBody]string status)
        {
        

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();


                MySqlCommand cmd = new MySqlCommand("update batteries set  where id = @id SET", conn);

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@id",
                    Value = id,
                });


                
            }
        }
    }
}
