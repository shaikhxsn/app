# Use official .NET runtime as base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Use .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything and restore dependencies
COPY ["app/app.csproj", "app/"]
RUN dotnet restore "app/app.csproj"

# Copy the rest of the source code and build the app
COPY . .
WORKDIR "/src/app"
RUN dotnet publish -c Release -o /app/publish

# Final stage: Create container with built app
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "app.dll"]
