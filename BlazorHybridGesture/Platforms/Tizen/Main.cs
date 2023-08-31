using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace BlazorHybridGesture;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
