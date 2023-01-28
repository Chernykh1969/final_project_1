List<string> A = new List<string>(){ "Hello", "2", "world", ":-)" };
List<string> B = new List<string>();

for (int i = 0; i < A.Count; i++)
{
    if (A[i].Length <= 3)
    {
        B.Add(A[i]);
    }
}

for (int i = 0; i < B.Count; i++)
{
    Console.WriteLine(B[i]);
}