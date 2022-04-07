FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["StrategyPattern2/StrategyPattern2.csproj", "StrategyPattern2/"]
RUN dotnet restore "StrategyPattern2/StrategyPattern2.csproj"
COPY . .
WORKDIR "/src/StrategyPattern2"
RUN dotnet build "StrategyPattern2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StrategyPattern2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StrategyPattern2.dll"]
