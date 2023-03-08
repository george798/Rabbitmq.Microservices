#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rabbitmq.Microservices.Banking.Api/Rabbitmq.Microservices.Banking.Api.csproj", "Rabbitmq.Microservices.Banking.Api/"]
RUN dotnet restore "Rabbitmq.Microservices.Banking.Api/Rabbitmq.Microservices.Banking.Api.csproj"
COPY . .
WORKDIR "/src/Rabbitmq.Microservices.Banking.Api"
RUN dotnet build "Rabbitmq.Microservices.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rabbitmq.Microservices.Banking.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rabbitmq.Microservices.Banking.Api.dll"]