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
    
    public partial class SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICO()
        {
            this.AGENDAMENTO = new HashSet<AGENDAMENTO>();
        }
    
        public int CODIGO { get; set; }
        public int CODIGO_TIPO_SER { get; set; }
        public string PRECO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDAMENTO> AGENDAMENTO { get; set; }
        public virtual TIPO_SERVICO TIPO_SERVICO { get; set; }
    }
}
