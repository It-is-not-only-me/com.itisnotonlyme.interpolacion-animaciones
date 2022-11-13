using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    [CreateAssetMenu(fileName = "Linea recta quaternion", menuName = "Caminos/Linea recta/Quaternion")]
    public class LineaRectaQuaternion : CaminoSO<Quaternion>
    {
        public override Quaternion Evaluar(Quaternion inicio, Quaternion final, float interpolador)
        {
            return Quaternion.Slerp(inicio, final, interpolador);
        }
    }
}
