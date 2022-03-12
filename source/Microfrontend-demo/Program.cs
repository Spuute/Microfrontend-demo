using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microfrontend_demo;
using Microfrontend_demo.services;
using Job.lib;
using Job.lib.Components;
using Employee.lib.Pages;
using Employee.lib.Components;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.RootComponents.AddLibrary<Jobs>();
builder.RootComponents.AddLibrary<Employees>();
builder.RootComponents.AddCards<EmployeeCard>();
builder.RootComponents.AddCards<JobCard>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
