using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public abstract class Camino<TTipo> : ICamino<TTipo>
    {
        public abstract TTipo Evaluar(TTipo inicio, TTipo final, float interpolador);
    }
}
