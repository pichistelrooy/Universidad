package modulo;

/**
 * Created by Marcosp on 25/3/2018.
 */
public class Main {
    public static void main(String[] args) {

        ModeloAuto modelo = new ModeloAuto();
        ModeloMecanico vista = new ModeloMecanico();
        modelo.addObserver(vista);

        modelo.agregarAuto("Fiat", "Palio 1.4");
        modelo.agregarAuto("Volkswagen", "Gol Trend 1.6");
        modelo.agregarAuto("Renault", "Sandero 1.8");
        modelo.agregarAuto("Chevrolet", "Spin 1.6");
        modelo.agregarAuto("Audi", "TT 2.8");

        modelo.modificarAuto(1,2.36,2.25,6.32);
        modelo.modificarAuto(1,6.36,3.00,5.98);
        modelo.modificarAuto(1,6.36,3.00,5.98);

    }
}
