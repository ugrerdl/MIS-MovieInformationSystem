//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int CommentId { get; set; }
        public Nullable<int> MovieId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string CContent { get; set; }
        public Nullable<System.DateTime> CDate { get; set; }
    
        public virtual Movies Movies { get; set; }
    }
}
