using System.ComponentModel.DataAnnotations;

namespace Tankdaten.Models
{
    public class TankdatenViewModel
    {
        public int Id { get; set; }
        public string? Fahrzeug { get; set; }
        [DataType(DataType.Date)]
        public DateTime GetanktAm { get; set; }
        public decimal Kosten { get; set; }
    }
}
