# See https://aka.ms/customizecontainer for debugging info

# -------------------------------
# Base runtime image
# -------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# -------------------------------
# Build and restore image
# -------------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj files for restore
COPY ["WebApp-Kubernetes/practice.API.csproj", "WebApp-Kubernetes/"]
COPY ["practice.Application/practice.Application.csproj", "practice.Application/"]

# Restore dependencies
RUN dotnet restore "WebApp-Kubernetes/practice.API.csproj"

# Copy everything
COPY . .

# Build the API project
WORKDIR "/src/WebApp-Kubernetes"
RUN dotnet build "practice.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# -------------------------------
# Publish image
# -------------------------------
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "practice.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# -------------------------------
# Final runtime image
# -------------------------------
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "practice.API.dll"]
