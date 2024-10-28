namespace SistemaCifradoMensajes;

public class CifradoDoble : CifradoAES
{
    public string ClaveSecundaria { get; set; }
    public CifradoDoble(string MensajeOriginal) : base(MensajeOriginal)
    {
        this.ClaveSecundaria = "";
    }
    public override void Cifrar()
    {
        string mensajePrimario = base.getMensajeOriginal();
        setClave(ClaveSecundaria);
        setMensajeOriginal(mensajePrimario);
        base.Cifrar();
    }

    public override void Descifrar()
    {
        setClave(ClaveSecundaria);  
        string mensajeSecundario = base.getMensajeOriginal();  
        setMensajeOriginal( mensajeSecundario);
        base.Descifrar(); 
    }

    public string getClaveSecundaria()
    {
        return this.ClaveSecundaria;
    }
    public string setClaveSecundaria(string me)
    {
        return this.ClaveSecundaria = me;
    }

}
