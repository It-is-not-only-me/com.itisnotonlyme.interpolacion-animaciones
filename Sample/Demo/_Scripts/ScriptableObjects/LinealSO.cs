using ItIsNotOnlyMe.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{

    [CreateAssetMenu(fileName = "Linea", menuName = "Curvas/Lineal")]
    public class LinealSO : ScriptableObject, ICurva
    {
        public float Interpolar(float valor)
        {
            return valor;
        }
    }
}
