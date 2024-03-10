
using System;

class Solution11 {
 
    static int Enter(){
        Console.WriteLine("Введите N - размер массива больше 0");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n <= 0)
            n = Enter();
        return n;
    }
  static void Main() {
    int n = Enter();

    double [] m = new double [n];
    int [] negative = new int [n];

    Random rnd = new Random();
  

    double sum = 0;
    double sum1 = 0;
    int ch = 0;
    int mod = 0;
    int mini = 0;
    Console.WriteLine("Массив: ");   
    for(int i = 0; i<n; i++)
    {
        m[i] = rnd.NextDouble() * (2.0 + 2.0) - 2.0;
  
        if(m[i] < m[mini])
            mini = i;

        if(Math.Abs(m[i]) <= 1.0)
            negative[mod++] = i;
        if(m[i] < 0){
            ch++;
            if(ch==1){
                sum1 = sum;
               // Console.WriteLine(m[i] + " " + sum);
            }
            if(ch==2){
                sum1 = sum - sum1 + m[i];
              //  Console.WriteLine(m[i] + " " + sum);
            }
        }
        sum += m[i];

        Console.Write (m[i] + " ");
    }
    Console.WriteLine(""); 
    
    if(ch < 2)
        Console.WriteLine(mini + " недостаточно отрицательных чисел");
    else
        Console.WriteLine(mini + " " + sum1);

// Перестановка
    int x = 0;
    for(int i = 0; i<n; i++)
    {
        
        if(Math.Abs(m[i]) > 1.0 && x < mod){
            double k = m[i];
            m[i] = m[negative[x]];
            m[negative[x]] = k;
            x++;
        }
        else
            x++;
        
    }
    for(int i = 0; i<n;i++){
        Console.Write(m[i] + " ");
    }
  }
}

