using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("Hotel")]
    public class Hotel
    {
        #region Attibuts
        private int hotelId;
        private string name;
        private int star;

        #endregion

        #region Properties
         // propriétés de navigations
        public virtual Address Address { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId
        {
            get { return hotelId; }
            set { hotelId = value; }
        }

        [StringLength(50)]
        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        public int Star
        {
            get { return star; }
            set { star = value; }
        }
        #endregion
        #region Constructor
        public Hotel()
        {
            
        }
        #endregion


    }
}
