﻿using System.Text.Json.Serialization;

namespace EmployeeManager.DTOs
{
    public class Employee
    {
        [JsonPropertyName("id")]
        public int Id
        {
            get; set;
        }
        [JsonPropertyName("name")]
        public string Name
        {
            get; set;
        }
        [JsonPropertyName("email")]
        public string Email
        {
            get; set;
        }
        [JsonPropertyName("gender")]
        public string  Gender
        {
            get; set;
        }
        [JsonPropertyName("status")]
        public string Status
        {
            get; set;
        }
        [JsonPropertyName("created_at")]
        public string CreatedAt
        {
            get; set;
        }
        [JsonPropertyName("updated_at")]
        public string UpdatedAt
        {
            get; set;
        }
    }
}
