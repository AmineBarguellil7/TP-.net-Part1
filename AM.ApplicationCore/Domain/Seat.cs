using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        [Required(ErrorMessage = "Le champ Name est obligatoire")]
        [StringLength(1, ErrorMessage = "Le champ Name doit contenir au moins un caractère")]
        public string Name { get; set; }

        public string SeatNumber { get; set; }
        [Range(0, 20, ErrorMessage = "La valeur de la propriété Size doit être un nombre entre 0 et 20")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "La propriété Size doit être un nombre positif")]
        public int Size { get; set; }

        public virtual Plane plane { get; set; }

        public virtual int PlaneFk { get; set; }

        public virtual Section section { get; set; }
        public virtual int SectionId { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

    }
}
