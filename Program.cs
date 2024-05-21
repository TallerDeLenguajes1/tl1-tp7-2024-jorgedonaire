// using EspacioCalculadora;
// using Microsoft.VisualBasic;

// Calculadora miCalculadora = new Calculadora();

// // miCalculadora.Limpiar();
// bool repetirCalculadora = true, repetirIngreso = false;
// Console.WriteLine("**** CALCULADORA ****");
// do
// {
//     Console.WriteLine("Ingrese la operacion ");
//     Console.WriteLine("+");
//     Console.WriteLine("-");
//     Console.WriteLine("*");
//     Console.WriteLine("/");
//     Console.WriteLine("O presione x para finalizar");
//     string operandoIngresado = Console.ReadLine();
//     switch (operandoIngresado)
//     {
//         case "+":
//             do
//             {
//                 Console.WriteLine("Ingrese el numero a sumar: ");
//                 string numeroIngresado = Console.ReadLine();
//                 bool control = double.TryParse(numeroIngresado,out double numeroConvertido);
//                 if (control)
//                 {
//                     miCalculadora.Sumar(numeroConvertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un numero");
//                     repetirIngreso = true;
//                 }
//             } while (repetirIngreso);
//         break;
//         case "-":
//             do
//             {
//                 Console.WriteLine("Ingrese el numero a restar: ");
//                 string numeroIngresado = Console.ReadLine();
//                 bool control = double.TryParse(numeroIngresado,out double numeroConvertido);
//                 if (control)
//                 {
//                     miCalculadora.Restar(numeroConvertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un numero");
//                     repetirIngreso = true;
//                 }
//             } while (repetirIngreso);
//         break;
//         case "*":
//             do
//             {
//                 Console.WriteLine("Ingrese el numero por el que multiplicara: ");
//                 string numeroIngresado = Console.ReadLine();
//                 bool control = double.TryParse(numeroIngresado,out double numeroConvertido);
//                 if (control)
//                 {
//                     miCalculadora.Multiplicar(numeroConvertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un numero");
//                     repetirIngreso = true;
//                 }
//             } while (repetirIngreso);
//         break;
//         case "/":
//             do
//             {
//                 Console.WriteLine("Ingrese el numero por el que va dividir: ");
//                 string numeroIngresado = Console.ReadLine();
//                 bool control = double.TryParse(numeroIngresado,out double numeroConvertido);
//                 if (control)
//                 {
//                     miCalculadora.Sumar(numeroConvertido);
//                 }else
//                 {
//                     Console.WriteLine("ERROR. Ingrese un numero");
//                     repetirIngreso = true;
//                 }
//             } while (repetirIngreso);
//         break;
//         case "x":
//             repetirCalculadora = false;
//         break;
//     }
// } while (repetirCalculadora);

// Console.WriteLine("El resultado es:");
// double Resultado = miCalculadora.Resultado;
// Console.WriteLine(Resultado);