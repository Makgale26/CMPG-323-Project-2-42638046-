﻿using System;

namespace Project2_API.Models
{
    public partial class JobTelemetry
    {
        public int Id { get; set; }
        public string? ProccesId { get; set; }
        public string? JobId { get; set; }
        public string? QueueId { get; set; }
        public Guid? ProjectId { get; set; }  // Assuming it's a GUID
        public Guid? ClientId { get; set; }   // Ensure this property exists
        public DateTime EntryDate { get; set; }
        public double? TimeSaved { get; set; }
        public double? CostSaved { get; set; }
        public string? StepDescription { get; set; }
        public int? HumanTime { get; set; }
        public string? UniqueReference { get; set; }
        public string? UniqueReferenceType { get; set; }
        public string? BusinessFunction { get; set; }
        public string? Geography { get; set; }
        public bool? ExcludeFromTimeSaving { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
