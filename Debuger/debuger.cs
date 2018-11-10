using System;
using System.IO;
using System.Collections;
using System.Linq;
namespace debugers {
class debuger {

    public static void Main()
    {
        //Read STdata
        StreamReader strr = new StreamReader("run.ini");
        string topen = strr.ReadLine();
        StreamReader topenRead = new StreamReader(topen);
        
        //Codigo del interprete
        string Xpos,Ypos;
        string url,auth;
        Xpos = topenRead.ReadLine();
        Ypos = topenRead.ReadLine();
        url = topenRead.ReadLine();
        auth = topenRead.ReadLine();
        Console.WriteLine(topen);
         if((Xpos.Length <= 0) || (Ypos.Length <= 0))
        {
            Console.WriteLine("Parametro no permitido");
        }
         
        Console.WriteLine(Xpos + " " + Ypos + " " + url + " " + auth);
        Console.ReadLine();
        
        
    }

    }
}