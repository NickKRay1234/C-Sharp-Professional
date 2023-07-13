FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Користувальницкі колекції.csproj", "./"]
RUN dotnet restore "Користувальницкі колекції.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Користувальницкі колекції.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Користувальницкі колекції.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Користувальницкі колекції.dll"]
