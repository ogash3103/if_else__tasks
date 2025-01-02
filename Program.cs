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

/*System.Console.Write("Daqiqa ko'rinishida son kiriting: ");
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
System.Console.WriteLine(radoms); */


// task 7 end



// task 8 start Palindrome Tekshiruvi

System.Console.Write("So'z kiriting va men sizga palindrom yoki yoqligini aytaman: ");
string inputPalindrom = Console.ReadLine()!;

string toLower = inputPalindrom.ToLower();
bool isPalindrome = true;

for(int i = 0; i < toLower.Length / 2; i++)
{
   if(toLower[i] != toLower[toLower.Length - 1 - i])
   {
      isPalindrome = false;
      break;
   }
}

if(isPalindrome) System.Console.WriteLine("So'z Palindrom!");
else System.Console.WriteLine("So'z Plaindrom emas!");

// task 8 end


// task 9 Temperatura o'girish start

System.Console.WriteLine("Selsiyus bo'yicha temperaturani kiriting: ");
decimal celsius = decimal.Parse(Console.ReadLine()!);

decimal fahrenheit = (celsius * 9 / 5) + 32;
decimal kelvin = celsius + 273.15m;

Console.WriteLine("Natijani tanlang:");
        Console.WriteLine("1. Selsiyus");
        Console.WriteLine("2. Fahrenheit");
        Console.WriteLine("3. Kelvin");
        Console.Write("Tanlovingiz: ");
int choice = int.Parse(Console.ReadLine()!);

switch(choice)
{
   case 1:  Console.WriteLine($"Selsiyus: {celsius}"); break;
   case 2:  Console.WriteLine($"Fahrenheit: {fahrenheit:F2}"); break;
   case 3:  Console.WriteLine($"Kelvin: {kelvin:F2}"); break;
   default: Console.WriteLine("Noto'g'ri tanlov! Iltimos, 1, 2 yoki 3ni tanlang.");
            break;
}

// task 9 end


// Task 10 Sonlarni tartiblash start

  Console.WriteLine("Iltimos, beshta son kiriting:");
        Console.Write("1-son: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2-son: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("3-son: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("4-son: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("5-son: ");
        int num5 = Convert.ToInt32(Console.ReadLine());

 for (int i = 0; i < 5; i++)
        {
            if (num1 > num2) (num1, num2) = (num2, num1);
            if (num2 > num3) (num2, num3) = (num3, num2);
            if (num3 > num4) (num3, num4) = (num4,num3);
            if (num4 > num5) (num4, num5) = (num5, num4);
        }

int aDesc = num5, bDesc = num4, cDesc = num3, dDesc = num2, eDesc = num1;

 Console.WriteLine("Natijani tanlang:");
        Console.WriteLine("1. O'sish tartibi (Ascending)");
        Console.WriteLine("2. Kamayish tartibi (Descending)");
        Console.Write("Tanlovingiz: ");
int choices = Convert.ToInt32(Console.ReadLine());

  switch (choices)
        {
            case 1:
                Console.WriteLine($"Tartiblangan qator: {num1}, {num2}, {num3}, {num4}, {num5}");
                break;
            case 2:
                Console.WriteLine($"Teskari tartib: {aDesc}, {bDesc}, {cDesc}, {dDesc}, {eDesc}");
                break;
            default:
                Console.WriteLine("Noto'g'ri tanlov! Iltimos, 1 yoki 2ni tanlang.");
                break;
        }

//  task 10 end

// task 11 start Berilgan matnning simvol sanasini hisoblash

Console.Write("Matn kiriting: ");
string inputString = Console.ReadLine()!;

for(int i = 0; i < inputString.Length; i++)
{

    char currentChar = inputString[i];
    if(currentChar == ' ') continue;
    int count = 0;

    for(int j = 0; j < inputString.Length; j++)
    {
        if(currentChar == inputString[j])
        {
           count++;
        }
    }
    
    bool alreadyCounted = false;

    for(int k = 0; k < i; k++)
    {
        if(inputString[k] == currentChar)
        {
           alreadyCounted = true;
           break;
        }
    }
    if(!alreadyCounted)
    {
        Console.WriteLine($"'{currentChar}': {count} martta");
    }


}

// task 11 end