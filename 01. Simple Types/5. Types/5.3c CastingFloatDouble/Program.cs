float f = 1.1234567f;
double d = f;  // Implicit cast
Console.WriteLine("Float to double (implicit): " + d);

float f2 = (float)d;  // Explicit cast
Console.WriteLine("Double to float (explicit): " + f2);
