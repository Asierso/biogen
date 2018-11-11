using System;
using System.Text;
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
        string Xpos,Ypos,url,auth,bioR;
        
        Xpos = topenRead.ReadLine();
        Ypos = topenRead.ReadLine();
        url = topenRead.ReadLine();
        auth = topenRead.ReadLine();
        bioR = topenRead.ReadLine();
        Console.WriteLine(topen);

        int DwX = Convert.ToInt16(Xpos);
        int DwY = Convert.ToInt16(Ypos);
         if(Xpos.Length <= 0 || Ypos.Length <= 0 || bioR.Length <=0 || DwX <= 0 || DwY <= 0)
        {
            Console.WriteLine("Parametro no permitido");
        }
         
        Console.WriteLine(Xpos + " " + Ypos + " " + url + " " + auth + " In BioReadVer: " + bioR);
        Console.ReadLine();
        
        
    }

    }
}