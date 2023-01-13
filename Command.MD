## install new template
```
dotnet new --install .
```
or
```
dotnet new --install . --force
```

## use
```
dotnet new ca-webapi -o {output folder}
```

```
dotnet ef dbcontext scaffold "Server=192.168.1.5;Database=NTLAGENTDB;user id=Nos12;password=Info2010;" Microsoft.EntityFrameworkCore.SqlServer -o Models

```