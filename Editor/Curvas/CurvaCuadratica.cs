namespace ItIsNotOnlyMe.Tweening
{
    public class CurvaCuadratica : Curva
    {
        public override float Interpolar(float valor)
        {
            return valor * valor;
        }
    }
}