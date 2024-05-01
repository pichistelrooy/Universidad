# TP1
Los consumidores que se necesitan para que el stock llegue a 0(cero) son variables. El proceso simula que, cuando va transcurriendo el tiempo del día, los pedidos de cerveza van aumentando, si bien siempre es aleatorio,
va creciendo el número máximo de pedidos que pueden realizarse. Técnicamente, el valor máximo del Rango de la función Random va en aumento progresivo.
En cambio la producción de cerveza es siempre estática entre determinados valores.

Los bloques deben ser syncronized, primero para saber el stock real a todo momento, tanto cuando se produce una adición como una sustracción de Stock, y para que, cuando el stock llega a 100,

El recurso compartido esta en los bloques syncronized. En este caso, los procesos de productor y de consumidor se esperan 
para poder ejecutarse.

Las formas que hay para implementar un Thread son:

    Heredar de Thread redefiniendo el método run().
    Crear una clase que implemente la interfaz Runnable que nos obliga a definir el método run().
    Crear una clase que implemente la interfaz Runnable "cableada" para poder usar las excepciones que proporciona.	
