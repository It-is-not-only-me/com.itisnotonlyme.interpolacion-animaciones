namespace ItIsNotOnlyMe.Tweening
{
    public interface ICamino<TTipo>
    {
        public TTipo Evaluar(TTipo inicio, TTipo final, float interpolador);
    }
}
