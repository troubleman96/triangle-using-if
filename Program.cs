using System;

class Program{

    static void Main(string [] args){
        int i = 1;
        while  (i <= 5){
            int j = 1;
            while( j <= i){
                System.Console.Write("*");
                j++;
            }
            System.Console.WriteLine();
            i++;
        }
    }
}