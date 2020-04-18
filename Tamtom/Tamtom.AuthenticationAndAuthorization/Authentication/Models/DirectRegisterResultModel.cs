using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Tamtom.AuthenticationAndAuthorization.Authentication.Models
{
    public class DirectRegisterResultModel
    {
        [Required]
        public int Result { get; set; }

        public int UserID { get; set; }

        public Guid UserToken { get; set; }

        public string AccountActivationCode { get; set; }
    }
}
