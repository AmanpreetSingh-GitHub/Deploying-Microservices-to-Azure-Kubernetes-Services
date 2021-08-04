#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Master/Coral.MasterData.Api/Coral.MasterData.Api.csproj", "Master/Coral.MasterData.Api/"]
COPY ["Master/Coral.MasterData.Service/Coral.MasterData.Service.csproj", "Master/Coral.MasterData.Service/"]
COPY ["Master/Coral.MasterData.Broker/Coral.MasterData.Broker.csproj", "Master/Coral.MasterData.Broker/"]
COPY ["Infrastructure/Coral.Infrastructure.CrossCutting/Coral.Infrastructure.CrossCutting.csproj", "Infrastructure/Coral.Infrastructure.CrossCutting/"]
COPY ["Master/Coral.MasterData.Persistance/Coral.MasterData.Persistance.csproj", "Master/Coral.MasterData.Persistance/"]
COPY ["Master/Coral.MasterData.Domain/Coral.MasterData.Domain.csproj", "Master/Coral.MasterData.Domain/"]
RUN dotnet restore "Master/Coral.MasterData.Api/Coral.MasterData.Api.csproj"
COPY . .
WORKDIR "/src/Master/Coral.MasterData.Api"
RUN dotnet build "Coral.MasterData.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Coral.MasterData.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Coral.MasterData.Api.dll"]