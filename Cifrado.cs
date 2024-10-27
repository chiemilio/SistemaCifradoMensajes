using System;
namespace SistemaCifradoMensajes;

public class Cifrado
{
    // variables 
    private string MensajeOriginal { get; set; }
    //metodos para cifrar y desifrar 
    public Cifrado(string MensajeOriginal)
    { 
        this.MensajeOriginal = MensajeOriginal;
    }

    public virtual void Cifrar()
    {
        this.MensajeOriginal = ""; 
    }

    public virtual void Descifrar()
    {

    }
    // metodos set y get
    public string getMensajeOriginal()
    {
        return this.MensajeOriginal;
    } 

    public string setMensajeOriginal(string Mensaje)
    {
        return this.MensajeOriginal = Mensaje;
    }


}

