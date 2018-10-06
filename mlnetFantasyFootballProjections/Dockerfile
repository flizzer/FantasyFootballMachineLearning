FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app

COPY *.sln .
COPY api/*.csproj ./api/
RUN dotnet restore

COPY api/. ./api/
WORKDIR /app/api
RUN dotnet publis -c release -o out

FROM microsoft/aspnetcore:2.0 AS runtime
WORKDIR /app
COPY api/model.zip .
COPY --from=build /app/api/out ./
ENTRYPOINT [ "dotnet", "api.dll" ]