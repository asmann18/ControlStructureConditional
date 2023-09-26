using System.Collections.Concurrent;

namespace aztuIf
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region SinifdekiPraktika
            //    Console.WriteLine("Eded daxil edin:");
            //    int i;
            //restart:
            //    int.TryParse(Console.ReadLine(), out i);
            //    if (i is 0)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("duzgun eded daxil edin:"); goto restart;
            //    }
            //    if (i % 2 == 0)
            //        Console.WriteLine("Eded cutdur");
            //    else
            //        Console.WriteLine("eded tekdir");





            //    Console.WriteLine("Eded daxil edin:");
            //    double i;
            //restart:
            //    double.TryParse(Console.ReadLine(), out i);
            //    double f = i /5 * 9 + 32;
            //    Console.WriteLine("farangeiht"+f);



            //Console.WriteLine("2 eded daxil edin:");
            //int a;
            //int b;
            //string c;
            //restart:
            //int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out b);
            //c=Console.ReadLine();
            //switch (c)
            //{
            //    case "+":
            //        Console.WriteLine(a+b);
            //        break;
            //        case "-":
            //            Console.WriteLine(a-b);
            //        break;
            //        case "*":
            //            Console.WriteLine(a*b);
            //        break;
            //        case "/":
            //            Console.WriteLine(a/b);
            //            break;
            //    default:
            //        Console.WriteLine("Wrong Operator");
            //        break;
            //}

            //if (a == default && b == default && c == default)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Duzgun ededler daxil edin:");
            //    goto restart;

            //}
            //int max=Math.Max(a, b);
            //max=Math.Max(max, c);
            //Console.WriteLine(max);





            //Console.WriteLine("eded daxil edin");
            //int point;
            //restart:
            //int.TryParse(Console.ReadLine(), out point);
            //if(point==default || point<0)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    goto restart;
            //}
            //if (point > 90 && point <= 100)
            //{
            //    Console.WriteLine("A");
            //}


            //if (point > 80 && point <= 90)
            //{
            //    Console.WriteLine("B");
            //}


            //if (point > 70 && point <= 80)
            //{
            //    Console.WriteLine("C");
            //}

            //if (point > 60 && point <= 70)
            //{
            //    Console.WriteLine("D");
            //}


            //if (point > 0 && point <= 60)
            //{
            //    Console.WriteLine("E");
            //}



            //Console.WriteLine("3 reqemli eded daxil edin");
            //int num;
            //restart:
            //string numStr=Console.ReadLine();
            //int.TryParse(numStr, out num);
            //if(num==default || numStr.Length != 3)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    goto restart;
            //}


            //int one = num / 100;
            //int two = (num % 100)/10;
            //int three = (num % 100)%10;
            //Console.WriteLine(one*100+"  "+two*10+"   "+three);
            #endregion



            #region Task1
            //1. Verilmiş 4 rəqəmli ədədin mərtəbələrinin cəmini (Məsələn: input 1234, output 10) tapan alqoritmi yazın.

            Console.WriteLine("Task 1 \n \n");
            Console.WriteLine("4 reqemli eded daxil edin:");
            restart:
            string numStr=Console.ReadLine();
            int.TryParse(numStr, out int num);
            if(num==default || numStr.Length != 4)
            {
                Console.Clear();
                Console.WriteLine("Duzgun eded daxil edin:");
                goto restart;
            }
            int one = num / 1000;
            int two = num % 1000/100;
            int three = num % 100/10;
            int four = num % 10;
            int result=one + two + three + four;
            Console.WriteLine( "result:"+result);
            #endregion

            #region Task2
            //Verilmiş 3 rəqəmli ədədin bütün mərtəbələrinin bir-birindən fərqli olub olmadığını tapan alqoritmi yazın(Məsələn: input 223, output "ferqli olmayan rəqəmlər var " (false) ).
            Console.WriteLine("\n \n Task 2 \n \n");
            Console.WriteLine("3 reqemli eded daxil edin:");
            restartTask2:
            numStr = Console.ReadLine();
            num = default;
            int.TryParse(numStr,out num);
            if(num==default || numStr.Length != 3)
            {
                Console.Clear();
                Console.WriteLine("Duzgun eded daxil edin");
                goto restartTask2;
            }
            one=num / 100;
            two=num % 100/10;
            three=num %10;
            if(one==two || two==three || one == three)
               Console.WriteLine("ferqli olmayan reqemler var");
            else
                Console.WriteLine("butun reqemler ferqlidi");

            #endregion

            #region Task3
            //a və b tam ədəd dəyişənlərinin dəyərlərini dəyişdirən proqram yazın
            Console.WriteLine("\n \n Task 3 \n \n");
            Console.Write("a ededini daxil edin \n a=");
            restartSetA:
            int.TryParse(Console.ReadLine(), out int a);
            if (a == default)
            {
                Console.Clear();
                Console.WriteLine("Duzgun eded daxil edin \n a=");
                goto restartSetA;
            }  
            Console.Write("a ededini daxil edin \n b=");
            restartSetB:
            int.TryParse(Console.ReadLine(), out int b);
            if (b == default)
            {
                Console.Clear();
                Console.WriteLine("Duzgun eded daxil edin \n b=");
                goto restartSetB;
            }
            int existValue = b;
            b = a;
            a= existValue;
            Console.WriteLine("a="+a+"\n b="+b);


            #endregion

            #region Task4
            //Cinemaya gedən müştərilərin bilet qiymətini hesablayan proqram yazın. Biletin qiyməti müştərinin yaşından və tələbə biletinin olub-olmamasından asılıdır.
            Console.WriteLine("\n \n Task 4 \n \n");
            Console.Write("Yasinizi daxil edin:");
            restartSetAge:
            int.TryParse(Console.ReadLine(), out int age);
            if(age == default || age<0 || age>200) 
            {
                Console.Clear();
                Console.Write("Duzgun yas daxil edin:");
                goto restartSetAge;
            }
            bool isStudent=false;
            if(age>12 && age < 60)
            {
                Console.WriteLine("Telebesiniz? y/n");
                restartSetIsStudent:
                var isStudentStr = Console.ReadLine();
                if(isStudentStr !="y"&& isStudentStr != "n")
                {
                  Console.Clear();
                    Console.WriteLine("Duzgun cavab verin,Telebesiniz? y/n");
                    goto restartSetIsStudent;
                }
               if(isStudentStr =="y")
                    isStudent = true;
            }

            double ticketPrice;
            if(age<=12 || age>=60)
                ticketPrice = 5;
            else
            {
                if (isStudent)
                    ticketPrice = 7.5;
                else
                    ticketPrice = 10;
            }
            Console.WriteLine("Ticket Price:"+ticketPrice);
            #endregion
        }
    }
}