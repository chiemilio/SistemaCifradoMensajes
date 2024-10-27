using System;
using System.Text;
namespace SistemaCifradoMensajes;

public class CifradoPorDesplazamiento : CifradoBasico
{
    public int Desplazamiento { get; set; }
    public CifradoPorDesplazamiento(string MensajeOriginal):base(MensajeOriginal)
    {
        this.Desplazamiento = 0;
    }

    public override void Cifrar()
    {
        StringBuilder resultado = new StringBuilder();
        foreach (char c in getMensajeOriginal())
        {
            if (char.IsLetter(c))
            {
                char d = (char)(c + this.Desplazamiento);
                if (char.IsLower(c) && d >= 'z' || char.IsUpper(c) && d >= 'Z')
                {
                    d = (char)(d - 25);
                }
                setMensajeOriginal(resultado.Append(d).ToString());
            }
            else
            {
                resultado.Append(c);
            }
        }
         resultado.ToString();
    }

    public override void Descifrar()
    {
        StringBuilder resultado = new StringBuilder();
        foreach (char c in getMensajeOriginal())
        {
            if (char.IsLetter(c))
            {
                char d = (char)(c - this.Desplazamiento);
                if (char.IsLower(c) && d <= 'a' || char.IsUpper(c) && d <= 'A')
                {
                    d = (char)(d + 25);
                }
                setMensajeOriginal(resultado.Append(d).ToString());
            }
            else
            {
                setMensajeOriginal(resultado.Append(c).ToString());
            }
        }
         resultado.ToString();
    }

    public int getDesplazamiento()
    {
        return this.Desplazamiento;
    }
    public int setDesplazamiento(int des)
    {
        return this.Desplazamiento = des;
    }
}
