CREATE PROCEDURE ProveedorGetAll
AS
    SELECT
    proveedor.IdProveedor,
    proveedor.Nombre
    proveedor.Telefono

    CREATE PROCEDURE ProveedorGetById
AS
    SELECT
    proveedor.IdProveedor,
    proveedor.Nombre
    proveedor.Telefono

    WHERE 

    IdProveedor = @IdProveedor

CREATE PROCEDURE ProveeddorAdd

    @Nombre VARCHAR (100),
    @Telefono VARCHAR (20)

    INSERT INTO Proveedor

    Nombre,
    Telefono

    VALUES (
    
@Nombe,
@Telefono)


        CREATE PROCEDURE ProveedorUpdate(
    @IdProveedor,
    Nombre,
    Telefono)
    as

    UPDATE Proveedor
    SET Nombre = @Nombre,
    Telefono = @Telefono 

    WHERE IdProveedor = @IdProveedor



    CREATE PROCEDURE DepartamentoGetAll
AS
    SELECT
    departamento.IdDepartamento,
    departamento.Nombre
    departamento.IdArea
    Area.Area as AreaNombre

    CREATE PROCEDURE DepartamentoGetById
AS
    SELECT
    Departamento.IdDepartamento,
    Departamento.Nombre
    Departamento.IdArea
    Area.Area as AreaNombre
    WHERE 

    IdDepartamento = @IdDepartamento

CREATE PROCEDURE ProveeddorAdd

    @Nombre VARCHAR (100),
    @IdArea INT

    INSERT INTO Departamento

    Nombre,
    IdArea

    VALUES (
    
@Nombe,
 @IdArea)


        CREATE PROCEDURE DepartamentoUpdate(
    @IdDepartamento,
    Nombre,
    IdArea)
    as

    UPDATE Departamento
    SET Nombre = @Nombre,
    IdArea = @IdArea 

    WHERE IdDepartamento = @IdDepartamento
