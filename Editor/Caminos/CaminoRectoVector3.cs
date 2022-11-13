using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class CaminoRectoVector3 : Camino<Vector3>
    {
        public override Vector3 Evaluar(Vector3 inicio, Vector3 final, float interpolador)
        {
            return Vector3.Lerp(inicio, final, interpolador);
        }
    }
}