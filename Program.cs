// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos a la pizzeria el FERXXO MOR");
Console.WriteLine("Por favor elija (1 o 2) para elegir que tipo de pizza quiere"
+"\n1-Pizza Vegetariana"+"\n2-Pizza NOVegetariana");

int pizza = int.Parse(Console.ReadLine());

switch(pizza){
    case 1:
    Console.WriteLine("Este es el menu: "+"\n1-Pimiento"+"\n2-Champoñones");
    Console.WriteLine("Por favor escriba (1 o 2) para elegir el ingrediente");
    int ingredienteVegetariana = int.Parse(Console.ReadLine());
    if(ingredienteVegetariana == 1){
    Console.WriteLine("Su eleccion es: Vegetariana"
    +"\nEl ingrediente elegido es: Pimiento"
    +"\nAdicional la pizza trae Queso mozzarella y tomate");
    }
    if(ingredienteVegetariana == 2){
    Console.WriteLine("Su eleccion es: Vegetariana"
    +"\nEl ingrediente elegido es: Champiñones"
    +"\nAdicional la pizza trae Queso mozzarella y tomate");
    }
    
    break;
    case 2:
    Console.WriteLine("Este es el menu: "+"\n1-Pepperoni"+"\n2-Salami"+"\n3-Pollo");
    Console.WriteLine("Por favor escriba (1,2 o 3) para elegir un solo ingrediente");
    int ingredienteNoVegetariana = int.Parse(Console.ReadLine());
    if(ingredienteNoVegetariana == 1){
    Console.WriteLine("Su eleccion es: No Vegetariana"
    +"\nEl ingrediente elegido es: Pepperoni"
    +"\nAdicional la pizza trae Queso mozzarella y tomate");
    }
    if(ingredienteNoVegetariana == 2){
    Console.WriteLine("Su eleccion es: No Vegetariana"
    +"\nEl ingrediente elegido es: Salami"
    +"\nAdicional la pizza trae Queso mozzarella y tomate");
    }
    if(ingredienteNoVegetariana == 3){
    Console.WriteLine("Su eleccion es: No Vegetariana"
    +"\nEl ingrediente elegido es: Pollo"
    +"\nAdicional la pizza trae Queso mozzarella y tomate");
    }
    break;
    
}
Console.WriteLine("Su pedido ha sido solicitado, en breves momentos se traera el pedido \nGracias");