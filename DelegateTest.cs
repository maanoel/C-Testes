using System;

namespace HelloWorld
{
  class Program
  {
  	public delegate void SimpleDelegate();
    
    static void Main(string[] args)
    {
    	SimpleDelegate simpleDelegate = null;
        
    	simpleDelegate = new SimpleDelegate(MyFunction);
        simpleDelegate();
        
        simpleDelegate = new SimpleDelegate(MyFunctionTwo);
        simpleDelegate();
        
        simpleDelegate = new SimpleDelegate(MyFunctionThree);
        simpleDelegate();
    }
    
    static void MyFunction(){
    	Console.WriteLine("Hello my one function");
    }
    
    static void MyFunctionTwo(){
    	Console.WriteLine("Hello my two function");
    }
    
    static void MyFunctionThree(){
    	Console.WriteLine("Hello my three function");
    }
  }
}