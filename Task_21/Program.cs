// Расстояние между векторама

double Distance(double[] v1, double[] v2)
{
    double sum = 0;

    for (int i = 0; i < v1.Length; i++)
    {
        double r = v1[i] - v2[i];
        sum = sum + r * r;
    }

    double ret = Math.Sqrt(sum);

    return ret;
}

double[] v1 = { 3.0, 6.0, 8.0 };
double[] v2 = { 2.0, 1.0, -7.0 };

double d = Distance(v1, v2);

string res = String.Format("{0:f2}", d);

Console.WriteLine("Расстояние между векторами {0}", res);
