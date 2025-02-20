# 🎮 Recreando clásicos: Pong - Unity

Este proyecto es una recreación del clásico Pong de Atari usando Unity. Se ha diseñado para ser fiel al juego original, manteniendo su jugabilidad simple pero desafiante.
Este proyecto forma parte de una serie de recreaciones de videojuegos clásicos, diseñados para aprender, experimentar y mejorar habilidades en desarrollo de juegos con Unity.

> **Objetivo**: Reproducir la experiencia del *Pong* original con mecánicas fieles y código optimizado.

---

## 🎥 Referencias al juego original

Estos videos ayudan a comprender los detalles del diseño y la jugabilidad original para lograr una recreación fiel.
Para entender mejor la jugabilidad y el diseño original, puedes revisar los siguientes videos:

1. [Pong (Arcade, 1972) - Gameplay](https://www.youtube.com/watch?v=fiShX2pTz9A)  
2. [Pong 1972 by Atari](https://www.youtube.com/watch?v=fhd7FfGCdCo)
3. [Original Atari PONG (1972) arcade machine gameplay video](https://www.youtube.com/watch?v=fiShX2pTz9A)
4. [Wikipedia](https://es.wikipedia.org/wiki/Pong)

---

## 📌 Game design

Pista:
- Límites verticales superior e inferior -> golpean la bola.
- Límites horizontales izquierda y derecha -> porterías.
- Línea vertical decorativa separando las 'canchas'.

Entidades:
- Bola: entidad pasiva que aumenta la velocidad tras ser golpeada por una pala.
- Pala: entidad activa que puede desplazarse de arriba a abajo.

Comportamientos:
- Al iniciar la partida, la bola aparece en una posición aleatoria en el centro de la pista en un ángulo determinado con su velocidad inicial. Empieza hacia la izquierda o la derecha aleatoriamente, y hacia arriba o hacia abajo aleatoriamente.
- Al conseguir un punto, la bola aparecerá en una posición aleatoria, en el mismo ángulo, hacia arriba o hacia abajo aleatoriamente, pero en la dirección del jugador contrario que ha conseguido el punto.
- El primero en llegar a 10 puntos gana.

Interfaz:
- Se muestra la puntuación de cada jugador.

---

## 🛠️ Requisitos

- **Unity**: Versión **60000.0.32f1** o superior (recomendado).  
- **.NET 6** o superior.  
- **Editor de código** compatible con Unity (Visual Studio o VS Code).  
- **Git** (opcional, para clonar el repositorio).  

---

## 🎮 Controles del juego

| Acción         | Tecla (Jugador 1) | Tecla (Jugador 2) |
|---------------|------------------|------------------|
| Mover arriba  | `W`              | `↑`             |
| Mover abajo   | `S`              | `↓`             |
| Reiniciar juego | `R`             | `R`             |

> En el modo un jugador, la IA controla el segundo paddle.

## 🐟 Licencia

Este proyecto se distribuye bajo la licencia **MIT**.  
Puedes usarlo, modificarlo y distribuirlo libremente.

---

¡Diviértete desarrollando *Pong* y recreando clásicos! 🚀

