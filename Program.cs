using IntroduccionAlEncapsulamiento;

CuentaBancaria cuenta1 = new CuentaBancaria(15543, 1500.00, 1507); //cuenta1 es puntero apunta al objeto cuenta1
CuentaBancaria cuenta2 = new CuentaBancaria(45321, 3000.65, 4556);


cuenta1.MostrarInfo();
cuenta2.MostrarInfo();

cuenta1.Retirar(150, 1506);
cuenta1.Retirar(150, 1507);
cuenta2.Depositar(1000, 4555);
cuenta2.Depositar(1000, 4556);

Console.WriteLine("ACTUALIZADO");
cuenta1.MostrarInfo();
cuenta2.MostrarInfo();