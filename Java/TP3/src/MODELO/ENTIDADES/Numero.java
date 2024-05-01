package MODELO.ENTIDADES;

/**
 * Created by Marcosp on 8/4/2018.
 */
public enum Numero {
    UNO(1), DOS(2),TRES(3), CUATRO(4), CINCO(5), SEIS(6), SIETE(7), OCHO(8), NUEVE(9), DIEZ(10), ONCE(11), DOCE(12);

    private final int value;

    Numero(final int newValue) {
        value = newValue;
    }

    public int getValue() { return value; }

}
