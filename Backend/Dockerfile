FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /src
COPY Backend.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Backend.dll"]