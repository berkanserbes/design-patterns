﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Example1;

public class Singleton
{
	private static Singleton? _instance;

	private Singleton() { }

	public static Singleton GetOrCreateInstance()
	{
		if (_instance == null)
		{
			_instance = new Singleton();
		}

		return _instance;
	}
}
