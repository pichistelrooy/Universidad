# TP4

REFERECNIAS: 
En localhost:8080/TP4/Inicio nos trae agrega y muestra ID, Navegador y Sistema.
En localhost:8080/TP4/InicioExtendido nos muestra todos los datos del UserAgent.
En localhost:8080/TP4/Todos nos muestra todos los usarios que nos visitaron con sus datos(id, navegador,sistema).
En localhost:8080/TP4/Sistema/MasUsado nos muestra el sistema que mas se uso y cuantas veces.
En localhost:8080/TP4/Sistema/{OsName} nos muestra los usuarios que nos visitaron con el sistema declarado entre los corchetes.
En localhost:8080/TP4/Navegador/{BrowserName} nos muestra los usuarios que nos visitaron con el sistema declarado entre los corchetes



GOALS
-mvn clean: Borra el directorio de salida(TARGET)
-mvn compile: compila el proyecto y deja el resultado en TARGET/CLASSES
-mvn package: empaqueta el proyecto y lo dejara en TARGET/...JAR
-mvn install: guarda el proyecto en el repositorio
-mvn test: compila los test y los ejecuta.

SCOPES
Compile: es el valor por defecto, se utiliza en todos los casos(compilar, ejecutar, etc)
Provided: tambien se utiliza en todos los casos, pero se espera que el JAR sea suministrado por la JDK o el contenedor. Es decir, no se incluira en el empaquetar el proyecto, ni el repositorio. 
Runtime: no se utiliza para compilar, pero si es necesario para ejecutar.
Test: solo se utiliza para compilar o ejecutar los test
System: es similar a provided, pero eres tu el que tiene que suministrar el jar. no se incluira en el empaquetar el proyecto, ni el repositorio.
Import: Este alcance solo se admite en una dependencia de tipo pom en la sección <dependencyManagement>. Indica la dependencia que se reemplazará con la lista efectiva de dependencias en la sección <dependencyManagement> del POM especificado. Dado que son reemplazados, las dependencias con un alcance de importación en realidad no participan en la limitación de la transitividad de una dependencia.
  
  Los Arquetipos para MAVEN son plantillas. MAVEN gracias a ellos generan una estructura de directorios y ficheros.
  
  Estructura ejemplo POM MAVEN:
  
  <?xml version="1.0" encoding="UTF-8"?>
<project xmlns="http://maven.apache.org/POM/4.0.0" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
	xsi:schemaLocation="http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd">
	<modelVersion>4.0.0</modelVersion>

	<groupId>com.utn</groupId>
	<version>0.0.1-SNAPSHOT</version>
	<packaging>jar</packaging>

	<name>tp4</name>
	<description>Demo project for Spring Boot</description>

	<parent>
		<groupId>org.springframework.boot</groupId>
		<artifactId>spring-boot-starter-parent</artifactId>
		<version>2.0.1.RELEASE</version>
		<relativePath/> <!-- lookup parent from repository -->
	</parent>

	<properties>
		<project.build.sourceEncoding>UTF-8</project.build.sourceEncoding>
		<project.reporting.outputEncoding>UTF-8</project.reporting.outputEncoding>
		<java.version>1.8</java.version>
	</properties>

	<dependencies>
		<dependency>
			<groupId>org.springframework.boot</groupId>
			<artifactId>spring-boot-starter-data-jpa</artifactId>
		</dependency>
  </dependencies>
  
  <build>
		<plugins>
			<plugin>
				<groupId>org.springframework.boot</groupId>
				<artifactId>spring-boot-maven-plugin</artifactId>
			</plugin>
		</plugins>
	</build>

</project>


La diferencia entre Arquetipo y Artefacto es que el Arquetipo es el modelo original a partir del cual se hacen todas las demás cosas del mismo tipo y Artefacto es un archivo, generalmente un JAR, que se implementa en un repositorio de Maven.
Una construcción Maven produce uno o más artefactos, como un JAR compilado y un JAR de "fuentes".


@Component es un estereotipo genérico para cualquier componente gestionado por Spring. @Repository , @Service y @Controller son especializaciones de @Component para casos de uso más específicos, por ejemplo, en las capas de persistencia, servicio y presentación, respectivamente. Por lo tanto, si elige entre usar @Component o @Service para su capa de servicio, @Service es claramente la mejor opción. Del mismo modo, como se indicó anteriormente, @Repository ya es compatible como un marcador para la traducción automática de excepciones en su capa de persistencia.


se usa POST para crear un recurso en el servidor
se usa GET para obtener un recurso
se usa PUT para cambiar el estado de un recurso o actualizarlo
se usa DELETE para eleminar un recurso
