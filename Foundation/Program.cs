Console.WriteLine();



// ui
// user interface
// datani yaratmaq, silmek, yaxud gostermek
//
//

//int reqem =int.Parse( Console.ReadLine());
//int reqem2 = Convert.ToInt32( Console.ReadLine());







// metodlar nedir? 
// Metodlar kod bloklarlidir ki hansi ki, biz onun adini
// cagirirq ve o calishir
// demeli metodlarla ishlemek tekrarciligin qarshini  alir 


//Metodlari nece yarada bilerik-> bunun ucun 4 usulumuz var

# region 1. void (yeni geriye hecne dondurmeyen) ve parametr almayan

//void SayHello()
//{
//    Console.WriteLine("Please enter your name");
//    string name = Console.ReadLine();
//    Console.WriteLine($"{name} hello");
//}

//void Sum()
//{
//    Console.WriteLine("Please enter first number");
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter second number");
//    int number2 = int.Parse(Console.ReadLine());
//    Console.WriteLine(number + number2);
//}

//Sum();
#endregion


#region 2. void (yeni geriye hecne dondurmeyen) ve parametr alan

//void Sayhello(string name)
//{
//    Console.WriteLine($"{name} hello");
//}

//Sayhello("Gunel");

//void Sum(int num1, int num2)
//{
//    Console.WriteLine(num1 + num2);
//}

//Sum(2,33);

#endregion


#region 3. return type olan ve parametr almayan

//string SayHello()
//{
//    Console.WriteLine("Please enter your name");
//    string name = Console.ReadLine();
//    string result = $"{name} hello";
//    return result;
//}

//Console.WriteLine(SayHello());

//int Sum()
//{
//    Console.WriteLine("Please enter first number");
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter second number");
//    int number2 = int.Parse(Console.ReadLine());
//    int res = number + number2; 
//    return res; 
//}

//Console.WriteLine(Sum());
#endregion

#region  4. return type olan ve parametr alan
//string SayHello(string ad)
//{
//    string result = $"{ad} hello";
//    return result;
//}

//Console.WriteLine(SayHello("Eldar"));

//int Sum(int num1, int num2)
//{
//  return num1 + num2;
//}

//Console.WriteLine(Sum(21,22));

#endregion









