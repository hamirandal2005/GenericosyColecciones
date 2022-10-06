using PruebaGenericos;

AlmacenObjetos archivos = new AlmacenObjetos(4);

//archivos.Agregar("Luisa");
//archivos.Agregar("Lili");
//archivos.Agregar("LiliMiAmor");
//archivos.Agregar("LiliMiCorazon");

archivos.Agregar(new Empleado(15000));
archivos.Agregar(new Empleado(25000));
archivos.Agregar(new Empleado(5000));
archivos.Agregar(new Empleado(20000));
archivos.Agregar(new Empleado(15000));

//string nombrePersona = (string)archivos.GetElemento(2);
//Console.WriteLine(nombrePersona);   

Empleado salarioEmpleado = (Empleado)archivos.GetElemento(2);
Console.WriteLine(salarioEmpleado.Salario);

//*********************************************************************************
AlamacenObjetos2<Empleado> empleados = new AlamacenObjetos2<Empleado>(4);
empleados.Agregar(new Empleado(15000));
empleados.Agregar(new Empleado(25000));
empleados.Agregar(new Empleado(5000));
empleados.Agregar(new Empleado(20000));
empleados.Agregar(new Empleado(15000));

Empleado salario = (Empleado)empleados.GetElemento(2);
Console.WriteLine(salario.Salario);