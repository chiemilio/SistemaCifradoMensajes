
using SistemaCifradoMensajes;

public class Program
    {
        public static void Main(string[] args)
        {
            //CifradoBasico cifradoBasico= new CifradoBasico("cualquier mensaje"); 
            //cifradoBasico.Cifrar(); 
           // cifradoBasico.Cifrar(3); 
            //Console.WriteLine(cifradoBasico.getMensajeOriginal()); 
            //cifradoBasico.Descifrar();
            //Console.WriteLine(cifradoBasico.getMensajeOriginal()); 
            //CifradoPorDesplazamiento cifradoPorDesplazamiento= new CifradoPorDesplazamiento("Emilio chi Garcia Zapato dedo ");
            //cifradoPorDesplazamiento.setDesplazamiento(2);
            //cifradoPorDesplazamiento.Cifrar();
            //Console.WriteLine(cifradoPorDesplazamiento.getMensajeOriginal());
            //Console.WriteLine(cifradoPorDesplazamiento.getDesplazamiento()); 
            //Console.WriteLine(cifradoPorDesplazamiento.getMensajeOriginal());
            //Console.WriteLine(cifradoPorDesplazamiento.getDesplazamiento()); 
            //cifradoPorDesplazamiento.setDesplazamiento(2);
            //cifradoPorDesplazamiento.Descifrar();
            //Console.WriteLine(cifradoPorDesplazamiento.getMensajeOriginal());
            //CifradoAES cifradoAES= new CifradoAES("emilio chi garcia");
            //cifradoAES.setClave("xxxxxxxxxxxxxxxx");
            /*cifradoAES.Cifrar();
            Console.WriteLine("encriptado del programa "+cifradoAES.getMensajeOriginal());
            //cifradoAES.setClave("xxxxxxxxxxxxxxxx");
            cifradoAES.Descifrar();
            Console.WriteLine("encriptado del programa "+cifradoAES.getMensajeOriginal());
            */
            /*CifradoDoble cifradoDoble= new CifradoDoble("emilio chi garcia");
            cifradoDoble.setClaveSecundaria("xxxxxxxxxxxxxxxx");
            cifradoDoble.Cifrar();
            Console.WriteLine(cifradoDoble.getMensajeOriginal());
            cifradoDoble.Descifrar();
            Console.WriteLine(cifradoDoble.getMensajeOriginal());
            */
            MenuInteractivo menuInteractivo= new MenuInteractivo();
            menuInteractivo.Menu();

        }

    }

