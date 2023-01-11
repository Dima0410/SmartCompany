﻿namespace SmartCompany.Models
{
    public class Profit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Summ { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
    }
}
