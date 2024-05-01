package MODELO.ENTIDADES;

import java.util.*;

/**
 * Created by Marcosp on 8/4/2018.
 */
public class Baraja {

    private List<Cartas> baraja;
    public Baraja(){
        this.construir();
    }

    private void construir(){
        this.baraja = new ArrayList();
        for(Figura f : Figura.values()){
            for(Numero n : Numero.values()){
                this.baraja.add(new Cartas(f, n));
            }
        }
    }

    public void mezclar(byte cantidad){
        int nVeces = cantidad * this.baraja.size();
        Random random = new Random();
        int index = 0;
        Cartas carta;
        for(int i = 0; i < nVeces; i++){
            index = random.nextInt(this.baraja.size());
            carta = this.baraja.remove(index);
            index = random.nextInt(this.baraja.size());
            this.baraja.add(index, carta);
        }
    }

    public int getNumeroCartas(){
        return this.baraja.size();
    }

    public Cartas getCarta(){
        return this.baraja.remove(0);
    }

    public boolean estaVacia(){
        return this.baraja.isEmpty();
    }

    @Override
    public String toString(){
        return this.baraja.toString();
    }
}
