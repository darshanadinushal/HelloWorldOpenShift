FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY ["HelloWorldOpenShift.csproj", "."]
RUN dotnet restore "HelloWorldOpenShift.csproj"
COPY . .
RUN dotnet publish "HelloWorldOpenShift.csproj" -c Release -o /out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /src

EXPOSE 80
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "HelloWorldOpenShift.dll"]