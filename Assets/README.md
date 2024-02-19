Test de Networking Leonardo Blanco

El proyecto utiliza Fish Networking para permitir la comunicación entre múltiples clientes y el servidor. Fish Networking es una tecnología específica que se integra con Unity para facilitar la sincronización de objetos y acciones entre estos.

Lógica del juego: El juego es un simple projecto donde 2 o mas jugadores pueden conectarse, verse, interactuar, etc.

Cliente Unity: Cada cliente es una instancia de Unity que se conecta al servidor mediante Fishnet y tansfiere informacion hacia el servidor y este al mismo tiempo hacia otros clientes.

Interfaz de usuario y entrada del jugador: El cliente tiene autoridad sobre sus propias acciones para optimizar la latencia y tener una experiencia mas fluido.

Interpolación y predicción: Los clientes pueden utilizar técnicas de interpolación y predicción para mejorar la experiencia del jugador al predecir el estado del juego entre actualizaciones del servidor y suavizar las transiciones.

Mensajes de red: La comunicación entre el cliente y el servidor se realiza a través de mensajes de red. Estos mensajes contienen información sobre acciones del jugador, actualizaciones de estado del juego y eventos importantes.

Sincronización de objetos: Fish Networking proporciona herramientas para sincronizar objetos entre el cliente y el servidor de manera eficiente, lo que garantiza que todos los jugadores vean el mismo estado del juego.

Autoridad compartida: Aunque el servidor tiene la autoridad final, Fish Networking puede permitir cierto grado de autoridad compartida, lo que significa que algunos objetos o aspectos del juego pueden ser controlados por el cliente sin intervención del servidor.

Optimización de red: Para garantizar un rendimiento óptimo, es crucial optimizar la comunicación de red, minimizando la cantidad de datos enviados entre el cliente y el servidor y reduciendo la latencia de red.

Optimización de rendimiento: Además de la optimización de red, se deben implementar técnicas de optimización de rendimiento en el cliente y el servidor para garantizar que el juego se ejecute sin problemas, incluso en condiciones de red menos que ideales.