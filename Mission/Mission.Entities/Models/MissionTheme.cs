using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Models
{
    public class MissionTheme
    {
        [Key]
        public int Id { get; set; }
        public required string Status { get; set; }
        public required string ThemeName { get; set; }

    }
}
