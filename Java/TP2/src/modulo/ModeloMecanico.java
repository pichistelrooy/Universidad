package modulo;

import java.util.List;

/**
 * Created by Marcosp on 27/3/2018.
 */
public class ModeloMecanico implements Observer {

    private static Integer contador;

    public void mostrarListaAuto(List<Auto> lista) {

        contador = 1;

        for (Auto a : lista) {

            if (contador == 1)
            {
                System.out.println("\n====== LISTA ACTUALIZADA ======");
            }
            System.out.println("Auto:" + a.getId() + " - " + a.getMarca() + " - " + a.getModelo() +
                    " Aceite: " + a.getAceiteauto() + "(Valor Anterior:" + a.getAuxaceite() + ")" +
                    " Agua: " + a.getAguaauto() + "(Valor Anterior:" + a.getAuxagua() + ")" +
                    " Presión de neumáticos: " + a.getPresionauto() + "(Valor Anterior:" + a.getAuxpresion() + ")");
            contador++;
        }
    }

    @Override
    public void update(Observable o, Object arg) {
        mostrarListaAuto((List<Auto>) arg);
    }

}

