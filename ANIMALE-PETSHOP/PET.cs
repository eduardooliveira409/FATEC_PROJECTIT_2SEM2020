//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ANIMALE_PETSHOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class PET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET()
        {
            this.AGENDAMENTO = new HashSet<AGENDAMENTO>();
        }
    
        public int CODIGO { get; set; }
        public string NOME_PET { get; set; }
        public Nullable<System.DateTime> DATA_NASCIMENTO { get; set; }
        public string SEXO { get; set; }
        public string TAMANHO { get; set; }
        public string RACA { get; set; }
        public string RESTRICOES { get; set; }
        public string DESC_RESTRICOES { get; set; }
        public int CODIGO_CLIENTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDAMENTO> AGENDAMENTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
    }
}