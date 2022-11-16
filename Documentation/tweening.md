# Documentacion
---

El sistema se basa en las 3 interfaces:
 * ICamino
 * ICurva 
 * IReloj

### ICamino<TTipo>
---
Se tiene que implementar la función 
```c#
public TTipo Evaluar(TTipo inicio, TTipo final, float interpolador);
```

Esta función representa la función matemática f:float -> TTipo, donde f(0) = inicio y f(1) = final.

### ICurva
---
Se tiene que implementar la función
```c#
public float Interpolar(float valor);
```

Es la función que representa la interpolación, es una función f:float -> float, donde f(0) = 0 y f(1) = 1. Donde recibe el input de IReloj y devuelve un valor para interpolar el camino.

### IReloj
---
Se tiene que implementar la función
```c#
public IEnumerable Tiempo();

public float NormalizarTiempo(float tiempo);
```

Donde Tiempo devuelve una float para cada vez que se llama a la función, representa el tiempo que pasa entre paso de la interpolación. Y la NormalizarTiempo es para que funcione correctamente la interpolación.

## Tweening<TTipo>
---
Es la clase que implementa la interpolación, e utiliza todas las interfaces antes mencionadas, con la firma
```c#
public async static Task Tween(Action<TTipo> Actualizar, ICamino<TTipo> camino, TTipo inicio, TTipo final, ICurva curva, IReloj reloj);
```

De esta forma podemos interpolar cualquier tipo de dato, implementando las clases respectivdas.

### ITween
---
Es la interfaz es la forma de encapsular el llamado a Tween, se pueden hacer casos especificos de las cuales son mucho más simples de manejar.

### AdministrarTweens
---
Es una clase abstracta para poder englobal los ITweens.