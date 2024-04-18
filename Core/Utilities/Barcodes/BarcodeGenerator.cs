namespace Core.Utilities.Barcodes
{
    public static class BarcodeGenerator
    {
        private static long lastTransactionNumber = 0;

        public static string GenerateSellerBatchBarcode()
        {
            long timestamp = DateTime.Now.Ticks;
            lastTransactionNumber++;

            return $"SB{timestamp}{lastTransactionNumber}";
        }

        public static string GeneratePackageBarcode()
        {
            long timestamp = DateTime.Now.Ticks;
            lastTransactionNumber++;

            return $"PKG{timestamp}{lastTransactionNumber}";
        }
    }
}
