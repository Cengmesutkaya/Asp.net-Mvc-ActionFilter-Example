using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExample
{
    [Table("Logs")]
    public class Log
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required, StringLength(50)]
        public string ActionName { get; set; }
        [Required, StringLength(50)]
        public string ControllerName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, StringLength(150)]
        public string Information { get; set; }
    }
}
