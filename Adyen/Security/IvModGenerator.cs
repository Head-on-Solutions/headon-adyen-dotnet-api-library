using System.Security.Cryptography;

namespace HeadOn.Classic.Adyen.Security
{
    internal class IvModGenerator
    {
        internal byte[] GenerateRandomMod()
        {
            var ivMod = new byte[EncryptionDerivedKey.IVLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetNonZeroBytes(ivMod);
            }

            return ivMod;
        }
    }
}
