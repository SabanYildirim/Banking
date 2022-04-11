#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Banking.Api/Banking.Api.csproj", "src/Banking.Api/"]
COPY ["src/Banking.Infrastructure/Banking.Infrastructure.csproj", "src/Banking.Infrastructure/"]
COPY ["src/Banking.Application/Banking.Application.csproj", "src/Banking.Application/"]
RUN dotnet restore "src/Banking.Api/Banking.Api.csproj"
COPY . .
WORKDIR "/src/src/Banking.Api"
RUN dotnet build "Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Banking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Banking.Api.dll"]