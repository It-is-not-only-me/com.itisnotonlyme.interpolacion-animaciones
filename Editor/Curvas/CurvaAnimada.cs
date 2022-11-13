using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class CurvaAnimada : Curva
    {
        private AnimationCurve _curvaDeAnimacion;

        public CurvaAnimada(AnimationCurve curvaDeAnimacion)
        {
            _curvaDeAnimacion = curvaDeAnimacion;
        }

        public override float Interpolar(float valor)
        {
            return _curvaDeAnimacion.Evaluate(valor);
        }
    }
}