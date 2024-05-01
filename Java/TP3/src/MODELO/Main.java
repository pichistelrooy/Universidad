package MODELO;

import MODELO.CONTROLADORA.Juego;

/**
 * Created by Marcosp on 8/4/2018.
 */
public class Main {

    private static Thread juego;

    public static void main(String[] args)
    {
        juego = new Thread(new Juego());
        juego.start();
    }
}
