﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Native.Csharp.UI
{
	/// <summary>
	/// App.xaml 的交互逻辑
	/// </summary>
	public partial class App : Application
	{
		[STAThread]
		 public static void Main()
		{
			new App().Run(new Views.MainView());
		}
	}
}