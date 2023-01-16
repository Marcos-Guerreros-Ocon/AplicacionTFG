# Introducción
Una aplicación para llevar una librería 
---
##Usuarios:
-	Vendedor : Aquel que vende libros
-	Responsable: Aquel que gestiona el stock de los libros y de los vendedores
---
#Funcionalidades: 
- Dar de alta, baja y modificación libros
-	Permitir dar de alta y baja nuevos géneros libros.
--	No se podrá dar de baja un género si existen libros asociados al género.
-	Para el proceso de alta de un libro:
--	Introducir el ISBN del libro.
--	Introducir el título del libro.
--	Introducir el autor del libro.
--	Ofrecer un listado cerrado de géneros de libros (Terror, Ficción…) para que el usuario elija una.
--	Introducir la edición del libro.
--	Introducir el stock inicial del libro
--	Cuando el stock del libro sea 0 los vendedores no podrán vender ese libro.
-	Para el proceso de alta de un vendedor:
--	Introducir el nombre del vendedor.
--	Introducir los apellidos del vendedor.
--	Introducir el correo del vendedor.
--	Introducir la contraseña del vendedor.
-	La aplicación ofrecerá un listado de los libros pudiendo filtrar por autor, género o existencias.
-	Si un vendedor realiza una venta se almacenará en un histórico.
