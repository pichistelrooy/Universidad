package MODELO.ENTIDADES;

/**
 * Created by Marcosp on 8/4/2018.
 */
public class Repartidor {

    private Baraja baraja;

    public Repartidor(Baraja baraja){
        this.baraja = baraja;
    }

    public void mezclarBaraja(byte cantidad){
        this.baraja.mezclar(cantidad);
    }

    public Cartas entregarCarta(){
        return this.baraja.getCarta();
    }

    public String mostrarBaraja(){
        return this.baraja.toString();
    }

    public int getNumeroCartas(){
        return this.baraja.getNumeroCartas();
    }

}
