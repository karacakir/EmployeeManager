﻿using System.Text.Json.Serialization;

namespace EmployeeManager.DTOs
{
    class Pagination
    {
        [JsonPropertyName("total")]
        public int Total
        {
            get; set;
        }
        [JsonPropertyName("pages")]
        public int Pages
        {
            get; set;
        }
        [JsonPropertyName("page")]
        public int Page
        {
            get; set;
        }
        [JsonPropertyName("limit")]
        public int Limit
        {
            get; set;
        }
    }
}
