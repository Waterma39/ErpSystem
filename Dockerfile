# 基礎映像檔：.NET 10 SDK 用來建置
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["ErpSystem.csproj", "./"]
RUN dotnet restore "ErpSystem.csproj"
COPY . .
RUN dotnet publish -c Release -o /app/publish

# 執行階段映像檔
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ErpSystem.dll"]