using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Tamtom.AuthenticationAndAuthorization.Authentication.Models
{
    public class DirectRegisterModel
    {
        public string PersonnelID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public byte UserNameType { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 2)]
        public string LanguageID { get; set; }

        public int? CurrencyID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(10, MinimumLength = 10)]
        public int NationalID { get; set; }

        public bool? Gender { get; set; }

        public DateTime BirthDate { get; set; }
        
        public string BirthDateShamsi { get; set; }

        public byte[] Signature { get; set; }

        public string Password { get; set; }

        [Required]
        public int RoleID { get; set; }

        public int? BusinessID { get; set; }

        public int? JobTitleID { get; set; }

        public string Access { get; set; }
    }
}
