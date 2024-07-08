// See https://aka.ms/new-console-template for more information
using System;
using DotNetEnv;

Console.WriteLine("Hello, World!");

// .envファイルをロード
Env.Load();

// .envファイルの内容を取得
string apiKey = Env.GetString("API_KEY");
string testData = Env.GetString("TEST_DATA");

Console.WriteLine("apikey : " + apiKey);
Console.WriteLine("test data : " + testData);