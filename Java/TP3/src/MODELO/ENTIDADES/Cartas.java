package MODELO.ENTIDADES;

/**
 * Created by Marcosp on 8/4/2018.
 */

public class Cartas {

    private final Figura figura;
    private final Numero numero;

    public Cartas(Figura f, Numero n){
        this.figura = f;
        this.numero = n;
    }

    public Figura getFigura() {
        return figura;
    }

    public Numero getNumero() {
        return numero;
    }

    @Override
    public String toString(){
        return this.numero.toString() + "-" + this.figura.toString();
    }
}
