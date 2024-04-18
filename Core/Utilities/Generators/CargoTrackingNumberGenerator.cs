namespace Core.Utilities.Generators
{
    public class CargoTrackingNumberGenerator
    {
        private static Random random = new Random();

        public static string CreateCargoTrackingNumber(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringChars = new char[length];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
    }
}
