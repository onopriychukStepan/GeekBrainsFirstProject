using System;

namespace project{
    class Program{
        static void Main(){

            string[] stroki = new string[] {"Hello", "2", "world", ":-)", "MADE_BY_STEPAN_ONOPRIYCHUK"};
            string[] s = new string[8];

        for (byte i = 0; i < stroki.Length; i++){
            if(stroki[i].Length <= 3){
                s[i] = stroki[i]+s[i];
                System.Console.Write(s[i]);
                System.Console.Write(' ');
            }
            }
        }
        }
    
    }
