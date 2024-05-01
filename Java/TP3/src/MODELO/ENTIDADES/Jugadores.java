package MODELO.ENTIDADES;

import java.util.*;

/**
 * Created by Marcosp on 8/4/2018.
 */
public class Jugadores implements Observer{

    private List<Cartas> mano;
    private String nombre;
    private String auxmano;
    private Integer total;

    public Integer getTotal() {
        return total;
    }

    public void setTotal(Integer total) {
        this.total = this.getTotal() + total;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Jugadores(String nombre){
        this.nombre = nombre;
        this.mano = new ArrayList();
        this.total = 0;
    }

    public void adicionarCarta(Cartas carta){
        this.mano.add(carta);
        setTotal(carta.getNumero().getValue());
    }

    public Cartas botarCarta(int index){
        return this.mano.remove(index);
    }

    @Override
    public String toString(){
        StringBuilder sb = new StringBuilder();
        sb.append("Jugador: ")
                .append(this.nombre)
                .append("\n").append(this.mano.toString());
        return sb.toString();
    }

    public void mostrarCartas(String nombre) {

        if(this.getNombre() == nombre) {
            for (Cartas a : mano) {

                if (auxmano == null) {
                    auxmano = a.getNumero() + " de " + a.getFigura();
                } else {
                    auxmano = auxmano + "," + a.getNumero() + " de " + a.getFigura();
                }
            }

            if (mano.size() > 0) {
                System.out.println("Mano del Jugador " + getNombre() + ": " + auxmano + " y su Puntaje es: " + getTotal());
            }

            auxmano = null;
        }
    }

    public String devolverCartas(String nombre) {

        if(this.getNombre() == nombre) {
            return mano.toString();
        }
        else {
            return "";
        }
    }

    @Override
    public void update(Observable o, String nombre) {
        mostrarCartas(nombre);
    }

}

