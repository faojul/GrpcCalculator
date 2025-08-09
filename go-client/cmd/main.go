package main

import (
	"context"
	"fmt"
	"log"
	"time"

	"google.golang.org/grpc"
	// Replace this with your actual generated protobuf Go package import path
	pb "github.com/faojul/grpccalculator/go-client"
	"google.golang.org/grpc/credentials"
)

func main() {
	// Connect to the gRPC server
	creds := credentials.NewClientTLSFromCert(nil, "")
	conn, err := grpc.NewClient("localhost:7280", grpc.WithTransportCredentials(creds))
	if err != nil {
		log.Fatalf("Could not connect: %v", err)
	}
	defer conn.Close()

	// Create a new Calculator client from the connection
	client := pb.NewCalculatorClient(conn)

	// Prepare the request with numbers to add
	req := &pb.CalculationRequest{
		A: 10,
		B: 25,
	}

	// Create a context with 1-second timeout for the RPC call
	ctx, cancel := context.WithTimeout(context.Background(), time.Second)
	defer cancel()

	res, err := client.Add(ctx, req)
	if err != nil {
		log.Fatalf("Error calling Add: %v", err)
	}

	fmt.Printf("Result: %d\n", res.Result)
}
