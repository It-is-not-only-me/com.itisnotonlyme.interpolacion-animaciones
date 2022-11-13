using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class CaminoRectoVector2 : Camino<Vector2>
    {
        public override Vector2 Evaluar(Vector2 inicio, Vector2 final, float interpolador)
        {
            return Vector2.Lerp(inicio, final, interpolador);
        }
    }
}