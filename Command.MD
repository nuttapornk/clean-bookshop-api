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


dotnet ef dbcontext scaffold "Server=.\;Database=NTLAGENTDB;trusted_connection=true;encrypt=false;" Microsoft.EntityFrameworkCore.SqlServer --project src\Infrastructure --startup-project src\WebApi --output-dir src\Domain\Entities



dotnet ef dbcontext scaffold "Server=.\;Database=NTLAGENTDB;trusted_connection=true;encrypt=false;" Microsoft.EntityFrameworkCore.SqlServer -o ..\Domain\Entities\ --namespace Domain.Entities

from root directory

dotnet ef migrations add "initialDatabase" --project .\src\Infrastructure\ --startup-project .\src\WebApi\ --output-dir Persistence\Migrations

dotnet ef migrations add "AddCategory" --project .\src\Infrastructure\ --startup-project .\src\WebApi\ --output-dir Persistence\Migrations


dotnet ef migrations remove --project .\src\Infrastructure\ --startup-project .\src\WebApi\