using System;
using System.Threading.Tasks;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class Transladar : ITween
    {
        private static ICurva _curvaDefault = new CurvaLineal();
        private static IReloj _relojDefault = new Timer(1.0f, 0.01f);
        private static ICamino<Vector3> _caminoDefault = new CaminoRectoVector3();

        private Action<Vector3> _actualizar;
        private ICamino<Vector3> _camino;
        private Vector3 _inicio, _final;
        private ICurva _curva;
        private IReloj _reloj;

        public Transladar(Action<Vector3> actualizar, Vector3 inicio, Vector3 final, ICurva curva = null, IReloj reloj = null, ICamino<Vector3> camino = null)
        {
            _actualizar = actualizar;
            _inicio = inicio;
            _final = final;
            _curva = curva == null ? _curvaDefault : curva;
            _reloj = reloj == null ? _relojDefault : reloj;
            _camino = camino == null ? _caminoDefault : camino;
        }

        public Transladar(Action<Vector3> actualizar, Vector3 inicio, Vector3 final, float tiempo, float deltaTiempo, ICurva curva = null, ICamino<Vector3> camino = null)
            : this(actualizar, inicio, final, curva, new Timer(tiempo, deltaTiempo), camino)
        {
        }

        public Task DoTween()
        {
            return Tweening<Vector3>.Tween(_actualizar, _camino, _inicio, _final, _curva, _reloj);
        }
    }
}
