// Кубы чисел от 1 до N

double[] Cube(int N)
{
    double[] ret = new double[N];

    for (int i = 0; i < N; i++)
        ret[i] = Math.Pow(i + 1, 3);

    return ret;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string str = String.Format("{0:f1}", arr[i]);
        Console.WriteLine(str);
    }
}

Console.WriteLine("Input number -> ");
string str = Console.ReadLine();
int N = Convert.ToInt32(str);

double[] cube = Cube(N);
Console.WriteLine("Результат работы -> ");
PrintArray(cube);

