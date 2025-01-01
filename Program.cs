using System;

// task 1 start

/*System.Console.Write("string so'z kiriting: ");
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
System.Console.WriteLine(weekDays); */

// task 3 end



// task 4 start

System.Console.Write("Daqiqa ko'rinishida son kiriting: ");
int inputSoat = int.Parse(Console.ReadLine()!);

int min = inputSoat / 60;
int sec = inputSoat % 60;
System.Console.WriteLine($"{min:D2}:{sec:D2} soat");

// task 4 end


// task 5 start

System.Console.Write("Yosh kirgizing va men sizga (bola , katta va yoshga qarab ma'lumot beraman!): ");
int yosh = int.Parse(Console.ReadLine()!);

if(yosh <= 12) System.Console.WriteLine("Siz bolasiz! (0 - 12)");
else if(yosh <= 19) System.Console.WriteLine("Siz o'smirsiz! (13 - 19)");
else if(yosh <= 59) System.Console.WriteLine("Siz kattarlar toyfasiga kirasiz (20 - 59)");
else System.Console.WriteLine("Siz 60 da yoki katta bo'lishigiz kerak!");

// task 5 end


// task 6 start 

 Console.Write("1-fan bahosini kiriting (0-100): ");
int fan1 = int.Parse(Console.ReadLine()!);
 Console.Write("2-fan bahosini kiriting (0-100): ");
int fan2 = int.Parse(Console.ReadLine()!);
 Console.Write("3-fan bahosini kiriting (0-100): ");
int fan3 = int.Parse(Console.ReadLine()!);

 decimal average = (fan1 + fan2 + fan3) / 3m;
string results = average >= 80 ? "A'lo" :
                 average >= 60 ? "Yaxshi" :
                 average >= 40 ? "Qoniqarli" : 
                 "Qoniqarsiz";

 Console.WriteLine($"O'rtacha ball: {average:F2}");
 Console.WriteLine($"Natija: {results}");

// task 6 end



// task 7 start

Console.WriteLine("1 dan 100 gacha bo'lgan sirli raqamni toping!");
int taxminiySon = int.Parse(Console.ReadLine()!);

Random random = new Random();
int randomNumber = random.Next(0, 101);

string radoms = taxminiySon == randomNumber ? 
               "Tabriklayman! Siz to'g'ri topdingiz!" :
               taxminiySon > randomNumber ? "Raqam kichikroq!" :
               "Raqam katta!";
System.Console.WriteLine(radoms);               


// task 7 end



// task 8 start

// task 8 end