# GrpcCalculator

A simple calculator application demonstrating gRPC communication between a .NET 8 server and a Go client.

## 🧪 Project Structure

- **.NET Server**: Located in the `dotnet-server` folder
- **Go Client**: Located in the `go-client` folder
- **Protocol Buffers**: Shared `.proto` files in the `proto` folder

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Go 1.24+](https://go.dev/dl/)
- [Docker](https://www.docker.com/get-started) (optional, for containerization)

### Clone the repository

```bash
git clone https://github.com/faojul/GrpcCalculator.git
cd GrpcCalculator
````

##Build and run the .NET gRPC server
```bash
cd dotnet-server/GrpcCalculator.API
dotnet build
dotnet run
````
The server will start and listen on port 7280.

##Build and run the Go gRPC client
````bash
cd go-client
go run main.go
````
The client will connect to the server and perform an Add operation.



