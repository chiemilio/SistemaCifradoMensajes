namespace SistemaCifradoMensajes;

public class MenuInteractivo
{
    public MenuInteractivo()
    { }
    public void Menu()
    {
        int opcion = 4;
        while (opcion != 0)
        {
            Console.WriteLine("Selecciona el tipo de cifrado:");
            Console.WriteLine("1. Cifrado Básico y decifrado");
            Console.WriteLine("2. Cifrado por Desplazamiento y decifrado");
            Console.WriteLine("3. Cifrado AES y decifrado");
            Console.WriteLine("4. Cifrado Doble y decifrado");
            Console.WriteLine("0. Salir");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 0)
            {
                Console.WriteLine("Ingresa el mensaje:");
                string mensaje = Console.ReadLine();
                switch (opcion)
                {
                    case 1:
                        CifradoBasico cifradoBasico =new CifradoBasico(mensaje);
                        cifradoBasico.Cifrar();
                        Console.WriteLine(cifradoBasico.getMensajeOriginal());
                        cifradoBasico.Descifrar();
                        Console.WriteLine(cifradoBasico.getMensajeOriginal());
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el valor de desplazamiento (1-25):");
                        int desplazamiento = int.Parse(Console.ReadLine());
                        CifradoPorDesplazamiento cifradoPorDesplazamiento = new CifradoPorDesplazamiento(mensaje);
                        cifradoPorDesplazamiento.setDesplazamiento(desplazamiento);
                        cifradoPorDesplazamiento.Cifrar();
                        Console.WriteLine(cifradoPorDesplazamiento.getMensajeOriginal());
                        cifradoPorDesplazamiento.Descifrar();
                        cifradoPorDesplazamiento.Descifrar();
                        Console.WriteLine(cifradoPorDesplazamiento.getMensajeOriginal());

                        break;
                    case 3:
                        Console.WriteLine("Ingresa la clave (16 caracteres):");
                        string clave = Console.ReadLine();
                        CifradoAES cifradoAES = new CifradoAES(mensaje);
                        cifradoAES.setClave(clave);
                        cifradoAES.Cifrar();
                        Console.WriteLine(cifradoAES.getMensajeOriginal());
                        cifradoAES.Descifrar();
                        Console.WriteLine(cifradoAES.getMensajeOriginal());
                        break;
                    case 4:
                        Console.WriteLine("Ingresa la clave primaria (16 caracteres):");
                        string clave1 = Console.ReadLine();
                        Console.WriteLine("Ingresa la clave secundaria (16 caracteres):");
                        string clave2 = Console.ReadLine();
                        CifradoDoble cifradoDoble = new CifradoDoble(mensaje);
                        cifradoDoble.setClave(clave1);
                        cifradoDoble.setClaveSecundaria(clave2);
                        cifradoDoble.Cifrar();
                        Console.WriteLine(cifradoDoble.getMensajeOriginal());
                        cifradoDoble.Descifrar();
                        Console.WriteLine(cifradoDoble.getMensajeOriginal());
                        break;
                }              
            }
        }
    }
}
