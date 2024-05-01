package com.utn.Interface;

import com.utn.Entidades.Usuario;
import com.utn.Repositorio.RepUsuario;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.*;

/**
 * Created by Marcosp on 25/4/2018.
 */
@Service
public class IUsuario {

    @Autowired
    private RepUsuario repositorio;

    // Funciones Navegador
    public List<Usuario> BuscarXNavegador(String Navegador){
        return repositorio.findUsuarioByNavegador(Navegador);
    }

    public Long TotalNavegador(String Navegador){
        return repositorio.countUsuariosByNavegadorEquals(Navegador);
    }

    // Funciones Sistema
    public List<Usuario> BuscarXSistema(String Sistema){
        return repositorio.findUsuarioBySistema(Sistema);
    }

    public Long TotalSistema(String Sistema){
        return repositorio.countUsuariosBySistemaEquals(Sistema);
    }

    // Guardar
    public void  save(Usuario reg){
        repositorio.save(reg);
    }

    // Traer todo
    public List<Usuario> findAll(){
        return repositorio.findAll();
    }
}