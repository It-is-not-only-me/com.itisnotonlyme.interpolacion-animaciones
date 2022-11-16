using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class CaminoRectoQuaternion : Camino<Quaternion>
    {
        public override Quaternion Evaluar(Quaternion inicio, Quaternion final, float interpolador)
        {
            return Quaternion.Slerp(inicio, final, interpolador);
        }
    }
}