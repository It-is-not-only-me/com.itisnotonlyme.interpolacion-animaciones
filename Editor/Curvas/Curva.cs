using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public abstract class Curva : ICurva
    {
        public abstract float Interpolar(float valor);
    }
}
