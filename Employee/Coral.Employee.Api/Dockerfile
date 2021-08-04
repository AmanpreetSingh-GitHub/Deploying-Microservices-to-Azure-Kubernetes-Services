#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Employee/Coral.Employee.Api/Coral.Employee.Api.csproj", "Employee/Coral.Employee.Api/"]
COPY ["Employee/Coral.Employee.Service/Coral.Employee.Service.csproj", "Employee/Coral.Employee.Service/"]
COPY ["Employee/Coral.Employee.Broker/Coral.Employee.Broker.csproj", "Employee/Coral.Employee.Broker/"]
COPY ["Employee/Coral.Employee.Persistance/Coral.Employee.Persistance.csproj", "Employee/Coral.Employee.Persistance/"]
COPY ["Infrastructure/Coral.Infrastructure.CrossCutting/Coral.Infrastructure.CrossCutting.csproj", "Infrastructure/Coral.Infrastructure.CrossCutting/"]
COPY ["Employee/Coral.Employee.Domain/Coral.Employee.Domain.csproj", "Employee/Coral.Employee.Domain/"]
RUN dotnet restore "Employee/Coral.Employee.Api/Coral.Employee.Api.csproj"
COPY . .
WORKDIR "/src/Employee/Coral.Employee.Api"
RUN dotnet build "Coral.Employee.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Coral.Employee.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Coral.Employee.Api.dll"]