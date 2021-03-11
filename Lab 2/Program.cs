using System;
using System.Collections;
namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*try
            {
                int[] array = new int[5];
                array[5] = 5;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out of Bounds");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int x = 0;
                int y = (90 / x);
                Console.WriteLine(y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Why dividing by zero!!! What is this behaviour?");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            finally
            {
                
                Console.WriteLine("DONT EVER DIVIDE A NUMBER BY 0. THE MATH NERDS WILL EAT YOU UP!!!");
            }*/
            /*Stack stack = new Stack();
            int[] array = new[] {1, 2, 3, 4, 5};
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                stack.Push(array[i]);
            }
            Console.WriteLine("******STACK*********");
            for (int i = stack.Count; i >0; i--)
            {
                Console.WriteLine("Count : " + stack.Count);
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("******STACK*********");
            Console.WriteLine("******QUEUE*********");
            Queue queue = new Queue();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                queue.Enqueue(array[i]);
            }
            for (int i = queue.Count; i >0; i--)
            {
                Console.WriteLine("Count : " + queue.Count);
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("******QUEUE*********");*/
            //Console.WriteLine(Convert.ToInt32(Seasons.Autumn));
            var reg1 = new MyBlablabla();
            reg1.Session = Session.FA;
            reg1.Course = Course.BSE;
            reg1.year = 18;
            reg1.rollno = "015";
            Console.WriteLine(reg1.print());
        }

        private enum Seasons
        {
            Spring,
            Summer,
            Winter,
            Autumn
        }

        private enum Session
        {
            FA,
            SP
        }

        private enum Course
        {
            BSE,
            BCS,
            BEE
        }

        private struct MyBlablabla
        {
            public Session Session;
            public Course Course;
            public int year;
            public string rollno;

            public string print()
            {
                return Session + year.ToString() + "-" + Course + "-" + rollno;
            }
            
        }
            
        }
        
    }