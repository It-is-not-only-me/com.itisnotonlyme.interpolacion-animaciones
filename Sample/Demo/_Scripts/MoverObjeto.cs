using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.Tweening;
using System.Threading.Tasks;

public class MoverObjeto : MonoBehaviour
{
    [SerializeField] private LineaRectaVector3SO _camino;
    [SerializeField] private LineaRectaQuaternionSO _rotacion;
    [SerializeField] private LinealSO _curva;
    [SerializeField] private float _tiempo = 1;

    [Space]

    [SerializeField] private Quaternion _rotacionFinal;
    [SerializeField] private Vector3 _posicionFinal;

    private IReloj _timer;

    [ContextMenu("Moverse")]
    private async void Moverse()
    {
        float deltaTiempo = Time.deltaTime;
        _timer = new Timer(_tiempo, deltaTiempo);

        IAdministrarTweens administrador = new TweenConcurrentes()
            .AgregarTween(new Transladar(ActualizarPosicion, _camino, transform.position, _posicionFinal, _curva, _timer))
            .AgregarTween(new Rotar(ActualizarRotacion, _rotacion, transform.rotation, _rotacionFinal, _curva, _timer));

        await administrador.DoTween();
    }

    private void ActualizarPosicion(Vector3 valorNuevo)
    {
        transform.position = valorNuevo;
    }

    private void ActualizarRotacion(Quaternion rotacionNueva)
    {
        transform.rotation = rotacionNueva;
    }
}
