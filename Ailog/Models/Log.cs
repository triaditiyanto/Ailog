using System.ComponentModel.DataAnnotations;
namespace Ailog.Models
{
    public class Log
    {
        public int ID { get; set; }
        [Display(Name = "Nama Barang")]
        public string Nama_Barang { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Waktu { get; set; }
        [Display(Name = "Jenis Barang")]
        public string Jenis_Barang { get; set; } = string.Empty;
        [Display(Name = "Status")]
        public string Status { get; set; } = string.Empty;
    }
}
