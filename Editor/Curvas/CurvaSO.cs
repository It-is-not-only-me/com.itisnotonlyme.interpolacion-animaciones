using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public abstract class CurvaSO : ScriptableObject, ICurva
    {
        public abstract float Interpolar(float valor);
    }
}
