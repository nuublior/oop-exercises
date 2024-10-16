using _22._2_Timing;

double x = 1.0000001;

for (int y = 1; y <= 32; y++)
{
    long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    double result = Timing.Fun(x, y);
    long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    long timeTaken = endTime - startTime;

    Console.WriteLine($"Fun({x}, {y}) = {result}, Time taken: {timeTaken} ms");
}
