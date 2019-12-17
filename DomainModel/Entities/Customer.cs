using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Entity
{
    [Table("Customer")]
    public class Customer
    {
        #region Attibuts
        private int customerId;
        private string fullName;
        
        private DateTime dateOfBirth;

        #endregion

        #region Properties
        // propriétés de navigations
        public virtual Address Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        [Required]
        [StringLength(255)]
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        
        [Required]
        [Range(typeof(DateTime), "01/01/1900","31/12/2020")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        #endregion
    }
}
