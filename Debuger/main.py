from tkinter import *
import os
root = Tk()
#source-code r/w/a


def entr():
    Startfile = open("run.ini","w")
    ns = nn.get()
    
    Startfile.write(ns)
    Startfile.close()
    root2 = Tk()
    lbl1 = Label(root2,text="cargando...")
    lbl1.place(x=50,y=50)
    root2.title("Cargando")
    os.system("debuger.exe")
    root2.mainloop()


    #defines root
lbl = Label(root,text="Debug") 
lbl.place(x=75,y=5)
nn = Entry(root)
nn.place(x=30,y=35)
btn = Button(root,text="Emular",command=entr) 
btn.place(x=75,y=65)
root.title("Probar BioApp")
root.mainloop()
