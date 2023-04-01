using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Human Ntokozo = new Human("Sihle", "Khumalo", "Black", 25);

            Ntokozo.IntroduceYourself();


            Box box = new Box();

            box.height = 5;
            box.Length = 10;

            Console.WriteLine(box.FrontSurFace);


            Console.Read();
            */
            /*----------------------------------------------------------
            string[] friends = {"Cleo", "Ncedo", "Nkosi", "Harvey", "Rama" };

            foreach (string friend in friends)
            {
                Console.WriteLine($"Hi {friend}, my friend");
            }


            do
            {

            } while (true);
            */
            /*----------------------------------------------------------
            int[,] array2D = new int[,]
            {
                { 1, 2, 3},
                //{ 4, 5, 6},
                //{ 7, 8, 9}
            };

            Console.WriteLine($"bottom left is {array2D[2,0]}");
            //Console.Read();


            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Food", "Money"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Swag", "Hoes"}
                }
            };


            Console.WriteLine($"bottom left is {array3D[0, 2, 0]}");
            //Console.Read();

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"Three", "four"},
                {"five", "six" }
            };


            array2DString[1, 1] = "Chicken";

            Console.WriteLine($"Column 1 and Row 1 has been changed to {array2DString[1, 1]}");
           //Console.Read();


            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        Console.Write(array2D[i, j] + " ");
                    }
                    
                }
            }
            */

            /*----------------------------------------------------------
            string[,] array2DString = new string[,]
            {
                { "one", "two" }, 
                {"Three", "four"},
                {"five", "six" }
            };


            string[][,] Friends = new string[][,]
            {
                new string[,] { { "Ncedo", "Bhudiza", "Nosipho" }, { "Ncedo", "Bhudiza", "Nosipho" } },
                //new string[,] { "Nkosi", "Sis", "Bhethina" },
                //new string[,] { "CLive", "Mathabo", "Manti"},
                array2DString
            };


            Console.WriteLine(Friends[0][0,1]+ " " + Friends[1][1, 1]);
            */
            /*----------------------------------------------------------
            int[] Happiness = new int[5]
            {
                5, 4, 3, 2, 1
            };

            IncreaseHappiness(Happiness);

            foreach (int i in Happiness)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */


            /*----------------------------------------------------------
            int _num = MinNumber(17, 12, 14, 6, 2, 123);

            Console.WriteLine(_num);

            */
            /*----------------------------------------------------------
             var numbers = new List<int>();
             for (int allnumbers = 100; allnumbers <= 170; allnumbers += 2)
             {
                 Console.Write(allnumbers + " ");
                 numbers.Add(allnumbers);    
             }
            */

            /*-------------------------------------------------------------------------------
            Dictionary<int, string> numbers = new Dictionary<int, string>();

            numbers.Add(0, "zero");
            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");

            int i = 0;

            if (numbers.ContainsKey(i))
            {
                
            }

            */
            /*------------------------------------------------------------------------------------

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numbersStack = new Stack<int>();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersStack.Push(numbers[i]);
                Console.WriteLine($"the following has been added to the stack{numbersStack.Peek()}");

            }

            int j = 0;
            while (numbersStack.Count > 0)
            {

                numbers[j] = numbersStack.Peek();
                
                Console.WriteLine($"The next top number is {numbers[j]}");

                Console.WriteLine($"{numbersStack.Pop()} is about to be popes");  
                j++;
            }
            
            */


            VideoPost myVideoPost = new VideoPost("THis is a new video", "Ntokozo Khumalo", "https//Newvideo.com", true, 40);

            Console.WriteLine( myVideoPost.ToString());

            myVideoPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            myVideoPost.Stop();

            Console.ReadLine();





        }

        /*----------------------------------------------------
        class Student
         {
             public int Id { get; set; }
             public string Name { get; set; }
             public float GPA { get; set; }

             public Student (int Id, string Name, float GPA)
             {
                 this.Id = Id;
                 this.Name = Name;
                 this. GPA = GPA;

             }
         }
        */



         /*----------------------------------------------------------
         static int MinNumber(params int[] numbers)
         {
             int num = numbers[0];

             foreach (int number in numbers)
             {
                 if (number < num)
                 {
                     num = number;
                 }
             }
             return num;
         }

         */

            /*----------------------------------------------------------
            static void IncreaseHappiness(int[] _Happiness)
            {
                int size = _Happiness.Length;

                for (int i = 0; i < size; i++)
                {
                    _Happiness[i] += 2;
                }


            }
            */
            //----------------------------------------------------------

        }
    }
