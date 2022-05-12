# CLR

## CLR: Common Language Runtime

Es el núcleo del framework, es el que compila el código C#.

---

## Base Class Library Support

Básicamente es una librería que va a soportar todas las clases que nosotros tengamos en nuestro código.

Es una librería base de soporte para algunas características.

Por ejemplo, si hay unas características de la versión anterior o de la versión nueva, pues esta librería la va a soportar y la va a ayudar a que compile correctamente.

---

## Thread Support

Soporta las características de programación asíncrona.

---

## com Marshaller

Es la interoperabilidad o la compatibilidad que tenemos con los componentes *com*.

Los componentes *com* son básicamente algunas, por decirlo así, componentes que tenía el punto net framework desde su versiones pasadas desde la versión 1 hasta la versión 3.5 del net framework, pues utilizábamos componentes *com*.

---

## Type Checker

Sirve básicamente para chequear o parsear todos los tipos que nosotros manejamos al momento de escribir un código.

---

## Exception Manager

El administrador de excepciones, que sirve básicamente igual que las excepciones en el lenguaje.

Estas excepciones a nivel de compilación sirven para que tengamos algún mensaje de advertencia o en el peor de los casos, un mensaje de error al momento de compilar nuestro proyecto.

---

## Security Engine

Es el apartado de seguridad que maneja el CLR para evitar ciertos ataques que puedan malograr en sí el proyecto.

Podemos tal vez escribir código malicioso en nuestro archivo CS pero esta capa de seguridad que maneja el error nos lo va a bloquear.

---

## Debug Engine

Es la máquina de debug que tiene el CLR para depurar ciertas entradas en el código de C#.

---

## JIT Compiler (JIT: Just in Time)

Sirve para que nosotros podamos portar nuestro producto exe a cualquiera de las plataformas que podamos.

---

## Code Manager

Sirve para el administrador de código que trabaja conjuntamente con el Type Checker.

---

## Garbage Collector (recolector de basura)

Nos ayuda a administrar mejor los espacios en memoria.

Sirve también para que nosotros al trabajar con este lenguaje que es un lenguaje de alto nivel, no requiere ciertas configuraciones que un programador básico necesita.

Por ejemplo, cuando alguien trabaja con C++, necesita pues liberar memoria, recursos al momento de utilizar ciertos tipos o variables al momento que está programando.

Es por eso que se ha creado este Garbage Collector tanto para el CLR como también para el lenguaje dentro del framework en sí.

---

## CLR Loader

Carga el código en sí y lo mete al motor de compilación que tiene el CLR.