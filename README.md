# Prácticas de Físicas e Interacciones en Unity

Este repositorio contiene una serie de ejercicios prácticos desarrollados en Unity para dominar el motor de físicas, la gestión de colisiones (físicas y triggers), el uso de materiales físicos y la optimización mediante capas.

---

## Ejercicio 1: Control de Personaje con Rigidbody
**Hitos técnicos alcanzados:**
* Captura de los ejes de entrada (`Input.GetAxisRaw`) para el control de movimiento (WASD/Flechas).
* Implementación correcta del movimiento físico utilizando el método `Rigidbody.MovePosition()` para mantener el control total sin perder las propiedades de colisión.
* Sincronización del movimiento con las físicas del motor usando `FixedUpdate` y `Time.fixedDeltaTime`.

> **Demostración:**
<img width="718" height="374" alt="ej1" src="https://github.com/user-attachments/assets/c752bfd5-21df-4e9c-bab2-72ec569f3dc3" />


---

## Ejercicio 2: Detección de Colisiones Dinámicas
**Hitos técnicos alcanzados:**
* Configuración de objetos dinámicos que reaccionan a la gravedad y a las fuerzas del entorno.
* Uso de la función `OnCollisionEnter(Collision)` para detectar impactos sólidos.
* Acceso a los datos del objeto impactado (`colision.gameObject.name`) para mostrarlos por consola.
* Modificación en tiempo real del componente `Renderer` para cambiar el color del material al detectar el impacto.

> **Demostración:**
<img width="730" height="368" alt="ej2" src="https://github.com/user-attachments/assets/6d8894f5-54ca-484e-b4c8-d4c67366bc3e" />


---

## Ejercicio 3: Zonas de Detección (Triggers) y Estados
**Hitos técnicos alcanzados:**
* Diferenciación entre choques físicos y zonas de detección (activando la casilla `Is Trigger`).
* Uso de las funciones `OnTriggerEnter(Collider)` y `OnTriggerExit(Collider)`.
* Implementación de lógica de filtrado mediante Etiquetas (`Tags`) para diferenciar entre una "Zona de Color" y una "Zona de Daño".
* Almacenamiento y restauración de estados previos (guardar el color original para revertirlo al salir de la zona).

> **Demostración:**
<img width="754" height="356" alt="ej3" src="https://github.com/user-attachments/assets/1ceda919-5abc-41b1-a813-f0568905f006" />


---

## Ejercicio 4: Optimización con Layer Collision Matrix
**Hitos técnicos alcanzados:**
* Creación y asignación de Capas personalizadas (`Jugador`, `Enemigos`, `Recolectables`).
* Optimización del rendimiento del motor físico modificando la **Layer Collision Matrix** (Project Settings > Physics) para evitar cálculos de colisión innecesarios.
* Configuración de reglas específicas de interacción: los enemigos solo detectan masa sólida del jugador, y los recolectables son ignorados por los sistemas de física sólida pero detectados mediante Triggers.

> **Demostración:**
<img width="754" height="356" alt="ej4" src="https://github.com/user-attachments/assets/9decf28a-98df-4ec1-9481-9be14ee6e017" />


---

## Ejercicio 5: Materiales Físicos y Aplicación de Fuerzas
**Hitos técnicos alcanzados:**
* Creación y asignación de `Physic Materials` ajustando parámetros de fricción estática/dinámica (`Friction`) y rebote (`Bounciness`).
* Separación correcta de la lógica de entrada y física: captura de pulsaciones (tecla 'X') en el `Update` y ejecución de fuerzas en el `FixedUpdate`.
* Uso del método `Rigidbody.AddForce()` utilizando `ForceMode.Impulse` para simular lanzamientos instantáneos.

> **Demostración:**
<img width="694" height="388" alt="ej5" src="https://github.com/user-attachments/assets/1004c748-6b7b-4779-a14c-282e81087d0b" />


---

## Ejercicio 6: Interacciones Matemáticas sin Rigidbody
**Hitos técnicos alcanzados:**
* Comprensión de las limitaciones del motor de físicas de Unity (desactivación automática de eventos OnTrigger/OnCollision cuando no hay ningún `Rigidbody` implicado).
* Implementación de movimiento matemático independiente mediante la normalización de vectores de dirección e interpolación con `Time.deltaTime`.
* Creación de un sistema manual de detección de colisiones evaluando la intersección matemática de las cajas delimitadoras de los objetos mediante `Collider.bounds.Intersects()`.
* Cambio dinámico de materiales (`Renderer.material`) referenciando objetos externos buscados por Tag.

