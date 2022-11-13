using System;
using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{

    public static class Tweening<TTipo>
    {
        public async static Task Tween(Action<TTipo> Actualizar, ICamino<TTipo> camino, TTipo inicio, TTipo final, ICurva curva, IReloj reloj)
        {
            TTipo valorActual;

            foreach (float tiempo in reloj.Tiempo())
            {
                float valorNormalizado = reloj.NormalizarTiempo(tiempo);
                float interpolador = curva.Interpolar(valorNormalizado);
                valorActual = camino.Evaluar(inicio, final, interpolador);
                Actualizar.Invoke(valorActual);
                await Task.Yield();
            }

            Actualizar.Invoke(final);
        }
    }
}
