using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Part01.Entities
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int D_Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime HiringDate { get; set; }
    
        public int Ins_Id { get; set; }
    }
}
