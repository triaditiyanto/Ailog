using System.ComponentModel.DataAnnotations;
namespace Ailog.Models
{
    public class Use
    {
        public int ID { get; set; }
        [Display(Name = "Nomor karyawan")]
        public int Nomor_Karyawan { get; set; }

        [Display(Name = "Nama")]
        public string Nama{ get; set; } = string.Empty;

        [Display(Name = "Alamat")]
        public string Alamat { get; set; } = string.Empty;

        [Display(Name = "Job desk")]
        public string Job_Desk { get; set; } = string.Empty;
    }
}
