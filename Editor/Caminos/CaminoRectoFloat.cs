using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class CaminoRectoFloat : Camino<float>
    {
        public override float Evaluar(float inicio, float final, float interpolador)
        {
            return Mathf.Lerp(inicio, final, interpolador);
        }
    }
}