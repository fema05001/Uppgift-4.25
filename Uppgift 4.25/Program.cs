using System;
namespace Uppgift_4_25
{
    class program
    {
        static void Main(string[] args)
        {
            
            while ( true)
            {
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programet");
                Console.WriteLine(" ");
                string svar = Console.ReadLine();
                
                

                    if (svar == "1")
                {
                    Console.WriteLine("sktiv in ett tal");
                    string y = Console.ReadLine();
                    Console.WriteLine("Skriv in ett tal till");
                    string c = Console.ReadLine();
                    int x = int.Parse(y);
                    int b = int.Parse(c);
                    int h = x - b;
                    Console.WriteLine(x + "-" + b + "=" + h);
                    
                }



                else if (svar == "2")
                {
                    Console.WriteLine("sktiv in ett tal");
                    string å = Console.ReadLine();
                    Console.WriteLine("Skriv in ett tal till");
                    string k = Console.ReadLine();
                    float g = float.Parse(å);
                    float m = float.Parse(k);
                    float l = g / m;
                    Console.WriteLine(g + "/" + m + "=" + l);
                }
                 else if (svar == "3")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Programet avslutas");
                    break;
                }
                    

                      
                    
                        
                    
                        





                
                        

                        



                
            }
            

        }
    }
}