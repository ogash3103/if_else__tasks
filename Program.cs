using System;

// task 1 start

System.Console.Write("string so'z kiriting: ");
string str = Console.ReadLine()!;
System.Console.Write("Son kirgizing: ");
int son = int.Parse(Console.ReadLine()!);

string result = (son > str.Length) ? str.ToUpper() : str.ToLower();
System.Console.WriteLine(result);
// task 1 end



// task 2 start

int x = 15, 
    y = 10;

 if(x > y)
 {
    System.Console.WriteLine("x is greater than y");
 } else if (x < y)
 {
    System.Console.WriteLine("x is less than y");
 }  else if(x == y)
 {
    System.Console.WriteLine("x is equal to y");
 }else {System.Console.WriteLine("a and y are not comparable");}

// task 2 end

// task 3 start

System.Console.Write("Hafta kunini kirgizing O'zbek tilida: ");
string input = Console.ReadLine()!;
string weekDays = input switch 
{
   "Dushanba" => "Moday",
   "Seshanba" => "Tueasday",
   "Chorshanba" => "Wednesday",
   "Payshanba" => "Thursday",
   "Juma" => "Friday",
   "Shanba" => "Saturday",
   "Yakshanba" => "Sunday",
   _ => "Xato ma'lumot, Qayta urunib ko'ring.."

};
System.Console.WriteLine(weekDays);

// task 3 end