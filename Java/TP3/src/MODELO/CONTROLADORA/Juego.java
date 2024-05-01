package MODELO.CONTROLADORA;

import MODELO.ENTIDADES.Jugadores;
import MODELO.ENTIDADES.Repartidor;
import MODELO.ENTIDADES.Baraja;
import MODELO.DAO.dao;
import java.util.*;

/**
 * Created by Marcosp on 8/4/2018.
 */
public class Juego extends MODELO.ENTIDADES.Observable implements Runnable {

    private List<Jugadores> listajugadores;
    private List<Jugadores> listaganadores;
    private Repartidor dealer;
    private Baraja mazo;
    private final Integer TIEMPOESPERA = 500;
    private Jugadores jugadorganador;
    private static Integer puntajeganador;
    private static Integer nropartida;

    public static Integer getNropartida() {
        return nropartida;
    }

    public static void setNropartida(Integer nropartida) {
        Juego.nropartida = nropartida;
    }

    public static Integer getPuntajeganador() {
        return puntajeganador;
    }

    public static void setPuntajeganador(Integer puntajeganador) {
        Juego.puntajeganador = puntajeganador;
    }

    dao bd = new dao();

    public Juego(){
        this.dealer = new Repartidor(new Baraja());
        this.dealer.mezclarBaraja((byte)15);
        this.listajugadores = new ArrayList();
    }

    public void addJugador(Jugadores jugador){
        this.listajugadores.add(jugador);
    }

    public void repartirCartas(){
        byte i = 0;
        byte a = 1;
        while(i < dealer.getNumeroCartas())
        {
            System.out.println("Mano N°: " + a + " Cartas restantes: " + dealer.getNumeroCartas());
            for(Jugadores j : this.listajugadores)
            {
                try
                {
                    j.adicionarCarta(this.dealer.entregarCarta());
                    this.setChanged();
                    this.notifyObservers(j.getNombre());
                    Thread.sleep(TIEMPOESPERA);
                } catch (InterruptedException e) {
                    System.err.println(" Error en run -> " + e.getMessage());
                }
            }
            System.out.println("");
            a++;
        }
    }

    public String mostrarBaraja(){

        return this.dealer.mostrarBaraja();
    }

    public int getNumeroCartasDealer(){

        return this.dealer.getNumeroCartas();
    }

    public List<Jugadores> getJugadores(){

        return this.listajugadores;
    }

    @Override
    public void run()
    {
        Juego juego = new Juego();
        setNropartida(bd.nropartida());
        System.out.println("Bienvenido al juego N°: " + getNropartida());
        System.out.println("\nBaraja Inicial de :" + juego.getNumeroCartasDealer() + " cartas.");
        System.out.println(juego.mostrarBaraja());

        Jugadores jugador1 = new Jugadores("Chris Moneymaker");
        juego.addJugador(jugador1);
        juego.addObserver(jugador1);

        Jugadores jugador2 = new Jugadores("Phil Yve");
        juego.addJugador(jugador2);
        juego.addObserver(jugador2);

        Jugadores jugador3 = new Jugadores("Samy Farha");
        juego.addJugador(jugador3);
        juego.addObserver(jugador3);

        Jugadores jugador4 = new Jugadores("Marcos Piccolini");
        juego.addJugador(jugador4);
        juego.addObserver(jugador4);

        juego.repartirCartas();
        System.out.println("\n----- Cartas por Jugador ------\n");

        setPuntajeganador(0);
        for (Jugadores j : juego.getJugadores()) {
            System.out.println(j.toString() + "\n" +  "----->Puntaje final: " + j.getTotal() + " Puntos<-----");
            if (getPuntajeganador() < j.getTotal()) {
                setPuntajeganador(j.getTotal());
            }
        }
        System.out.println("\n");

        this.listaganadores = new ArrayList();
        for (Jugadores i : juego.getJugadores()) {
            if (getPuntajeganador() == i.getTotal()) {
                this.listaganadores.add(i);
                bd.insertarganador(getNropartida(),i.getNombre(),i.getTotal(),i.devolverCartas(i.getNombre()));
            }
        }

        if (this.listaganadores.size() == 1)
        {
            for(Jugadores ju : this.listaganadores)
            {
                System.out.println("El ganador es: " + ju.getNombre() + " con " + ju.getTotal() + " puntos!");
            }

        }
        else if (this.listaganadores.size() > 1)
        {
            System.out.println("Hubo un empate! los jugadores ganadores son: ");
            for(Jugadores ju : this.listaganadores)
            {
                System.out.println("\n" + ju.getNombre() + " con " + ju.getTotal() + " puntos!");
            }
        }

        System.out.println("Mazo Final de :" + juego.getNumeroCartasDealer() + " cartas.");
        System.out.println(juego.mostrarBaraja());

    }

}


