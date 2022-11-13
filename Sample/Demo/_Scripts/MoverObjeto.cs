using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.Tweening;
using System.Threading.Tasks;

public class MoverObjeto : MonoBehaviour
{
    [SerializeField] private Camino<Vector3> _camino;
    [SerializeField] private Camino<Quaternion> _rotacion;
    [SerializeField] private Curva _curva;
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

        Task[] transiciones = new Task[2];

        transiciones[0] = Tweening<Vector3>.Tween((valorNuevo) => transform.position = valorNuevo, _camino, transform.position, _posicionFinal, _curva, _timer);
        transiciones[1] = Tweening<Quaternion>.Tween((valorNuevo) => transform.rotation = valorNuevo, _rotacion, transform.rotation, _rotacionFinal, _curva, _timer);

        await Task.WhenAll(transiciones);
    }
}
