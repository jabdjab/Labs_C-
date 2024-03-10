using System;
using System.Reflection.Emit;
class Solution12 {
  static int Enter(){
        Console.WriteLine("Введите N - размер массива больше 0");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n <= 0)
            n = Enter();
        return n;
    }
static int [,] Swap(int a, int b, int n, int [,] m){
    for(int i = 0; i<n; i++){
        int x = m[i,a];
        m[i,a] = m[i,b];
        m[i,b] = x;
    }
    return m;
}
static int MiniF(int a, int n, int [] m){
    int mini=a;
    for(int i =a;i<n;i++)
        if(m[mini]>m[i])
            mini = i;
    return mini;
}
  static void Main() {
    int n = Enter();

    int [,] m = new int [n,n];
    int [] hr = new int [n];

    Random rnd = new Random();
    int sum = 0;
    
    Console.WriteLine("Массив: ");   
    for(int i = 0; i < n; i++)
    {
        int res = 0;
        bool ch = false;
        hr[i]=0;
        for(int j = 0; j<n;j++){
            m[j,i] = rnd.Next(-100,100);
            res += m[j,i];
            if(m[j,i] < 0){
                if((-m[j,i])%2==1)
                    hr[i]+=-m[j,i];
                ch = true;
            }
        }

        if(ch)
            sum += res;
    }
    for(int i = 0;i<n;i++)
    Console.Write(hr[i]+" ");
    Console.WriteLine();
       for(int i = 0; i<n;i++){
            for(int j = 0; j<n;j++){
                Console.Write(m[i,j] + " ");
            }
            Console.WriteLine();
        }

    for(int i = 0; i < n; i++){
        int a = MiniF(i,n,hr);
        if(i != a){
            Swap(a,i,n,m);
            int r = hr[i];
            hr[i] = hr[a];
            hr[a] = r;
        }
    }
    Console.WriteLine("Обновлённый массив:");
        for(int i = 0; i<n;i++){
            for(int j = 0; j<n;j++){
                Console.Write(m[i,j] + " ");
            }
            Console.WriteLine();
        }
    Console.WriteLine("Сумма: " + sum);

  }
}