using Microsoft.Extensions.AI;
using OllamaSharp;

IChatClient client = new OllamaApiClient(new Uri("http://localhost:11434"), "llama3.2");

// send prompt to model
string prompt = "What is Domain-Driven Design? Explain it in 20 words.";
Console.WriteLine($"user prompt -> {prompt}");

ChatResponse response = await client.GetResponseAsync(prompt);
Console.WriteLine($"model response -> {response}");
Console.WriteLine($"Tokens used: in= {response.Usage?.InputTokenCount}, out={response.Usage?.OutputTokenCount}");