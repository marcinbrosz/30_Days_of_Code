using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Days_of_Code
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge >= 0)
                age = initialAge;
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }

        }
        public void amIOld()
        {
            if (age < 13)
                Console.WriteLine("You are young.");
            else if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
            
        }

        public void yearPasses()
        {
            age++;
        }
    }
    public class BetweenExtensions
    { 
        public static bool beetween<T>(T value, T min, T max) where T:IComparable<T>
        {
            return min.CompareTo(value) <= 1 && max.CompareTo(value) >= 1;
        }
    }



    class Program
    {
        static int Operators(double cost, int tips, int tax)
        {
            return (int)Math.Round(cost+cost * (tips / 100.0) + cost * (tax / 100.0));
        }

        static string Intro_to_Conditional_Statements(int n)
        {
            //return n%2==0 ? "Not Weird" : (BetweenExtensions.beetween(n,2,5)||n>20 ? "Not Weird":"Weird" );

            return n % 2 > 0 ? "Weird" : BetweenExtensions.beetween(n, 2, 5) || n > 20 ? "Not Weird" : "Weird";
        }
        static void LetReview(string[] s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine( string.Join("", s[i].Select(x => x).Where((y,j)=>j%2==0))
                    +" "+string.Join("", s[i].Select(x => x).Where((y, j) => j % 2 != 0)));
            }
        }

        static public void Loops(int n)
        {
            for (int i = 1; i <= 10; i++)
                //Console.WriteLine(n + " x " + i + " = " + (n * i));
                Console.WriteLine("{0:} x {1:} = {2:}", n, i, (n * i));
        }
        static void Arrays(int[] arr)
        {
            string res = string.Empty;
            for(int i = arr.Length-1; i >=0 ; i--)
            {
                res += arr[i]+" ";
            }

            Console.WriteLine(res.Trim());
        }

        static int factorial(int n)
        {
            return n>0?n * (factorial(n - 1)):1;
        }
        static void hourglasses_withList(int[][] arr)
        {
            int sum = 0;
            int max = 0;
            //remeber hourglasses but was not required in the task
            List<int> res_temp = new List<int>();
            List<int> res_max = new List<int>();

            for (int i = 0; i + 2 < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    count++;
                    if (count <= 3)
                    {
                        if (count == 1 || count == 3)
                        {
                            res_temp.Add(arr[i][j]);
                            res_temp.Add(arr[i + 2][ j]);
                            sum += arr[i][j] + arr[i + 2][j];
                        }
                        else if (count == 2)
                        {
                            sum += arr[i][j] + arr[i + 1][j] + arr[i + 2][j];
                            res_temp.Add(arr[i][ j]);
                            res_temp.Add(arr[i + 1][ j]);
                            res_temp.Add(arr[i + 2][ j]);

                        }

                    }
                    if (count == 3)
                    {
                        j = j - 2;
                        count = 0;
                        if (max < sum)
                        {
                            res_max.Clear();
                            res_max.AddRange(res_temp);
                            max = sum;

                        }
                        res_temp.Clear();
                        sum = 0;
                        if (j + 2 >= arr[i].Length - 1)
                            break;
                    }
                }
            }

            Console.WriteLine("{0} {1} {2}\n  {3}\n{4} {5} {6}", res_max[0], res_max[2]
            , res_max[5], res_max[3], res_max[1], res_max[4], res_max[6]);


        }
        static void hourglasses(int[][] arr)
        {
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i+2 < arr.Length; i++)
            {
                int count = 0;

                for(int j = 0; j < arr[i].Length; j++)
                {
                    count++;
                    if (count <= 3)
                        if (count == 1 || count == 3)
                            sum += arr[i][ j] + arr[i + 2][ j];
                        else if (count == 2) 
                            sum += arr[i][ j] + arr[i + 1][ j] + arr[i + 2][ j];
                    if(count==3)
                    {
                        
                        j = j - 2;
                        count = 0;
                        max =  max<sum?sum:max;
                        sum = 0;
                        if (j + 2 >= arr[i].Length-1)
                            break;
                    }
                }
            }

            Console.WriteLine(max);

        }
        static int BinaryNumbers(int n)
        {
            //bool check = false;
            //List<int> res = new List<int>() ;
            //while (n>0)
            //{
            //    if (n % 2 == 1)
            //    {
            //        if (!check)
            //            res.Add(0);

            //        res[res.Count-1]++;
            //        check = true;
            //    }
            //    else
            //        check = false;

            //    n = n / 2;
            //}
            //return res.Max();

            int max = 0;
            int couter = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                    couter++;
                else
                    couter = 0;

                max = max < couter ? couter : max;
                n = n / 2;

            }
            return max;
            
        }

        //Inheritance 


        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }

            public virtual void printtest()
            {
                Console.WriteLine("Test Person");
            }
        }

        class Student : Person
        {
            private int[] testScores;

            public override void printtest()
            {
                base.printtest();
               
            }

            /*	
            *   Class Constructor
            *   
            *   Parameters: 
            *   firstName - A string denoting the Person's first name.
            *   lastName - A string denoting the Person's last name.
            *   id - An integer denoting the Person's ID number.
            *   scores - An array of integers denoting the Person's test scores.
            */
            // Write your constructor here
            public Student(string firsName, string lastName, int id, int[] scores):base(firsName, lastName,id)
            {
                    //this.firstName = firsName;
                    //this.lastName = lastName;
                    //this.id = id;

                    testScores = scores;
            }
            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
            public char Calculate()
            {
                    double average = testScores.Select(x => x).Sum()/testScores.Count();
                    if (average < 40)
                        return 'T';
                    else if (average >= 40 && average < 55)
                        return 'D';
                    else if (average >= 55 && average < 70)
                        return 'P';
                    else if (average >= 70 && average < 80)
                        return 'A';
                    else if (average >= 80 && average < 90)
                        return 'E';
                    else if (average >= 90 && average <= 100)
                        return 'O';


                    return '\0';
            }
        }

        //
        //abstract//

        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }
    
        class MyBook : Book
        {
            int priceOrg;
            public MyBook(string title,string author, int price) : base(title,author)
            {
                priceOrg = price;
            }
            public override void display()
            {
                Console.WriteLine("Title: {0:}\nAuthor: {1:}\nPrice: {2:}",this.title,this.author,priceOrg);     
            }
        }
        //scope
        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            public Difference(int[] elements)
            {
                this.elements = elements;
            }

            public void computeDifference()
            {

                //with linq
                //maximumDifference =Enumerable.Range(0, elements.Count() - 2)
                //    .Select(i => Enumerable.Range(i+1, elements.Count()-1-i)
                //        .Select(j => Math.Abs(elements[i] - elements[j])).Max()).Max();
                //with sort
                Array.Sort(elements);
                
                maximumDifference = Math.Abs(elements.Max()-elements.Min());
                //with for
                //for(int i = 0; i < elements.Count() - 1; i++)
                //{
                //    for(int j = i+1; j < elements.Count(); j++)
                //    {
                //        int abs = Math.Abs(elements[i] - elements[j]);
                //        maximumDifference =abs>maximumDifference?abs: maximumDifference;
                //    }
                //}
            }
        }
        //scope
        //linked list
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }

        public static Node insert(Node head, int data)
        {
            if (head == null)
                return new Node(data);
            else
            {
                Node end = head;
                Node end2 = null;
                while (end != null)
                {
                    end2 = end;
                    end = end.next;
     
                }

                end.next = new Node(data);
                return head;
            }


        }
        
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        //linked list

        //Day 17: More Exceptions
        class Calculator
        {
            public int power(int n, int p)
            {
                if (n < 0 || p < 0)
                    throw new Exception("n and p should be non-negative");

                return (int)Math.Pow(n, p);
            }
        }
        //Day 17: More Exceptionss
        //Day 18: Queues and Stacks
        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();
        void pushCharacter(char ch)
        {
            stack.Push(ch);
            
        }

        void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }

        char popCharacter()
        {
            return stack.Pop();
        }
        char dequeueCharacter()
        {
            return queue.Dequeue();
        }
        //Day 18: Queues and Stacks
        static void Main(string[] args)
        {
            //double mealCost = 0.0;
            //int tipPercent = 0;
            //int taxPercent = 0;



            //mealCost = Convert.ToDouble(Console.ReadLine());
            //tipPercent = Convert.ToInt32(Console.ReadLine());
            //taxPercent = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( Operators(12, 20, 8));
            //for Loops
            //int n = 2;
            //Loops(n);
            //for LetReview
            //int n = 0;
            //n = Convert.ToInt32( Console.ReadLine());
            //string[] s = new string[n];
            //for(int i = 0; i < n; i++)
            //{
            //    s[i] = Console.ReadLine();
            //}
            //LetReview(s);
            //for arrays
            //int[] arr = new int[4] { 1, 4, 3, 2 };
            //Arrays(arr);


            //for dictonary
            //int n = 0;
            //string temp = string.Empty;
            //n = Convert.ToInt32(Console.ReadLine());
            //Dictionary<string, int> map = new Dictionary<string, int>();

            //for (int i = 0; i < n; i++)
            //{
            //    temp = Console.ReadLine();
            //    map.Add(temp.Split(' ')[0], Convert.ToInt32(temp.Split(' ')[1]));
            //}
            //temp = Console.ReadLine();

            //while (!string.IsNullOrEmpty(temp))
            //{
            //    if (map.ContainsKey(temp))
            //        Console.WriteLine("{0}={1}", temp, map[temp]);
            //    else
            //        Console.WriteLine("Not found");

            //    temp = Console.ReadLine();
            //}

            //for factorial
            //Console.WriteLine(factorial(5));


            //for BinaryNumbers
            //Console.WriteLine(BinaryNumbers(524275));
            //for hourglasses





            //hourgalsses
            //double[][] ServicePoint = new double[10][];
            //int[][] arr = {  new int[]{-1, - 1, 0 ,- 9, - 2, - 2 },  new int[]{  - 2, - 1 ,- 6, - 8, - 2, - 5 }, new int[]{  - 1, - 1, - 1 ,- 2, - 3, - 4 }
            //   , new int[]{  - 1, - 9 ,- 2, - 4, - 4, - 5 }, new int[]{  - 7 ,- 3, - 3, - 2, - 9 ,- 9 } ,new int[]{  - 1 ,- 3, - 1, - 2, - 4, - 5 } };

            //hourglasses(arr);



            //for inherince
            //string[] inputs = Console.ReadLine().Split();
            //string firstName = inputs[0];
            //string lastName = inputs[1];
            //int id = Convert.ToInt32(inputs[2]);
            //int numScores = Convert.ToInt32(Console.ReadLine());
            //inputs = Console.ReadLine().Split();
            //int[] scores = new int[numScores];
            //for (int i = 0; i < numScores; i++)
            //{
            //    scores[i] = Convert.ToInt32(inputs[i]);
            //}

            //Student s = new Student(firstName, lastName, id, scores);
            //s.printPerson();
            //Console.WriteLine("Grade: " + s.Calculate() + "\n");

            //for abstract
            //String title = Console.ReadLine();
            //String author = Console.ReadLine();
            //int price = Int32.Parse(Console.ReadLine());
            //Book new_novel = new MyBook(title, author, price);
            //new_novel.display();


            //for scope
            //Convert.ToInt32(Console.ReadLine());

            //int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //Difference d = new Difference(a);

            //d.computeDifference();

            //Console.Write(d.maximumDifference);

            //for linked list

            //Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = insert(head, data);
            //}
            //display(head);
            //
            //

            //Day 16: Exceptions 
            //string s = "asd";
            //int i;
            //try
            //{
            //    i = Int32.Parse(s);
            //    Console.WriteLine(i);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Bad String");
            //}
            //finally
            //{
            //    Console.WriteLine("end catch");
            //}

            //Day 17: More Exceptions
            //Calculator myCalculator = new Calculator();
            //try
            //{
            //    int ans = myCalculator.power(0, 5);
            //    Console.WriteLine(ans);

            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Day 18
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
            Console.Read();
        }
    }
}
