package com.utn.Controladora;

import com.utn.Entidades.Usuario;
import com.utn.Interface.IUsuario;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import eu.bitwalker.useragentutils.*;
import java.util.*;


/**
 * Created by Marcosp on 25/4/2018.
 */
@RestController
@RequestMapping("/TP4")
public class ControladoraUsuario {

    @Autowired
    IUsuario service;

     @GetMapping( "/Inicio" )
     public Usuario Bienvenido(@RequestHeader( value = "User-Agent" ) String User) {

         UserAgent userAgent = UserAgent.parseUserAgentString(User);
         Browser browser = userAgent.getBrowser();
         String BrowserName = browser.getName();

         OperatingSystem os = userAgent.getOperatingSystem();
         String osName = os.getName();

         Usuario usr = new Usuario();
         usr.setNavegador(BrowserName);
         usr.setSistema(osName);
         service.save(usr);
         return usr;
     }

     //@GetMapping( "/InicioExtendido" )
     //****** ESTA FUNCION ESTA HECHA PARA VER TODOS LOS DATOS QUE DEVUELVE EL USERAGENT *****//
     @RequestMapping(value = "/InicioExtendido", method = RequestMethod.GET, produces = "text/plain")
     public String AcercaDe(@RequestHeader( value = "User-Agent" ) String User) {
         UserAgent useragent = UserAgent.parseUserAgentString(User);
         Browser browser = useragent.getBrowser();
         OperatingSystem os = useragent.getOperatingSystem();
         Version version = useragent.getBrowserVersion();

         String mensaje = "Sus datos";

         // Datos basicos del navegador
         mensaje = mensaje + "\nTipo de Navegador: " + browser.getBrowserType().getName();
         mensaje = mensaje + "\nNombre Navegador: " + browser.getName();
         mensaje = mensaje + "\nRender del Navegador: " + browser.getRenderingEngine();
         mensaje = mensaje + "\n---------------------------------------";

         // Datos de version del navegador
         mensaje = mensaje + "\nVersión del Navegador: " + version.getVersion();
         mensaje = mensaje + "\nMajor Version: " + version.getMajorVersion();
         mensaje = mensaje + "\nMinor Version: " + version.getMinorVersion();
         mensaje = mensaje + "\nProductor: " + browser.getManufacturer().getName();
         mensaje = mensaje + "\n---------------------------------------";

         // Datos del Sistema
         mensaje = mensaje + "\nNombre del Sistema: " + os.getName();
         mensaje = mensaje + "\nProductor del Sistema: " + os.getManufacturer();
         mensaje = mensaje + "\nGrupo del Sistema: " + os.getGroup().getName();
         mensaje = mensaje + "\n---------------------------------------";

         // Datos del Dispositivo
         mensaje = mensaje + "\nDispositivo: " + os.getDeviceType().getName();

         return mensaje;
     }

     @GetMapping( "/Todos" )
     public List<Usuario> TraerTodos() {
         return service.findAll();
     }

     @GetMapping( "/Navegador/MasUsado" )
     public String NavegadorMasUsado() {
         Map<String, Long> hashmap = new HashMap<>();
         hashmap.put("Chrome", service.TotalNavegador("Chrome"));
         hashmap.put("Micrososft", service.TotalNavegador("Micrososft Edge"));
         hashmap.put("Firefox", service.TotalNavegador("Firefox"));
         return this.TraerMaximo(hashmap);
     }

     @GetMapping( "/Sistema/MasUsado" )
     public String SistemaMasUsado() {
         Map<String, Long> hashmap = new HashMap<>();
         hashmap.put("Windows 10", service.TotalSistema("Windows 10"));
         hashmap.put("Windows 8", service.TotalSistema("Windows 8"));
         hashmap.put("Windows 7", service.TotalSistema("Windows 7"));
         hashmap.put("Windows Vista", service.TotalSistema("Windows Vista"));
         hashmap.put("Windows XP", service.TotalSistema("Windows XP"));
         return this.TraerMaximo(hashmap);
     }

     @GetMapping( "/Sistema/{OsName}" )
     public Object BuscarPorSistema(@PathVariable( "OsName" ) String sistema) {
         return service.BuscarXSistema(sistema);
     }

     @GetMapping( "/Navegador/{BrowserName}" )
     public Object BuscarPorNavegador(@PathVariable( "BrowserName" ) String navegador) {
         return service.BuscarXNavegador(navegador);
     }

     public String TraerMaximo(Map<String, Long> hashmap) {
         Long max = 0L;
         String key = "";
         for (Map.Entry<String, Long> entry : hashmap.entrySet()) {
             if (entry.getValue() > max) {
                 key = entry.getKey();
                 max = entry.getValue();
             }
         }
         return "Navegador: " + key + " Se uso: " + max + " veces";
     }
 }