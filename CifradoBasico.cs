using System;
namespace SistemaCifradoMensajes;

public class CifradoBasico : Cifrado
{

    private string MensajeCopia;
    public CifradoBasico(string MensajeOriginal) : base(MensajeOriginal)
    {
        this.MensajeCopia = MensajeOriginal;
    }

    public override void Cifrar()
    {
        
        for (int i = 0; i < MensajeCopia.Length; i++)
        {

            if (this.MensajeCopia[i] == 'a' || this.MensajeCopia[i] == 'A')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'z');
            }
            else if (this.MensajeCopia[i] == 'e' || this.MensajeCopia[i] == 'E')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(MensajeCopia[i], 'x');
            }
            else if (this.MensajeCopia[i] == 'i' || this.MensajeCopia[i] == 'I')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'v');

            }
            else if (this.MensajeCopia[i] == 'o' || this.MensajeCopia[i] == 'O')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 't');
            }
            else if (this.MensajeCopia[i] == 'u' || MensajeCopia[i] == 'U')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'r');
            }
            else
            {
                setMensajeOriginal(MensajeCopia);
            } 
            setMensajeOriginal(MensajeCopia);
        }

    }
    public override void Descifrar()
    {
        
        for (int i = 0; i < MensajeCopia.Length; i++)
        {

            if (this.MensajeCopia[i] == 'z')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'a');
            }
            else if (this.MensajeCopia[i] == 'x' )
            {
                this.MensajeCopia = getMensajeOriginal().Replace(MensajeCopia[i], 'e');
            }
            else if (this.MensajeCopia[i] == 'v' )
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'i');

            }
            else if (this.MensajeCopia[i] == 't' )
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'o');
            }
            else if (this.MensajeCopia[i] == 'r')
            {
                this.MensajeCopia = getMensajeOriginal().Replace(this.MensajeCopia[i], 'u');
            }
            else
            {
                setMensajeOriginal(MensajeCopia);
            } 
            //setMensajeOriginal(MensajeCopia);
        }

        //Console.WriteLine(this.MensajeCopia);
        
    }

    public string Cifrar(int nivel)
    {
        
        for (int i = 0; i < nivel; i++)
        {
            this.Cifrar(); 
        }
        return this.MensajeCopia;
    }


}
