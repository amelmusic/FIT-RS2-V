FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY . .
RUN dotnet restore

#we go to specific csproj and build / publish it to directory named out
WORKDIR /app/eProdaja.WebAPI
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/eProdaja.WebAPI/out ./
ENTRYPOINT ["dotnet", "eProdaja.WebAPI.dll"]