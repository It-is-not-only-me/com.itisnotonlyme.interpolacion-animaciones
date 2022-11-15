using System;
using System.Threading.Tasks;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class Rotar : ITween
    {
        private Action<Quaternion> _actualizar;
        private ICamino<Quaternion> _camino;
        private Quaternion _inicio, _final;
        private ICurva _curva;
        private IReloj _reloj;

        public Rotar(Action<Quaternion> actualizar, ICamino<Quaternion> camino, Quaternion inicio, Quaternion final, ICurva curva, IReloj reloj)
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
            return Tweening<Quaternion>.Tween(_actualizar, _camino, _inicio, _final, _curva, _reloj);
        }
    }
}
