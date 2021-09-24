#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Src/Base.Api/Base.Api.csproj", "Src/Base.Api/"]
RUN dotnet restore "Src/Base.Api/Base.Api.csproj"
COPY . .
WORKDIR "/src/Src/Base.Api"
RUN dotnet build "Base.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Base.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Base.Api.dll"]