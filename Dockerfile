FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY ./output .
ENTRYPOINT ["dotnet", "BlogNet.dll"]
