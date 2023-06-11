using System.Reflection;
using System.Runtime.Serialization;

namespace HomeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Misha", "Chmil", "+3806723742");

            Console.WriteLine("Enter prop name:");
            var propName = Console.ReadLine();

            Console.WriteLine(GetValue(person, propName));

            ChangeValue(person, propName);

            Console.WriteLine(GetFields(person)); 

            string str = Console.ReadLine();
            Console.WriteLine(GetFields(Serialization(str, person.GetType())));
            Console.WriteLine(GetFields(GenericSerialization<Person>(str)));
        }
        public static object GetValue(object ins, string propName)
        {
            var prop = ins.GetType().GetProperty(propName);
            var value = prop.GetValue(ins);
            if (value != null)
            {
                return value;
            }
            else
            {
                throw new ArgumentNullException(propName);
            }
        }
        public static void ChangeValue(object ins, string propName)
        {
            var prop = ins.GetType().GetProperty(propName);
            Console.WriteLine("Enter new value:");
            var value = Console.ReadLine();
            prop.SetValue(ins, value);
        }
        public static string GetFields(object ins)
        {
            string result = "";
            var type = ins.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                result += property.Name + ":" + property.GetValue(ins) + ";";             
            }
            return result;
        }
        public static object Serialization(string str, Type ins)
        {
           var resultObj = Activator.CreateInstance(ins);
            var fields = str.Split(';');
            foreach (var field in fields)
            {
                if(field != null && field != "")
                {
                    var values = field.Split(":");
                    var fieldName = values[0];
                    var fieldValue = values[1];
                    var prop = resultObj.GetType().GetProperty(fieldName);
                    prop.SetValue(resultObj, fieldValue);
                }                
            }
            return resultObj;
        }
        public static T GenericSerialization<T>(string str) where T : new()
        {
            var resultObj = new T();
            var fields = str.Split(';');
            foreach (var field in fields)
            {
                if (field != null && field != "")
                {
                    var values = field.Split(":");
                    var fieldName = values[0];
                    var fieldValue = values[1];
                    var prop = resultObj.GetType().GetProperty(fieldName);
                    prop.SetValue(resultObj, fieldValue);
                }
            }
            return resultObj;
        }

    }
}