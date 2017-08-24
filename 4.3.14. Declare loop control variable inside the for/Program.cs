using System; 
 
class MainClass {   
  public static void Main() { 
    int sum = 0; 
    int fact = 1; 
 
    for(int i = 1; i <= 5; i++) {  
      sum += i;  // i is known throughout the loop 
      fact *= i; 
    } 
 
    // But, i is not known here. 
 
    Console.WriteLine("Sum is " + sum); 
    Console.WriteLine("Factorial is " + fact); 
  }   
}