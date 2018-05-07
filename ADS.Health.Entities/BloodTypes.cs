namespace ADS.Health.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class BloodTypes
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BloodTypes()
        {
            Patients = new HashSet<Patients>();
            Description = "";
            Abbreviation = "";
            ID = 0;
        }
        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(3)]
        [DisplayName("Type of blood")]
        public string Abbreviation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
