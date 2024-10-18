namespace _22._1_Date {
    abstract class Program {
        static void Main() {
            // Store the results for small timestamps
            var date1 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 3)).Date.ToUniversalTime();
            var date2 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 4)).Date.ToUniversalTime();
            var date3 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 5)).Date.ToUniversalTime();
            var date4 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 6)).Date.ToUniversalTime();

            // Print each small timestamp result to the console
            Console.WriteLine("10^3 timestamp: " + date1);
            Console.WriteLine("10^4 timestamp: " + date2);
            Console.WriteLine("10^5 timestamp: " + date3);
            Console.WriteLine("10^6 timestamp: " + date4);

            // Store the results for larger timestamps
            var date5 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 9)).Date.ToUniversalTime();
            var date6 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 10)).Date.ToUniversalTime();
            var date7 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 11)).Date.ToUniversalTime();
            var date8 = DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10, 12)).Date.ToUniversalTime();

            // Print each larger timestamp result to the console
            Console.WriteLine("10^9 timestamp: " + date5);
            Console.WriteLine("10^10 timestamp: " + date6);
            Console.WriteLine("10^11 timestamp: " + date7);
            Console.WriteLine("10^12 timestamp: " + date8);
        }
    }
}