## ¿String es una tipo por valor o un tipo por referencia?

**string** es un tipo por referencia en C#, pero se comporta como si fuera inmutable.
Esto significa que cuando se modifica un **string**, en realidad se crea una nueva instancia en memoria con el nuevo valor, y la variable pasa a apuntar a esa nueva dirección.
No se modifica el contenido original, por eso se dice que es inmutable.

## ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape permiten representar caracteres especiales dentro de cadenas de texto. Algunas de las más comunes en C# son:

| Secuencia | Significado                  |
| --------- | ---------------------------- |
| `\n`      | Nueva línea (salto de línea) |
| `\r`      | Retorno de carro             |
| `\t`      | Tabulación horizontal        |
| `\\`      | Barra invertida (`\`)        |
| `\'`      | Comilla simple               |
| `\"`      | Comilla doble                |
| `\0`      | Carácter nulo                |
| `\a`      | Alerta (beep)                |
| `\b`      | Retroceso (backspace)        |
| `\f`      | Salto de página              |
| `\v`      | Tabulación vertical          |

¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?
    - **@** (Verbatim string literal): Permite escribir cadenas tal cual aparecen, ignorando las secuencias de escape.
    Se usa principalmente para rutas de archivos o textos multilinea.

    - $ (Interpolated string): Permite insertar variables o expresiones directamente dentro de la cadena utilizando {}.