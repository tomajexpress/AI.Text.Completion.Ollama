# AI.Text.Completion.Ollama

This repository contains a C# Console application that demonstrates a modern integration of Artificial Intelligence using local Large Language Models (LLMs). The project leverages the latest .NET AI abstractions to communicate with **Ollama** and the **Llama 3.2** model.

## 🚀 Overview

The goal of this project is to showcase how to implement a clean, decoupled AI client using standard Microsoft interfaces. By using `Microsoft.Extensions.AI`, the code remains flexible and ready for professional environments.

### Tech Stack
* **Language:** C# / .NET
* **AI Model:** Llama 3.2 (via Ollama)
* **Key Libraries:**
    * `Microsoft.Extensions.AI`: Standardized abstractions for AI services.
    * `OllamaSharp`: The connector for Ollama integration.

---

## 🛠 Prerequisites

To run this project, you need to have **Ollama** running locally. You can choose one of the following two methods:

### Option 1: Direct Installation (Recommended for Local Dev)
1. Download and install from [ollama.com](https://ollama.com/).
2. Open your terminal and download the model:
   ```bash
   ollama pull llama3.2

### Option 2: Docker Desktop
1. Run the Ollama container:
   ```bash
   docker run -d -v ollama:/root/.ollama -p 11434:11434 --name ollama ollama/ollama
2. Pull the model into the container
   ```bash
   docker exec -it ollama ollama pull llama3.2

---

## 💻 Installation & Usage
1. Clone the repo:
   ```bash
   git clone [https://github.com/your-username/AI.Text.Completion.Ollama.git](https://github.com/your-username/AI.Text.Completion.Ollama.git)

2. Restore and Build: The project will automatically restore the Microsoft.Extensions.AI and OllamaSharp NuGet packages.
   ```bash
   dotnet build
   
3. Run the App:
   ```bash
   dotnet run

---
## 📝 Example Code
The implementation focuses on simplicity and readability, using the IChatClient interface
    
   ```csharp
    using Microsoft.Extensions.AI;
    using OllamaSharp;
    
    // Initialize the client pointing to the local Ollama instance
    IChatClient client = new OllamaApiClient(new Uri("http://localhost:11434"), "llama3.2");
    
    // Send prompt to model
    string prompt = "What is Domain-Driven Design? Explain it in 20 words.";
    ChatResponse response = await client.GetResponseAsync(prompt);
    
    // Output result and metadata
    Console.WriteLine($"Model response -> {response}");
    Console.WriteLine($"Tokens used: In={response.Usage?.InputTokenCount}, Out={response.Usage?.OutputTokenCount}");

