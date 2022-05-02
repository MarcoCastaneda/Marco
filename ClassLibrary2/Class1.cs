namespace ClassLibrary2
{
    public class Materia
    {
        public static ML.Result Add(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var query = context.Database.ExecuteSqlRaw($"DepartamentoAdd {departamento.Nombre}, {departamento.Area},    ");

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
        public static ML.Result GetById(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var obj = context.Departamento.FromSqlRaw($"ProveedorById {IdDepartamento}").AsEnumerable().FirstOrDefault();

                    if (obj != null)
                    {
                        ML.Departamento departamento = new ML.Departamento();
                        departamento.IdDepartamento = obj.IdDepartamento;
                        departamento.Nombre = obj.Nombre;
                        departamento.Area = new ML.Area();
                        departamento.IdArea = obj.IdArea;

                        result.Object = departamento;
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
                            ML.Departamento departamento = new ML.Departamento();
                            departamento.IdDepartamento = obj.IdDepartamento;
                            departamento.Nombre = obj.Nombre;

                            departamento.Area = new ML.Area();

                            departamento.Area.IdArea = obj.IdArea;

                            result.Objects.Add(departamento);
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
        public static ML.Result Update(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Marco context = new DL.Marco())
                {
                    var query = context.Database.ExecuteSqlRaw($" DepartamentoUpdate '{departamento.IdDepartamenti}', {departamento.Nombre}, {departamento.Area.IdArea}");


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