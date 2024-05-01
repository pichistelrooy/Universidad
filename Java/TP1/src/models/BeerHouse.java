package models;

/**
 * Created by Marcosp on 19/3/2018.
 */
public class BeerHouse {

    private static Integer stock = 15;
    private static Integer producidas = 0;
    private static Integer laststock = 0;

    public static Integer getStock() {
        return stock;
    }

    public static void setStock(Integer stock) {
        BeerHouse.stock = stock;
    }

    public static Integer getProducidas() {
        return producidas;
    }

    public static void setProducidas(Integer producidas) {
        BeerHouse.producidas = producidas;
    }

    public synchronized Integer get(Integer value)
    {
        Integer aux = getStock();

        if(value < aux)
        {
            aux = aux - value;

            setStock(aux);
            notify();
            return aux;
        }
        else
        {
            setStock(0);
            laststock = aux;
            return 0;
        }
    }

    public synchronized void put(Integer value)
    {
        //if (this.producidas < 10) establecido para un limite a la produccion
        //{
            Integer aux = getStock();
            /*while (aux >= 100)
            {
                try
                {
                    wait();
                }

                catch (InterruptedException e)
                {
                    System.err.println("Stock: Error en put -> " + e.getMessage());
                }
            }*/

            if (aux > 0)
            {
                if (aux + value > 100) {
                    aux = 100;
                    producidas++;
                } else {
                    aux = aux + value;
                    producidas++;
                }

                setStock(aux);
                notify();
            }
            else
            {
                setStock(0);
                notify();
            }
       // }
    }

}
