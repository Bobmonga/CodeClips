FROM microsoft/dotnet:sdk AS build-env
COPY src /app
WORKDIR /app

RUN dotnet restore 
#--configfile ../NuGet.Config
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0-runtime
WORKDIR /app
COPY --from=build-env /app/CodeClips/out .
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "CodeClips.dll"]