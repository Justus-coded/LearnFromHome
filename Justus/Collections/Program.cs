using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Non -generic collection include
            Array list
            Stack
            Queue
            Hash Table
            
            */
            
            // Array List
            public ArrayList myArrList = new ArrayList();

            public void myArrList(){

                myArrList.Add("Justus");
                myArrList.Add("32");
                myArrList.Add("2.3")
            }
            public ArrayList getList(){
                return myArrList;
            }

            /*Stack
            
            First In, Last Out
            The pop method removes and returns the top value
            The puch method add the value to the Stack
            */
            public Stack myStack = new Stack();

            public void addmyStack(){

                    myStack.Push("Justus");
                    myStack.Push(34);

            }
            public object getmyStack(){
                return myStack;
            }

            public string RemoveVal(){
                return myStack.pop();
            }

        }
    }
}
