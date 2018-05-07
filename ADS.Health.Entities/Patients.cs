namespace ADS.Health.Entities
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Patients
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public string DateBirth { get; set; }

        [DisplayName("Country")]
        public int Nationality { get; set; }

        [DisplayName("Blood type")]
        public int BloodType { get; set; }

        [StringLength(150)]
        [DisplayName("Diseases")]
        public string Diseases { get; set; }

        [DisplayName("Phone")]
        public int PhoneNumber { get; set; }

        public virtual BloodTypes BloodTypes { get; set; }

        public virtual Countries Countries { get; set; }
    }
}
