package MODELO.ENTIDADES;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Marcosp on 27/3/2018.
 */
public class Observable {

    private List<Observer> observers = new ArrayList<Observer>();
    private boolean changed = false;

    public void addObserver(Observer o) {
        observers.add(o);
    }

    public void clearChanged() {
        this.changed = false;
    }

    public void deleteObserver(Observer o) {
        observers.remove(o);
    }

    public boolean hasChanged() {
        return this.changed;
    }

    public void setChanged() {
        this.changed = true;
    }

    public int countObservers() {
        return observers.size();
    }

    public void notifyObservers() {
        if (this.changed) {
            for (Observer o : observers) {
                o.update(this, null);
            }
        }
        this.clearChanged();
    }

    public void notifyObservers(String nombre) {
        if (this.changed) {
            for (Observer o : observers) {
                o.update(this, nombre);
            }
        }
        this.clearChanged();
    }
}