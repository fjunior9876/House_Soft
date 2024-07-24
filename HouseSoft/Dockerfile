FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copie os arquivos de projeto para os respectivos diretórios
COPY HouseSoft.Application/HouseSoft.Application.csproj HouseSoft.Application/
COPY HouseSoft.Data/HouseSoft.Data.csproj HouseSoft.Data/
COPY HouseSoft.Domain/HouseSoft.Domain.csproj HouseSoft.Domain/
COPY HouseSoft.Service/HouseSoft.Service.csproj HouseSoft.Service/

# Restaure as dependências do projeto
RUN dotnet restore HouseSoft.Application/HouseSoft.Application.csproj

# Copie o restante dos arquivos do projeto e publique o projeto
COPY . .
WORKDIR /src/HouseSoft.Application
RUN dotnet publish HouseSoft.Application.csproj -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "HouseSoft.Application.dll"]


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

