/* URL: https://www.codewars.com/kata/create-a-simple-class-at-runtime/train/csharp
Solution by EatYourBeets
 
Create A Class at Runtime

Your method will accept as arguments a string containing the class name, a dictionary String -> Type containing the properties, and a ref to the actual Type of the class after it has been created.
You should check if a class already exists in the same assembly and return false if so, also you should make sure to create every class in the same assembly, let's call it "RuntimeAssembly", namespace is optional, but the class names will be passed to your method without any namespace.

The properties of each of your classes will then be accessed and modified normally, e.g:

properties = new Dictionary<string, Type> { { "AString", typeof(string) } };    
Kata.DefineClass("SimpleClass", properties, ref myType);    
myInstance = CreateInstance(myType);    
myInstance.AString = "Hi";
You will pass the kata if none of these operations throw an exception, and if the values are actually changed.


Example Tests:
public class SomeClass
{} // This class should not conflict with your runtime classes  

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public partial class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Random rand = new Random();
            Type myType = typeof(object);
            Dictionary<string, Type> properties;

            // Define first class
            properties = new Dictionary<string, Type> { { "SomeInt", typeof(int) }, { "SomeString", typeof(string) }, { "SomeObject", typeof(object) } };
            Kata.DefineClass("SomeClass", properties, ref myType);
            // Instantiate first class
            var myInstance = CreateInstance(myType);
            myInstance.SomeObject = myInstance;
            myInstance.SomeString = "Hey there";
            myInstance.SomeInt = 3;
            Console.WriteLine($"{myInstance.SomeObject}: {myInstance.SomeString}, {myInstance.SomeInt}");

            // Define second class
            properties = new Dictionary<string, Type> { { "AnotherObject", typeof(object) }, { "SomeDouble", typeof(double) }, { "AnotherString", typeof(string) } };
            Kata.DefineClass("AnotherClass_N" + rand.Next(100), properties, ref myType);
            // Instantiate second class
            myInstance = CreateInstance(myType);
            myInstance.AnotherObject = "User: ";
            myInstance.AnotherString = "My lucky number is ";
            myInstance.SomeDouble = 92835768;
            Console.WriteLine($"{myInstance.AnotherObject}: {myInstance.AnotherString} {myInstance.SomeDouble} ");

            // Try to redefine first class
            if (Kata.DefineClass("SomeClass", properties, ref myType) == true)
                Assert.Fail("This class is already defined");
        }
    }
}

 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace CodeWarsSolutions.Beta
{

    public static class SimpleClassAtRuntime
    {
        private static ModuleBuilder moduleBuilder = null;

        public static bool DefineClass(string className, Dictionary<string, Type> properties, ref Type actualType)
        {
            if (moduleBuilder == null)
            {
                AssemblyName assemblyName = new AssemblyName();
                assemblyName.Name = "RuntimeAssembly";
                AssemblyBuilder assemblyBuilder = Thread.GetDomain().DefineDynamicAssembly(
                assemblyName, AssemblyBuilderAccess.Run);
                moduleBuilder = assemblyBuilder.DefineDynamicModule("ModuleName");
            }

            try
            {
                TypeBuilder typeBuilder = moduleBuilder.DefineType(className, TypeAttributes.Public);
                foreach (var kv in properties)
                {
                    FieldBuilder customerNameBldr = typeBuilder.DefineField(kv.Key.ToLower(),
                                                    kv.Value,
                                                    FieldAttributes.Private);

                    MethodAttributes getSetAttr = MethodAttributes.Public | MethodAttributes.SpecialName |
                                                  MethodAttributes.HideBySig;

                    PropertyBuilder custNamePropBldr = typeBuilder.DefineProperty(kv.Key, PropertyAttributes.None, kv.Value, null);
                    MethodBuilder custNameGetPropMthdBldr = typeBuilder.DefineMethod("get_" + kv.Key.ToLower(),
                                                            getSetAttr, kv.Value, Type.EmptyTypes);
                    
                    ILGenerator custNameGetIL = custNameGetPropMthdBldr.GetILGenerator();

                    custNameGetIL.Emit(OpCodes.Ldarg_0);
                    custNameGetIL.Emit(OpCodes.Ldfld, customerNameBldr);
                    custNameGetIL.Emit(OpCodes.Ret);

                    MethodBuilder custNameSetPropMthdBldr = typeBuilder.DefineMethod("set_" + kv.Key.ToLower(),
                                                            getSetAttr, null, new Type[] { kv.Value });

                    ILGenerator custNameSetIL = custNameSetPropMthdBldr.GetILGenerator();

                    custNameSetIL.Emit(OpCodes.Ldarg_0);
                    custNameSetIL.Emit(OpCodes.Ldarg_1);
                    custNameSetIL.Emit(OpCodes.Stfld, customerNameBldr);
                    custNameSetIL.Emit(OpCodes.Ret);

                    custNamePropBldr.SetGetMethod(custNameGetPropMthdBldr);
                    custNamePropBldr.SetSetMethod(custNameSetPropMthdBldr);
                }

                actualType = typeBuilder.CreateType();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
