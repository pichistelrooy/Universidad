package MODELO.DAO;

import MODELO.ENTIDADES.Cartas;
import MODELO.ENTIDADES.Jugadores;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Created by Marcosp on 10/4/2018.
 */
public class dao {
    private Conexion conn= Conexion.getInstance();

    public void insertarganador(Integer idpartida, String jugador, Integer puntaje, String cartas){
        String dml = "insert into partidas values (?,?,?,?);";
        try {
            conn.conectar();
            PreparedStatement st = conn.getConn().prepareStatement(dml);
            st.setInt(1, idpartida);
            st.setString(2, jugador);
            st.setInt(3, puntaje);
            st.setString(4, cartas);
            st.execute();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public Integer nropartida()
    {
        String dml = "select COALESCE(max(idpartida),0)  as 'nropartida' from partidas";
        Integer nropartida = 0;
        try {
            conn.conectar();
            PreparedStatement st = conn.getConn().prepareStatement(dml);
            ResultSet rs = st.executeQuery();
            rs.next();
            nropartida = rs.getInt("nropartida");
            nropartida++;
            rs.close();
            st.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return nropartida;
    }

}
