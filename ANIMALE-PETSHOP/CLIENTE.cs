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
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.PET = new HashSet<PET>();
        }
    
        public int CODIGO { get; set; }
        public string NOME_CLI { get; set; }
        public System.DateTime DATA_NASCIMENTO { get; set; }
        public string SEXO { get; set; }
        public string CPF { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET> PET { get; set; }
    }
}
