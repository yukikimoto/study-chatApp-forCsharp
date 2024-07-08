// See https://aka.ms/new-console-template for more information
using System;
using DotNetEnv;
using Microsoft.SemanticKernel;


// .envファイルをロード
Env.Load();

// .envファイルの内容を取得
string apiKey = Env.GetString("API_KEY");


// カーネルを作成
var builder = Kernel.CreateBuilder();

// Azure OpenAI Chat Completion を追加
builder.AddAzureOpenAIChatCompletion(
    "<<gpt 3.5 turbo のモデルのデプロイ名>>",
    "https://<<Azure OpenAI Service のリソース名>>.openai.azure.com/",
    "<<Azure OpenAI Service の API キー>>");

// カーネルをビルド
var kernel = builder.Build();


// プロンプトを送信して返答を受け取る
var result = await kernel.InvokePromptAsync(
    """
    Hello, world! と表示する C# のプログラムを書いてください。
    """);

Console.WriteLine(result.GetValue<string>());