//Console.WriteLine("Enter numbers:");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());


//if (a>b)
//{
//    Console.WriteLine("A is greater than b");

//}
//else
//{
//    Console.WriteLine("B is greater than A");
//}


//Console.WriteLine("Enter number:");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a % 2 == 0)
//{
//    Console.WriteLine("This number is divided 2");
//}
//else
//{
//    Console.WriteLine("This number isn't divided 2");
//}

//Console.WriteLine("Enter number:");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a>=100)
//{
//    Console.WriteLine("This number is greater than 100");
//}
//else
//{
//    Console.WriteLine("This number is smaller than 100");
//}

//Console.WriteLine("Enter age:");
//int userAge = Convert.ToInt32(Console.ReadLine());

//if (userAge>18)
//{
//    Console.WriteLine("This user is adult");
//}
//else
//{
//    Console.WriteLine("This user isn't adult");
//}


//Console.WriteLine("Enter number:");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num>0)
//{
//    Console.WriteLine("This number is positive");
//}
//else if (num<0)
//{
//    Console.WriteLine("This number is negative");
//}
//else
//{
//    Console.WriteLine("This number is 0.");
//}

//Console.WriteLine("Enter day:");
//int day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Please enter valid daytime");
//        break;
//}

//Console.WriteLine("Enter number:");
//double number = Convert.ToInt32(Console.ReadLine());
//double result = Math.Pow(number, 3);
//Console.WriteLine(result);


//Console.WriteLine("Enter month:");
//int month = Convert.ToInt32(Console.ReadLine());

//switch (month)
//{
//    case 1 or 3 or 5 or 7 or 8 or 10 or 12:
//        Console.WriteLine("This month is 31 day");
//        break;
//    case 2:
//        Console.WriteLine("This month is 28 or 29 day");
//        break;
//    case 4 or 6 or 9 or 11:
//        Console.WriteLine("Wednesday");
//        break;
//    default:
//        Console.WriteLine("Please enter valid daytime");
//        break;
//}

//string[] fruits = { "Pear", "Peach", "Apple", "Banana", "Cherry", "Orange", "Kiwi" };


//string[] students = { "Aysel", "Murad", "Nigar", "Elvin", "Zehra", "Tural", "Leman", "Rauf", "Sabina", "Kamal" };

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//}

//Console.WriteLine(students[5]);

//Console.WriteLine("How many countries have you visited?");
//int count = Convert.ToInt32(Console.ReadLine());

//string[] travels = new string[count];

//for (int i = 0; i < travels.Length; i++)
//{
//    Console.Write($"Enter country {i + 1}: ");
//    travels[i] = Console.ReadLine();
//}

//Console.WriteLine("\nTraveled countries:");
//foreach (string country in travels)
//{
//    Console.WriteLine(country);
//}

//int[] nums = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 3 == 0)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

//int max = nums.Max();
//int min = nums.Min();
//double average = nums.Average();

//Console.WriteLine("Max: " + max);
//Console.WriteLine("Min: " + min);
//Console.WriteLine("Average: " + average);



//int odd = 0;
//int even = 0;

//for (int i = 1; i <= 500; i++)
//{
//    if (i%2 == 0)
//    {
//        odd += i;
//    }
//    else
//    {
//        even += i;
//    }

//}
//if (odd-even > 0)
//{
//    Console.WriteLine("ferq musbetdir");
//}
//else
//{
//    Console.WriteLine("ferq menfidir");
//}

//int[] fib = new int[10];

//fib[0] = 0;
//fib[1] = 1;

//for (int i = 2; i < fib.Length; i++)
//{
//    fib[i] = fib[i - 1] + fib[i - 2];
//}

//for (int i = 0; i < fib.Length; i++)
//{
//    Console.Write(fib[i] + " ");
//}



//Console.WriteLine("Enter number:");
//int n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];
//int result = 1;



//for (int i = 1; i <= arr.Length; i++)
//{
//    result *= i;
//}
//Console.WriteLine(result);





//Console.WriteLine("Enter number:");
//int n = Convert.ToInt32(Console.ReadLine());
//static bool Prime(int n)
//{
//    if (n <= 1)
//        return false;

//    for (int i = 2; i <= n / 2; i++)
//    {
//        if (n % i == 0)
//        {
//            return false;
//        }
//    }

