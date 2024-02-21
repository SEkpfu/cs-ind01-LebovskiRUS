using System;
class Program {
  static double[] Fx(double[] x1){
    double[] fx = new double[x1.Length];
    for (int i = 0; i < x1.Length; i++){
        double x = x1[i];
        if (x < -3.0){
            fx[i] = ((1.0 + x*x*x) / (2.0 * x)) * ((x + 4.0) * (x*x - 1.0/x));
        }
        else if(x >= -3.0 & (x < 2.0 * Math.PI)){
            fx[i] = (x*x - 3.0) * Math.Sin(2.0 * x);
        }
        else fx[i] = 7.0/3.0;
    }
    return fx;
  }
  static void Main() {
    Console.WriteLine("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] x = new double[n];
    Console.WriteLine("Введите n чисел x: ");
    for (int i = 0; i < n; i++){
        x[i] = Convert.ToDouble(Console.ReadLine());
    }
    double[] fx = Fx(x);
    double[] z = new double[n];
    double[] fz = new double[n];
    int ct = 0;
    for (int i = 0; i < n; i++){
        if (((x[i] >= -10.0) & (x[i] <= 0.0)) & ((fx[i] >= -10.0) & (fx[i] <= 0.0)) & (x[i]*x[i] + fx[i]*fx[i] <= 10.0)){
            ct++;
        }
        if ((x[i]*x[i] + fx[i]*fx[i] <= 10.0) & (x[i] = 0.0) & ((fx[i] >= -5.0) & (fx[i] <= 0.0))){
            ct++;
        }
        if (((x[i] >= 10.0) & (x[i] <= 0.0)) & ((fx[i] >= -10.0) & (fx[i] <= 0.0)) & (fx[i] < x[i] + 10.0)){
            ct++;
        }
        else{
            z[i] = x[i];
            fz[i] = fx[i];
        }
    }
    Console.WriteLine("Кол-во точек = " + ct);
    Console.WriteLine("Растояния от (0, 0): ");
    double ox = 0.0;
    for (int i = 0; i <= z.Length; i++){
        double l = Math.Sqrt(z[i]*z[i] + fz[i]*fz[i]);
        Console.WriteLine(l);
        if (((x[i] >= 10.0) & (x[i] <= 0.0)) & ((fx[i] >= -10.0) & (fx[i] <= 0.0)) & (fx[i] < x[i] + 10.0)){
            if ( ox <= x[i]) {
                ox = x[i];
            }
        }
    }
    Console.WriteLine("Дальше всех от OX = " + ox);
  }
}
