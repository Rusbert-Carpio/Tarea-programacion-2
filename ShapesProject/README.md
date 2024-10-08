Práctica OOP Herencia
Se requiere realizar los siguientes ejercicios:

Nos dan una escuela. La escuela tiene clases de estudiantes. Cada clase tiene un conjunto de profesores. Cada profesor imparte un conjunto de cursos. Los estudiantes tienen un nombre y un número único en la clase. Las clases tienen un identificador de texto único. Los profesores tienen nombres. Los cursos tienen nombre, recuento de clases y recuento de ejercicios. Tanto los profesores como los estudiantes son personas.

Su tarea es desarrollar las clases (en términos de programación orientada a objetos) junto con sus atributos y operaciones/

        Definir la jerarquía de clases
        Crear un diagrama de clases.
  ![Practica OOP herencia drawio](https://github.com/user-attachments/assets/b5b2906c-a923-4cd0-b070-f78b53e0b592)

----------------------------------Documentación del Diagrama de Clases: Escuela-------------------------------------

Clase Abstracta: Persona
Es una clase base abstracta que contiene atributos y métodos comunes para las personas en la escuela (estudiantes y profesores), donde solamente le asigne el
Atributos:
nombre: string: Contiene el nombre de la persona.

Clase: Estudiantes (Hereda de Persona)
Descripción: Representa a un estudiante en la escuela, que está inscrito en una o más clases.
Atributos:
ID: string: Identificador único del estudiante.
clase: Clase: Relación de uno a muchos, que indica que un estudiante puede estar inscrito en una o más clases.
Métodos:
obtenerID(): Devuelve el identificador único del estudiante.
obtenerNombre(): Devuelve el nombre del estudiante (heredado de Persona).

Clase: Profesores (Hereda de Persona)
Descripción: Representa a un profesor en la escuela, que enseña uno o más cursos.
Atributos:
cursos: List<Curso>: Lista de cursos que el profesor imparte. Un profesor puede enseñar múltiples cursos.
Métodos:
impartirCurso(): Método que indica que el profesor está enseñando un curso.
asignarCurso(curso: Curso): Asigna un curso a la lista de cursos del profesor.

Clase: Clase
Descripción: Representa una clase en la escuela. Es la relación entre profesores y estudiantes.
Atributos:
identificador: string: Identificador único para la clase.
profesores: List<Profesor>: Lista de profesores asignados a esta clase.
estudiantes: List<Estudiante>: Lista de estudiantes inscritos en la clase.
Métodos:
agregarProfesor(profesor: Profesor): Agrega un profesor a la lista de profesores de la clase.
agregarEstudiante(estudiante: Estudiante): Agrega un estudiante a la lista de estudiantes de la clase.
listarProfesores(): Muestra la lista de profesores asignados a la clase.
listarEstudiantes(): Muestra la lista de estudiantes inscritos en la clase.

Clase: Curso
Descripción: Representa un curso que puede ser impartido por un profesor.
Atributos:
nombre: string: El nombre del curso.
recuentoClases: int: Número total de clases que forman parte del curso.
recuentoEjercicios: int: Número total de ejercicios que se encuentran en el curso.
Métodos:
mostrarDetalles(): Muestra la información detallada del curso (nombre, recuento de clases y ejercicios).

-----------------------------------------Relación entre las Clases:----------------------------------------------

Estudiantes - Clase:
Relación de muchos a muchos (1..* a 1..*). Un estudiante puede estar en varias clases y una clase puede tener varios estudiantes.

Profesores - Clase:
Relación de muchos a muchos (1..* a 1..*). Un profesor puede estar asignado a varias clases y una clase puede tener varios profesores.

Profesores - Curso:
Relación de uno a muchos (1..*). Un profesor puede impartir varios cursos, pero cada curso solo puede ser impartido por un profesor a la vez.

---------------------------------------------Segundo Ejercicio-------------------------------------------------------------

2.  Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos. Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). Este método tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2).  Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) con el mismo valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes y calcula el área de cada forma en otra matriz.

--------------------------------------------Explicación de la estructura:------------------------------------------------

Clase abstracta Shape: Tiene dos propiedades Width y Height y un método abstracto CalculateSurface() que será implementado por las clases derivadas.

Clase Rectangle: Hereda de Shape y sobrescribe el método CalculateSurface() para calcular el área del rectángulo.

Clase Triangle: También hereda de Shape y sobrescribe el método para calcular el área del triángulo.

Clase Circle: Hereda de Shape, pero usa el radio tanto para Width como para Height y sobrescribe el método para calcular el área del círculo.

Clase Program: Esta clase contiene el método Main(), donde se crea una matriz de diferentes formas (Shape[] shapes), se calcula el área de cada una, y se imprime en la consola.

Este código muestra el uso de herencia y polimorfismo, ya que cada clase que hereda de Shape implementa su propio cálculo de área mediante el método CalculateSurface().
