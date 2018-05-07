namespace ADS.Health.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Countries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Countries()
        {
            Patients = new HashSet<Patients>();
            Name = "";
            ID = 0;
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Country")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
