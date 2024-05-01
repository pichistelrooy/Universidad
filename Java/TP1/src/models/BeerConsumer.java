package models;

import java.util.Random;

/**
 * Created by Marcosp on 19/3/2018.
 */
public class BeerConsumer implements Runnable{

    private final BeerHouse house;
    private final Random aleatorio;
    private static Integer idconsumidor;
    private final Integer TIEMPOESPERA = 1200;
    private static Integer multiplicadorconsumo = 1;
    private static Integer laststock = 0;
    private static Integer lastcompra = 0;

    /**
     * Constructor de la clase
     * @param BeerHouse house común a los consumidores y el productor
     * @param idconsumidor Identificador del consumidor
     */
    public BeerConsumer(BeerHouse house, Integer idconsumidor)
    {
        this.house = house;
        this.idconsumidor = idconsumidor;
        aleatorio = new Random(System.currentTimeMillis());
        /** Le da el tiempo necesario para realmente producir un resultado distinto al anterior */

    }

    @Override
    public void run()
    {
        while(house.getStock() <= 100 && house.getStock() > 0)
        {
            multiplicadorconsumo++;
            Integer pintas = aleatorio.nextInt(multiplicadorconsumo);
            pintas++;
            laststock = house.get(pintas);
            System.out.println("El consumidor " + idconsumidor + " consume: " + pintas + " y el stock disponible es: " + laststock);
            try
            {
                if (laststock == 0)
                {
                    System.out.println("Nos quedamos sin birras! último stock: " + laststock + " y última compra: " + pintas);
                }

                Thread.sleep(TIEMPOESPERA);
            } catch (InterruptedException e) {
                System.err.println("Consumidor: Error en run -> " + e.getMessage());
            }
        }
    }
}
