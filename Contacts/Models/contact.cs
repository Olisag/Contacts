//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contacts.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class contact
    {
        public int contactid { get; set; }

        [Required(ErrorMessage = "Please enter Firstname")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Please enter Lastname ")]
        public string lastname { get; set; }

        [Required(ErrorMessage = " Please enter a Cellphone Number ")]
        [Phone(ErrorMessage = " Please enter a valid Cellphone Number ")]
        public string cellphone { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        public string email { get; set; }
    }
}
