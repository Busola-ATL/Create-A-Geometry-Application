using ShapesLib;
﻿using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryApp.ShapesLib;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};
IConfiguration configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();


IServiceCollection services = new ServiceCollection();


services.AddFeatureManagement(configuration);


IServiceProvider serviceProvider = services.BuildServiceProvider();


IFeatureManager featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

 
    if (await featureManager.IsEnabledAsync("Square"))
    {
        double result;
    
        Console.WriteLine("Enter value for Lenght");

    

        if(double.TryParse(Console.ReadLine(), out result)){
            Square square = new Square(result);
            Console.WriteLine("Area: {0}msqr ", square.CalculateArear());
            Console.WriteLine("Perimeter: {0}m ", square.CalculatePerimeter());
        }
    }

//Condition checking if only Rectangle is turned ON
else 
    if (await featureManager.IsEnabledAsync("Rectangle"))
    {
        double lenghtResult;
        double breadthResult;
    
        Console.WriteLine("Enter value for Lenght");
        var lenght = Console.ReadLine();

        Console.WriteLine("Enter value for Breadth");
        var breadth = Console.ReadLine();
          
        if(double.TryParse(lenght, out lenghtResult))
        {
            if(double.TryParse(breadth, out breadthResult)){
                Rectangle rectangle = new Rectangle(lenghtResult, breadthResult);
                Console.WriteLine("Area of rectangle is: {0}msqr ", rectangle.CalculateArear());
                Console.WriteLine("Perimeter of rectangle is: {0}m ", rectangle.CalculatePerimeter());
            }
        }
    }

    else
        if(await featureManager.IsEnabledAsync("Triangle")){
            Console.WriteLine("Enter value for base");
            var getBase = Console.ReadLine();

            Console.WriteLine("Enter value for height");
            var height = Console.ReadLine();
            double baseResult;
            double heightthResult;
    
        if(double.TryParse(getBase, out baseResult))
        {
            if(double.TryParse(height, out heightthResult)){
                Triangle triangle = new Triangle(baseResult, heightthResult);
                Console.WriteLine("Area: {0} msqr", triangle.CalculateArear());
                Console.WriteLine("Perimeter: {0}m ", triangle.CalculatePerimeter());      
            }
        }
    }
 
     else
        {
            Console.WriteLine("Wrong value added!!");
        }
        