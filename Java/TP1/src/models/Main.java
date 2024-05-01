package models;

/**
 * Created by Marcosp on 19/3/2018.
 */
public class Main {

    private static BeerHouse house;
    private static Thread productor;
    private static Thread [] consumidores;

    /**
     * @param args the command line arguments
     */

    public static void main(String[] args)
    {
        house = new BeerHouse();
        productor = new Thread(new BeerProducter(house));
        consumidores = new Thread[2];

        productor.start();
        consumidores[1] = new Thread(new BeerConsumer(house, 1));
        consumidores[1].start();

    }
}
