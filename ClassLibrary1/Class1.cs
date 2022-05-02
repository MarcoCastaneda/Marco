namespace ClassLibrary1
{
  {
    public class Materia
    {
        public static ML.Result Add(ML.Proveedor proveedor)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var query = context.Database.ExecuteSqlRaw($"ProveedorAdd {proveedor.Nombre}, {proveedor.Telefono}");

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
        public static ML.Result GetById(int Idproveedor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var obj = context.Proveedor.FromSqlRaw($"ProveedorById {IdProveedor}").AsEnumerable().FirstOrDefault();

                    if (obj != null)
                    {
                        ML.Proveedor proveedor = new ML.proveedor();
                        proveedor.IdProveedor = obj.IdProveedor;
                        proveedor.Nombre = obj.Nombre;
                        proveedor.telefono = obj.telefono;
                        
                        result.Object = Proveedor;
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo realizar la consulta";
                    }

                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.Marco context = new DL.Marco())

                {
                    var query = context.Proveedor.FromSqlRaw("ProveedorGetAll").ToList();

                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Proveedor proveedor = new ML.Proveedor();
                            proveedor.IdProveedor = obj.IdProveedor;
                            proveedor.Nombre = obj.Nombre;
                            proveedor.telefono = obj.telefono;

                            result.Objects.Add(proveedor);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar la consulta";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
        public static ML.Result Update(ML.Proveedor proveedor)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var query = context.Database.ExecuteSqlRaw($" PorveedorUpdate '{proveedor.IdProveedor}', {proveedor.Nombre}, {proveedor.Telefono}");


                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
}