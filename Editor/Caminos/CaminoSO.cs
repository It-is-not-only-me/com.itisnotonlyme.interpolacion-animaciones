using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public abstract class CaminoSO<TTipo> : ScriptableObject, ICamino<TTipo>
    {
        public abstract TTipo Evaluar(TTipo inicio, TTipo final, float interpolador);
    }
}
