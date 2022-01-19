using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number1();
            // Number2();
            Number3();

            // var table = new Hashtable();
            //
            // var text = "babade";
            //
            // foreach (var c in text)
            // {
            //     if (table.ContainsKey(c)) table[c] = (int)table[c] + 1;
            //     else table.Add(c, 1);
            // }
            //
            // var oddCount = 0;
            // var isValid = true;
            //
            // foreach (DictionaryEntry entry in table)
            // {
            //     if ((int)entry.Value % 2 == 0) continue;
            //     oddCount++;
            //
            //     if (oddCount <= 1) continue;
            //     isValid = false;
            //     break;
            // }
            //
            // Console.WriteLine(isValid ? "This string can form palindrome" : "This string cannot form palindrome");


            // var  students = new List<Student>();
            // var teachers = new List<Teacher>();
            //
            // Student student = new Student("Ola", "olu", "Ila", "1234");
            //
            // Teacher teacher = new Teacher("Ola", "olu", "Ila", "1234");
            //
            // var condition = student is Person;
            //
            // Console.WriteLine(condition);
        }

        static void Number1()
        {
            var stack = new Stack();

            var text = "([({}())]))";

            var isValid = true;

            foreach (var c in text)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }

                    var top = stack.Pop();

                    if (c == ')' && (char)top != '(' || c == ']' && (char)top != '[' || c == '}' && (char)top != '{')
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isValid && stack.Count == 0
                ? "This string contains valid parentheses "
                : "This string does not contain valid parentheses");
        }

        static void Number2() 
        {
            var hashtable = new Hashtable();

            var values = new int[] { 1, 2, 3 };
            var isValid = false;

            foreach (var value in values)
            {
                if (hashtable.ContainsKey(value))
                {
                    isValid = true;
                    break;
                }

                hashtable.Add(value, 1);
            }

            Console.WriteLine(isValid
                ? "This array contains duplicate values"
                : "This array does not contain duplicate values");
        }

        static void Number3()
        {
            Hashtable hashtable = new Hashtable();

            var list1 = new string[] { "HH", "Tapioca Express", "Burger King", "KFC" };
            var list2 = new string[] { "HH","KFC", "Shogun", "Burger King" };

            var isValid = true;

            // var commons = new List<string>();
            // int smallest2 = int.MaxValue;
            //
            // foreach (var item in list1)
            // {
            //     if (list2.Contains(item))
            //     {
            //         if(Array.IndexOf(list1, item) + Array.IndexOf(list2, item) < smallest2)
            //         {
            //             smallest2 = Array.IndexOf(list1, item) + Array.IndexOf(list2, item);
            //             commons.Clear();
            //             commons.Add(item);
            //         }
            //         else if(Array.IndexOf(list1, item) + Array.IndexOf(list2, item) == smallest2)
            //         {
            //             commons.Add(item);
            //         }
            //     } 
            // }

            for (var i = 0; i < list1.Length; i++)
            {
                hashtable.Add(list1[i], i * -1 -1);
            }

            for (var i = 0; i < list2.Length; i++)
            {
                if (hashtable.Contains(list2[i]))
                {
                    hashtable[list2[i]] = Math.Abs((int)hashtable[list2[i]] + i * -1 +1);
                }
                else
                {
                    hashtable.Add(list2[i], i * -1);
                }
            }
            
            string commonEatery = null;
            int smallest = int.MaxValue;
            
            foreach (DictionaryEntry entry in hashtable)
            {
                var value = (int)entry.Value;
                
                if(value >= 0 && value < smallest)
                {
                    smallest = value;
                    commonEatery = entry.Key.ToString();
                }
            }
            
            Console.WriteLine(commonEatery==null ? "They don't have common eatery" : "The common eatery is " + commonEatery);
        }
    }
}