##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
##Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
##For more information, please see https://aka.ms/containercompat
#
#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["StudentAdmissionService/StudentAdmissionService.csproj", "StudentAdmissionService/"]
#RUN dotnet restore "StudentAdmissionService/StudentAdmissionService.csproj"
#COPY . .
#WORKDIR "/src/StudentAdmissionService"
#RUN dotnet build "StudentAdmissionService.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "StudentAdmissionService.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "StudentAdmissionService.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#
#
#FROM mcr.microsoft.com/dotnet/aspnet:5.0  AS build-env
#WORKDIR /app
## Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore
## Copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out
#
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "StudentAdmissionService.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base



FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY StudentAdmissionService.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "StudentAdmissionService.dll"]
