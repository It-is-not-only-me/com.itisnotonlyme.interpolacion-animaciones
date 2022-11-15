using ItIsNotOnlyMe.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{

    [CreateAssetMenu(fileName = "Linea recta vector3", menuName = "Caminos/Linea recta/Vector3")]
    public class LineaRectaVector3SO : ScriptableObject, ICamino<Vector3>
    {
        public Vector3 Evaluar(Vector3 inicio, Vector3 final, float interpolador)
        {
            return Vector3.Lerp(inicio, final, interpolador);
        }
    }
}
