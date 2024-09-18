int i = 5; // Step (i) and (ii)
long l = i; // Step (iii) and (iv), implicit cast from int to long
i = (int)l; // Step (v), explicit cast from long to int
Console.WriteLine(i);
