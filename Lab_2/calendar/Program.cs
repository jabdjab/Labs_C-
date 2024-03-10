using System;
using System.Reflection.Emit;
class Solution12 {
  static int Enter(){
        Console.WriteLine("Use of the command");
        Console.WriteLine(" \"check\" to check is year leap ");
        Console.WriteLine(" \"calc\" to calc interval length");
        Console.WriteLine(" \"day\" to get the name of day of week");
        Console.WriteLine(" \"quit\" to exit");
         Console.WriteLine("");
        string com = Convert.ToString(Console.ReadLine());
       
        if(com == "check"){
            Console.WriteLine("Enter a year:");
           int n = Convert.ToInt32(Console.ReadLine());
           bool ans = Check(n);
           Console.WriteLine(ans ? "Year " + n + " is leap" : "Year " + n + " is NOT leap");
           
        }
        if(com == "calc"){
         Console.WriteLine("Enter dates in this format (yyyy-mm-dd)");
           DateTime datest = DateTime.Parse(Console.ReadLine());
           DateTime dateen = DateTime.Parse(Console.ReadLine());
           int n = Calc(datest,dateen);
           Console.WriteLine("The interval between this dates is " + (n==1 ? n + " day" : n + " days") );
        }
        if(com == "day"){
           Console.WriteLine("Enter dates in this format (yyyy-mm-dd)");
           DateTime date = DateTime.Parse(Console.ReadLine());
           DayOfWeek w = Day(date);
           Console.WriteLine("The day of the week " + w);
        }
        if(com == "quit"){
           return 0;
        }
        Console.WriteLine("");
        Enter();
        return 0;
    }
    static bool Check(int year){
        return (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
    }
    static int Calc(DateTime date1, DateTime date2 )
    {
        return (date2 - date1).Days < 0 ? (date1 - date2).Days : (date2 - date1).Days;
    }
    static DayOfWeek Day(DateTime date )
    {
         DayOfWeek WeekDay = date.DayOfWeek;
         return WeekDay;
    }


  static void Main() {
    int n = Enter();

 }
}