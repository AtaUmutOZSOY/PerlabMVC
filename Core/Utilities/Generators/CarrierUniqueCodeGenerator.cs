namespace Core.Utilities.Generators
{
    public class CarrierUniqueCodeGenerator
    {
        public static string GenerateUniqueCode()
        {
            var currentTime = DateTime.UtcNow;
            var randomPart = new Random().Next(1000, 9999); // 1000 ile 9999 arasında rastgele bir sayı
            return $"{currentTime:yyyyMMddHHmmss}{randomPart}";
        }
    }
}
