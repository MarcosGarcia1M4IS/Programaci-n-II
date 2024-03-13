// See https://aka.ms/new-console-template for more information

//Ruta del archivo para almacenar productos

using REPOSITORY;

string archivoProductos = "productos.txt";

//crear una instancia del repositorio de productos

IProductoREPOSITORY productoREPOSITORY = new ProductoRepositoryArchivo(archivoProductos);

//crear una instancia del gestor de productos
//usando el repositorio

GestorProductos gestorProductos = new GestorProductos(productoREPOSITORY);

//agregamos algunos productos de ejemplo

gestorProductos.AgergarProducto(new Producto { Nombre = "Azucar", Precio = 15m });

//Mostrar todos los productos 
Console.WriteLine("Todos los productos");
foreach (var producto in gestorProductos.ObtenerTodosLosProductos())
    Console.WriteLine($"Nombre: {producto.Nombre}, " + $"precio: {producto.Precio}");
