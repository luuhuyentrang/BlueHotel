using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Entity
{
    [Table("Room")]
    public class Room
    {
        #region Attibuts
        private int roomId;
        private string name;
        private int floor;
        private string caterogy;


        #endregion

        #region Properties

        // propriétés de navigations
        public virtual Hotel Hotel { get; set; }
       // public virtual ICollection<Booking> Bookings { get; set; }

        public virtual ICollection<BookingRoom> BookingRooms { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        [StringLength(30)]        
        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Range(0, 200)]
        [Required]
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        [StringLength(50)]
        public string Caterogy
        {
            get { return caterogy; }
            set { caterogy = value; }
        }
        #endregion
    }
}
