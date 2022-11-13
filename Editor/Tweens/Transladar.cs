using System;
using System.Threading.Tasks;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class Transladar : ITween
    {
        private Action<Vector3> _actualizar;
        private ICamino<Vector3> _camino;
        private Vector3 _inicio, _final;
        private ICurva _curva;
        private IReloj _reloj;

        public Transladar(Action<Vector3> actualizar, ICamino<Vector3> camino, Vector3 inicio, Vector3 final, ICurva curva, IReloj reloj)
        {
            _actualizar = actualizar;
            _camino = camino;
            _inicio = inicio;
            _final = final;
            _curva = curva;
            _reloj = reloj;
        }

        public Task DoTween()
        {
            return Tweening<Vector3>.Tween(_actualizar, _camino, _inicio, _final, _curva, _reloj);
        }
    }
}
