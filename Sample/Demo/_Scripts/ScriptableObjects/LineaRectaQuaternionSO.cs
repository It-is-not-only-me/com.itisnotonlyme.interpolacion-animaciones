using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    [CreateAssetMenu(fileName = "Linea recta quaternion", menuName = "Caminos/Linea recta/Quaternion")]
    public class LineaRectaQuaternionSO : ScriptableObject, ICamino<Quaternion>
    {
        public Quaternion Evaluar(Quaternion inicio, Quaternion final, float interpolador)
        {
            return Quaternion.Slerp(inicio, final, interpolador);
        }
    }
}
