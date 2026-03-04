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
//    if (nums[i] %3 == 0)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}