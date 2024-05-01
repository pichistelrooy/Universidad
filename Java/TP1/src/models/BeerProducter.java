package models;

import java.util.Random;

/**
 * Created by Marcosp on 19/3/2018.
 */
public class BeerProducter implements Runnable {

    private final Random aleatorio;
    private final BeerHouse house;
    private final Integer TIEMPOESPERA = 2000;

    public BeerProducter(BeerHouse house)
    {
        this.house = house;
        aleatorio = new Random(System.currentTimeMillis());
        // Le da el tiempo necesario para realmente producir un resultado distinto al anterior
    }

    @Override
    public void run()
    {
        //while(house.getProducidas() < 10)
        while(house.getStock() <= 100 && house.getStock() > 0)
        {
            Integer cargar = aleatorio.nextInt(45);
            cargar++;
            house.put(cargar);
            System.out.println("Producción N°: " + house.getProducidas() + ". Se producieron " + cargar + " litros y el stock actual es: " + house.getStock());
            try
            {
                Thread.sleep(TIEMPOESPERA);
            }
            catch (InterruptedException e)
            {
                System.err.println("Productor: Error en run -> " + e.getMessage());
            }
        }
       /* else
        {
            System.out.println("Terminó la producción");
        }*/
    }


}