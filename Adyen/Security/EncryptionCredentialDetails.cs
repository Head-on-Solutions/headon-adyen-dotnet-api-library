using System.ComponentModel.DataAnnotations;

namespace HeadOn.Classic.Adyen.Security
{
    public class EncryptionCredentialDetails
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public int KeyVersion { get; set; }

        [Required]
        public string KeyIdentifier { get; set; }

        [Required]
        public int AdyenCryptoVersion { get; set; }
    }
}