//    return true;
//}

//if (Prime(n))
//{
//    Console.WriteLine("This number is prime");
//}
//else
//{
//    Console.WriteLine("This number is not prime");
//}



//int[] arr = { 23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 6 == 0)
//    {
//        Console.WriteLine(arr[i]);
//    }
//}


//Console.WriteLine("Enter first number:");
//double num1 = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine("Enter operator:");
//string act = Console.ReadLine();

//Console.WriteLine("Enter second number:");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double result = 0;

//if (num2 == 0)
//{
//    Console.WriteLine("Cannot be divided by 0");
//}
//else
//{
//  switch (act)
//{
//    case "+":
//        result = num1 + num2;
//        break;

//    case "-":
//        result = num1 - num2;
//        break;

//    case "*":
//        result = num1 * num2;
//        break;

//    case "/":
//        result = num1 / num2;
//        break;

//    case "%":
//        result = num1 % num2;
//        break;

//    case "**":
//        result = Math.Pow(num1, num2);
//        break;

//    default:
//        Console.WriteLine("Invalid operator");
//        return;
//}
//Console.WriteLine("Result: " + result);  
//}







//double[] prices = { 100.0, 1300.50, 259.99, 430.30, 160.99, 320.0 };

//for (int i = 0; i < prices.Length; i++)
//{
//    double discountedPrice = prices[i] * 0.8; 
//    Console.WriteLine("Original price: " + prices[i] + " -> Discounted price: " + discountedPrice);
//}

//int[] ages = { 23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57 };

//for (int i = 0; i < ages.Length; i++)
//{
//    if (ages[i] >= 65)
//    {
//        Console.WriteLine(ages[i] + " yasinda olan isci teqaude ayrilmalidir.");
//    }
//}


//Console.WriteLine("Uc terefi daxil edin:");

//Console.Write("a: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("b: ");
//double b = Convert.ToDouble(Console.ReadLine());

//Console.Write("c: ");
//double c = Convert.ToDouble(Console.ReadLine());

//if (a == b && b == c)
//{
//    Console.WriteLine("Beraberterefli ucbucaq");
//}

//else if (a == b || a == c || b == c)
//{
//    Console.WriteLine("Beraberyanli ucbucaq");
//}
//else if (a * a + b * b == c * c ||
//         a * a + c * c == b * b ||
//         b * b + c * c == a * a)
//{
//    Console.WriteLine("Duzbucaqli ucbucaq");
//}
//else
//{
//    Console.WriteLine("Muxtelifterefli ucbucaq");
//}




//Random rnd = new Random();
//int number = rnd.Next(1, 101);

//int attempt = 5;
//Console.WriteLine(number);
//while (attempt > 0)
//{
//    Console.Write("Ededi daxil edin: ");
//    int guess = Convert.ToInt32(Console.ReadLine());

//    if (guess == number)
//    {
//        Console.WriteLine("You Won!");
//        break;
//    }
//    else
//    {
//        attempt--;
//        Console.WriteLine("Sehv tapdiniz. Qalan cehd: " + attempt);
//    }

//    if (attempt == 0)
//    {
//        Console.WriteLine("Game Over. Dogru eded: " + number);
//    }
//}


//Console.Write("Kvadratın terefi: ");
//double a = Convert.ToDouble(Console.ReadLine());

//double saheKvad = Math.Pow(a, 2);
//double perimetrKvad = 4 * a;


//Console.Write("Duzbucaqlinin terefi: ");
//double b = Convert.ToDouble(Console.ReadLine());
//double c = Convert.ToDouble(Console.ReadLine());

//double saheDuz = c*b;
//double perimetrDuz = 2*(b+c);

//Console.WriteLine(saheKvad + " " + perimetrKvad);
//Console.WriteLine(saheDuz + " " + perimetrDuz);


//Console.Write("Eded daxil et: ");
//int n = int.Parse(Console.ReadLine());

//if (Palindromdur(n))
//    Console.WriteLine("Eded palindromdur");
//else
//    Console.WriteLine("Eded palindrom deyil");


//static bool Palindromdur(int n)
//{
//    int original = n;
//    int ters = 0;

//    while (n > 0)
//    {
//        int reqem = n % 10;
//        ters = ters * 10 + reqem;
//        n /= 10;
//    }

//    return original == ters;
//}