> **Demostración:**
<img width="694" height="388" alt="ej6" src="https://github.com/user-attachments/assets/d0c01df4-59a2-4867-bc4c-96f937c7986a" />



El objetivo de estos ejercicios es observar cómo interactúan el motor de físicas y las colisiones dependiendo de si los objetos son estáticos (solo Collider), dinámicos (Rigidbody) o cinemáticos (Is Kinematic), así como el efecto de la masa, la fricción y los Triggers.

### Situación 1
* **Configuración:** Plano (solo Collider). Cubo (Rigidbody). Esfera (solo Collider).
* **Resultado Visual:**
<img width="692" height="388" alt="s1" src="https://github.com/user-attachments/assets/c7c7f995-34f5-4a73-94fe-931e4a112fd9" />

* **Explicación:** [Escribe aquí por qué ocurre esto. Ej: El cubo cae por la gravedad al tener Rigidbody, pero la esfera se queda flotando porque no lo tiene...]

### Situación 2
* **Configuración:** Plano (solo Collider). Cubo (Rigidbody). Esfera (Rigidbody).
* **Resultado Visual:**
<img width="688" height="390" alt="s2" src="https://github.com/user-attachments/assets/89b063df-ed6d-4cf9-98b4-4ac58c96446f" />

* **Explicación:** [Escribe aquí tu explicación]

### Situación 3
* **Configuración:** Plano (solo Collider). Cubo (Rigidbody). Esfera (Rigidbody Cinemático).
* **Resultado Visual:**
<img width="688" height="390" alt="s3" src="https://github.com/user-attachments/assets/388d1a02-f241-463b-a0c2-d1fbcd4ec5a5" />

* **Explicación:** [Escribe aquí tu explicación. Ej: La esfera no cae porque al ser cinemática ignora la gravedad, pero...]

### Situación 4
* **Configuración:** Plano (Rigidbody). Cubo (Rigidbody). Esfera (Rigidbody).
* **Resultado Visual:**
<img width="688" height="390" alt="s4" src="https://github.com/user-attachments/assets/ce7054bf-d4bc-4ad2-bc90-8d9b75b271b9" />

* **Explicación:** [Escribe aquí tu explicación]

### Situación 5
* **Configuración:** Plano (Rigidbody Cinemático). Cubo (Rigidbody). Esfera (Rigidbody, Masa x10).
* **Resultado Visual:**
<img width="688" height="390" alt="s5" src="https://github.com/user-attachments/assets/112a2836-4d97-4a61-8beb-69bb89288f60" />

* **Explicación:** [Escribe aquí tu explicación]

### Situación 6
* **Configuración:** Plano (Rigidbody Cinemático). Cubo (Rigidbody). Esfera (Rigidbody, Masa x100).
* **Resultado Visual:**
<img width="688" height="390" alt="s6" src="https://github.com/user-attachments/assets/1189ae27-0641-41d8-9c8c-a9265278a273" />

* **Explicación:** [Escribe aquí tu explicación. ¿Hay diferencia en el impacto respecto a la situación 5?]

### Situación 7
* **Configuración:** Plano (Rigidbody). Cubo (Rigidbody). Esfera (Rigidbody con fricción).
* **Resultado Visual:**
<img width="688" height="390" alt="s7" src="https://github.com/user-attachments/assets/1db94633-5f28-41a3-b53e-c3fca8cf97ff" />

* **Explicación:** [Escribe aquí tu explicación]

### Situación 8
* **Configuración:** Plano (Rigidbody Cinemático). Cubo (Rigidbody). Esfera (Trigger, sin Rigidbody).
* **Resultado Visual:**
<img width="688" height="390" alt="s8" src="https://github.com/user-attachments/assets/58b7651a-917d-4989-bb5e-6987daccb897" />

* **Explicación:** [Escribe aquí tu explicación]

### Situación 9
* **Configuración:** Plano (Rigidbody Cinemático). Cubo (Rigidbody). Esfera (Rigidbody y Trigger).
* **Resultado Visual:**
<img width="688" height="390" alt="s9" src="https://github.com/user-attachments/assets/61217087-06e9-4c06-9835-9e9efaa985a7" />

* **Explicación:** [Escribe aquí tu explicación]
