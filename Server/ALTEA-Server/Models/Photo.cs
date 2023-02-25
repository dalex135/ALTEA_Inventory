﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ALTEA_Server.Models
{
    public class Photo
    {

        public int Id { get; set; }
        public string? Description { get; set; }
        public string? configString { get; set; }
        public string? FileString { get; set; }
        public string? Path { get; set; }

        public int? RecipientForeignKey { get; set; }

        [ForeignKey("RecipientForeignKey")]
        public Recipient? Recipient { get; set; }
    }
}