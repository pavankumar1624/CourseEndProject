using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace courseEndProject.models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string? EmpName { get; set; }
        public string? Email { get; set;}
        [ForeignKey("DeptCode")]
        public int DeptCode { get; set; }
   
    }
}
