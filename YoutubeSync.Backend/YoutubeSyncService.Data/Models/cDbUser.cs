using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSyncService.Data.Models
{
    [Table("Users")]
    public class cDbUser : cDbBaseEntity
    {
        public required string Username { get; set; }

        public required string Email { get; set; }
    }
}
