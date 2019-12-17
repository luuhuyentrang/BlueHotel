using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Entity
{
    [Table("Address")]
    public class Address
    {

        #region Attibuts
        private int addressId;
        private string street;
        private string zipCode;
        private string city;
        private double? latitude;
        private double? longitude;
        private string country;
        private string phone;
        private string email;

      



        #endregion
        // propriétés de navigations
        //pas besoin
        public virtual Hotel Hotel { get; set; }

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }

   
        [StringLength(255)]
        [Required]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

       
        [StringLength(10)]
        [Required]
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        
        [StringLength(50)]
        [Required]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public double? Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double? Logitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        
        [StringLength(50)]
        [Required]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [StringLength(14)]
        [Required]
        [RegularExpression(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [Required]
        [StringLength(255)]
        [RegularExpression(@"^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
    }
}
