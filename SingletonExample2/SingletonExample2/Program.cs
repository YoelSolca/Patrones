using SingletonExample2;

MySingleton instance1 = MySingleton.GetInstance();

Console.WriteLine($"Instancia 1 ID: {instance1.Id}");

MySingleton instance2 = MySingleton.GetInstance();
Console.WriteLine($"Instancia 2 ID: {instance2.Id}");

MySingleton instance3 = MySingleton.GetInstance();
Console.WriteLine($"Instancia 3 ID: {instance3.Id}");

