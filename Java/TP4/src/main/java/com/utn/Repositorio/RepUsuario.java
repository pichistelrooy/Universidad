package com.utn.Repositorio;

import com.utn.Entidades.Usuario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import java.util.List;

/**
 * Created by Marcosp on 25/4/2018.
 */
@Repository
public interface RepUsuario extends JpaRepository<Usuario, Long>{

    // Funciones Navegador
    List<Usuario> findUsuarioByNavegador(String Navegador);
    Long countUsuariosByNavegadorEquals (String Navegador);

    // Funciones Sistema
    List<Usuario> findUsuarioBySistema(String Sistema);
    Long countUsuariosBySistemaEquals (String Sistema);
}