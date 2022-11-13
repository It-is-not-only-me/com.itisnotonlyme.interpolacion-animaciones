using System.Collections;
using UnityEngine;

namespace ItIsNotOnlyMe.Tweening
{
    public class Timer : IReloj
    {
        private const float _tiempoMinimo = 0, _tiempoMaximo = 1;

        private float _tiempoTotal, _deltaTime;

        public Timer(float tiempoTotal, float deltaTiempo)
        {
            _tiempoTotal = tiempoTotal;
            _deltaTime = deltaTiempo;
        }

        public float NormalizarTiempo(float tiempo) => Mathf.Clamp(tiempo / _tiempoTotal, _tiempoMinimo, _tiempoMaximo);

        public IEnumerable Tiempo()
        {
            for (float tiempo = _tiempoMinimo; tiempo < _tiempoTotal; tiempo += _deltaTime)
                yield return tiempo;
        }
    }
}
