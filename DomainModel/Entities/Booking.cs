using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Entity
{
    [Table("Booking")]
    public class Booking
    {
        #region Attibuts
        private int bookingId;
        private DateTime created;
        private DateTime checkIn;
        private DateTime checkOut;
        private bool isPaid;
        private decimal price;

        #endregion


        #region Properties

        // propriétés de navigations
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

        public virtual ICollection<BookingRoom> BookingRooms { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        [Required]
        [Range(typeof(DateTime), "01/01/2019", "31/12/2100")]
        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        [Required]
        [Range(typeof(DateTime), "01/01/2019", "31/12/2100")]
        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        

        [Required]
        [Range(typeof(DateTime), "01/01/2019", "31/12/2100")]
        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        [Required]
        public bool IsPaid
        {
            get { return isPaid; }
            set { isPaid = value; }
        }

        [Required]
        
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
    }
}
