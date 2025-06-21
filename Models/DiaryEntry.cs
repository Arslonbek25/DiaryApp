using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = String.Empty;
        [Required]
        public string Content { get; set; } = String.Empty;
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}