// See https://aka.ms/new-console-template for more information
using Figuricas;

Console.WriteLine("Hello, World!");

Circulo MiCirculo = new();
Cuadrado MiCuadrado = new(2) { X = 7 };
Triangulo MiTriangulo = new (1,2,3);

var MiCirculo2 = new Circulo();
var MiCuadrado2 = new Cuadrado(Lado: 2) { X = 8 };
var MiTriangulo2 = new Triangulo(Lado3: 3, Lado2:8, Lado1: 89);

IFigura MiCirculo3 = new Circulo();
IFigura MiCuadrado3 = new Cuadrado(Lado: 8) { X = 8 };
IFigura MiTriangulo3 = new Triangulo(Lado1: 6, Lado2: 7, Lado3: 4);

TableroDeDibujo Tablero = new();
Tablero.Add(MiCirculo);
Tablero.Add(MiCuadrado);
Tablero.Add(MiTriangulo);
Tablero.Add(MiCirculo2);
Tablero.Add(MiTriangulo3);
Tablero.Add(MiTriangulo2);
Tablero.Add(MiCirculo3);
Tablero.Add(MiCuadrado2);
Tablero.Add(MiCuadrado3);
Tablero.Mezcla();

Console.WriteLine($"Superficie Total Tablero: {Tablero.SuperficieTotal()}");
