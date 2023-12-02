public class ObjectPrinter
{
    public static void PrintProperties(object obj)
    {
        // Use reflection to get property names and values
        foreach (var property in obj.GetType().GetProperties())
        {
            if (!(property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(obj);
                Console.WriteLine($"{propertyName}: {propertyValue}");

            }
        }
        Console.WriteLine("\n");
    }
}
