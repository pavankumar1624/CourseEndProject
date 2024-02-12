using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace courseEndProject.models
{
    [Table("DeptMaster0")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set; }   
        public ICollection<EmpProfile>? EmpProfiles { get; set; }   
    }
}
