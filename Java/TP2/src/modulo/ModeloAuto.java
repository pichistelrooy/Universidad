package modulo;

import java.util.ArrayList;
import java.util.List;
import java.util.Observable;

/**
 * Created by Marcosp on 27/3/2018.
 */
public class ModeloAuto extends modulo.Observable{

    List<Auto> listaAutos = new ArrayList<Auto>();
    static int ultimoIdAuto = 0;


    public void agregarAuto(String marca,String modelo) {
        Auto a = new Auto();
        a.setMarca(marca);
        a.setModelo(modelo);
        a.setId(++ultimoIdAuto);
        listaAutos.add(a);
        this.setChanged();
        this.notifyObservers(listaAutos);
    }

    public List<Auto> getListaAuto() {
        return this.listaAutos;
    }

    public void modificarAuto(Integer id, Double aceite, Double agua,Double presion)
    {
        for (Auto a : listaAutos)
        {
            if (a.getId() == id)
            {
                Double auxagua = a.getAguaauto();
                Double auxaceite = a.getAceiteauto();
                Double auxpresion = a.getPresionauto();

                int retval = Double.compare(auxagua, agua);
                int retval1 = Double.compare(auxaceite, aceite);
                int retval2 = Double.compare(auxpresion, presion);

                if(retval != 0 || retval1 != 0 || retval2 != 0)
                {
                    a.setAuxaceite(a.getAceiteauto());
                    a.setAceiteauto(aceite);
                    a.setAuxagua(a.getAguaauto());
                    a.setAguaauto(agua);
                    a.setAuxpresion(a.getPresionauto());
                    a.setPresionauto(presion);
                    this.setChanged();
                    this.notifyObservers(listaAutos);
                }
            }
        }

    }
}
