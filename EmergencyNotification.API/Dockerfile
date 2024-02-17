FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["EmergencyNotification.API/EmergencyNotification.API.csproj", "EmergencyNotification.API/"]
RUN dotnet restore "EmergencyNotification.API/EmergencyNotification.API.csproj"
COPY . .
WORKDIR "/src/EmergencyNotification.API"
RUN dotnet build "EmergencyNotification.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmergencyNotification.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmergencyNotification.API.dll"]
