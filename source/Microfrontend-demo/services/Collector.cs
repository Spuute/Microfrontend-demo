using System.Reflection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Microfrontend_demo.services
{
    public static class Collector
    {
        public static List<Type> MenuItems { get; } = new List<Type>();
        public static List<Assembly> Assemblies { get; } = new List<Assembly>();
        public static void AddLibrary<T>(this RootComponentMappingCollection _){
            var assembly = typeof(T).Assembly;
            Assemblies.Add(assembly);
            MenuItems.AddRange(assembly.GetTypes().Where(x => x.Name.Equals("NavItem")));
        }
    }
}