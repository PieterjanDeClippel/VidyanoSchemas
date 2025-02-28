# Stage 1: Compile and Run .NET application

# Use official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /App

# Copy everything
COPY src/Vidyano.Model ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet run --project Vidyano.SchemaGenerator/Vidyano.SchemaGenerator.csproj --configuration Release

# Stage 2: Serve app with nginx server

# Use official nginx image as the base image
FROM nginx:latest
LABEL org.opencontainers.image.source="https://github.com/MintPlayer/mintplayer-ng-video-player"

WORKDIR /
COPY --from=build /App/output /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Expose port 80
EXPOSE 80

# docker build --tag 'vidyano-schemas' .
# docker run -p 4201:80 vidyano-schemas
# Visit http://localhost:4201