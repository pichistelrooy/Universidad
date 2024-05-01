package modulo;

/**
 * Created by Marcosp on 19/3/2018.
 */
public class Auto {

    private Integer id;
    private String marca;
    private String modelo;
   /* private final Double maxaceite;
    private final Double minaceite;
    private final Double maxagua;
    private final Double minagua;
    private final Double maxpresion;
    private final Double minpresion;*/
    private Double aceiteauto;
    private Double aguaauto;
    private Double presionauto;
    private static Double auxaceite = 0.00;
    private static Double auxagua = 0.00;
    private static Double auxpresion = 0.00;


    public static void setAuxaceite(Double auxaceite) {
        Auto.auxaceite = auxaceite;
    }

    public static void setAuxagua(Double auxagua) {
        Auto.auxagua = auxagua;
    }

    public static void setAuxpresion(Double auxpresion) {
        Auto.auxpresion = auxpresion;
    }

    public static Double getAuxaceite() {
        return auxaceite;
    }

    public static Double getAuxagua() {
        return auxagua;
    }

    public static Double getAuxpresion() {
        return auxpresion;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }
    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

   /* public Double getMaxaceite() {
        return maxaceite;
    }

    public Double getMinaceite() {
        return minaceite;
    }

    public Double getMaxagua() {
        return maxagua;
    }

    public Double getMinagua() {
        return minagua;
    }

    public Double getMaxpresion() {
        return maxpresion;
    }

    public Double getMinpresion() {
        return minpresion;
    }*/

    public Double getAceiteauto() {
        return aceiteauto;
    }

    public void setAceiteauto(Double aceiteauto) {
        this.aceiteauto = aceiteauto;
    }

    public Double getAguaauto() {
        return aguaauto;
    }

    public void setAguaauto(Double aguaauto) {
        this.aguaauto = aguaauto;
    }

    public Double getPresionauto() {
        return presionauto;
    }

    public void setPresionauto(Double presionauto) {
        this.presionauto = presionauto;
    }

    public Auto()
    {
        /*this.maxaceite = 3.8;
        this.minaceite = 2.8;
        this.maxagua = 6.0;
        this.minagua = 4.8;
        this.maxpresion = 2.2;
        this.minpresion = 2.0;*/
        this.aceiteauto = 0.00;
        this.aguaauto = 0.00;
        this.presionauto = 0.00;
    }

    public void Modificar(Integer id, Double aceite, Double agua, Double presion) {
        this.aceiteauto = aceite;
        this.aguaauto = agua;
        this.presionauto = presion;
    }

}