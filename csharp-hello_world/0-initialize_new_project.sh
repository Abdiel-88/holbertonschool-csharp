#!/usr/bin/env bash

# Create a new directory for the project
mkdir -p 0-new_project

# Navigate into the project directory
cd 0-new_project

# Initialize a new C# console project
dotnet new console

# Rename the Program.cs file as required by your task guidelines
mv Program.cs 0-new_project.cs

# Navigate back to the original directory
cd ..

# Output success message
echo "The template 'Console Application' was created successfully."
